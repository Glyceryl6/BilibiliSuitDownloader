using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Newtonsoft.Json.Linq;
using Panel = AntdUI.Panel;

namespace BilibiliSuitDownloader {
    
    public partial class MainForm : AntdUI.Window {
        
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();
        
        public MainForm() {
            InitializeComponent();
            AllocConsole();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            FreeConsole();
        }

        private void FixLastColumnWidth(object sender, EventArgs e) {
            int suitDataGridWidth = 0, collectionDataGridWidth = 0;
            int j = suitDataGrid.ColumnCount - 1;
            int k = collectionDataGrid.ColumnCount - 1;
            for (var i = 0; i < j; i++) {
                suitDataGridWidth += suitDataGrid.Columns[i].Width;
            }

            for (var i = 0; i < k; i++) {
                collectionDataGridWidth += collectionDataGrid.Columns[i].Width;
            }
            
            suitDataGrid.Columns[j].Width = suitDataGrid.Width - suitDataGridWidth;
            collectionDataGrid.Columns[k].Width = collectionDataGrid.Width - collectionDataGridWidth;
        }
        
        private void BindingDataGridViewToButton(object sender, EventArgs e) {
            foreach (Control control in panel1.Controls) {
                if (control is BiliRadioButton { Parent: Panel _ } button) {
                    button.BindingForm = this;
                    if (button.BackColor != null) {
                        Color color = button.BackColor.Value;
                        button.BackActive = MiscUtils.ChangeColor(color, -0.15F);
                        button.BackHover = MiscUtils.ChangeColor(color, 0.15F);
                    }
                }
            }
        }
        
        private void QueryButton_Click(object sender, EventArgs e) {
            MiscUtils.CopyDataGridViewContent(dataGridView1, suitDataGrid);
            string text = textBox1.Text;
            if (string.IsNullOrEmpty(text)) return;
            string rowFilter = $"名称 like '%{text}%' or 分组 like '%{text}%' or 描述 like '%{text}%'";
            MiscUtils.QueryDataFromDataGridView(suitDataGrid, rowFilter);
        }

        private void button2_Click(object sender, EventArgs e) {
            DisableOrEnableButton(this, false);
            suitDataGrid.DataSource = null;
            suitDataGrid.Rows.Clear();
            GetSuitDataByGroupId();
            panel1.Enabled = true;
            MiscUtils.CopyDataGridViewContent(suitDataGrid, dataGridView1);
            DisableOrEnableButton(this, true);
        }
        
        private void button6_Click(object sender, EventArgs e) {
            int i = collectionDataGrid.ColumnCount - 1;
            DisableOrEnableButton(this, false);
            int width = collectionDataGrid.Columns[i].Width;
            collectionDataGrid.Rows.Clear();
            GetCollectionData();
            collectionDataGrid.Columns[i].Width = width;
            tabControl1.SelectedIndex = 1;
            DisableOrEnableButton(this, true);
        }

        //下载所有的装扮并在进度条上同步
        private void ExportAllSuitButton_Click(object sender, EventArgs e) {
            int rowCount = suitDataGrid.RowCount;
            if (rowCount <= 0) return;
            long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            // DisableOrEnableButton(this, false);
            progressBar1.Maximum = rowCount;
            for (int i = 0; i < rowCount; i++) {
                DownloadSuitById(suitDataGrid[1, i].Value.ToString());
                label4.Text = progressBar1.Value + 1 + @"/" + progressBar1.Maximum;
                Thread.Sleep(i % 50 == 0 ? 3000 : 100);
                progressBar1.Value++;
            }
            
            DownloadDone(startTime);
        }
        
        //下载收藏集并在进度条上同步
        private void button5_Click(object sender, EventArgs e) {
            int rowCount = collectionDataGrid.RowCount;
            if (rowCount <= 0) return;
            long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            // DisableOrEnableButton(this, false);
            progressBar1.Maximum = rowCount;
            for (int i = 0; i < rowCount; i++) {
                string filename = collectionDataGrid[3, i].Value.ToString();
                filename = Path.GetInvalidFileNameChars().Aggregate(filename, (current, invalidChar) => 
                    current.Replace(invalidChar.ToString(), string.Empty));
                string directory = textBox2.Text + "\\" + filename;
                string actId = collectionDataGrid[1, i].Value.ToString();
                string lotteryId = collectionDataGrid[2, i].Value.ToString();
                DownloadCollectionById(actId, lotteryId, directory);
                label4.Text = progressBar1.Value + 1 + @"/" + progressBar1.Maximum;
                Thread.Sleep(i % 100 == 0 ? 2000 : 10);
                progressBar1.Value++;
            }
            
            DownloadDone(startTime);
        }

        //下载勾选的装扮
        private void ExportSelectedSuitButton_Click(object sender, EventArgs e) {
            long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            // DisableOrEnableButton(this, false);
            HashSet<string> hashSet = GetAllCheckedBoxInDataGridView();
            if (hashSet.Count > 0) {
                progressBar1.Maximum = hashSet.Count;
                foreach (string id in hashSet) {
                    DownloadSuitById(id);
                    label4.Text = progressBar1.Value + 1 + @"/" + progressBar1.Maximum;
                    Thread.Sleep(progressBar1.Value % 50 == 0 ? 3000 : 10);
                    progressBar1.Value++;
                }
            }
            
            DownloadDone(startTime);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e) {
            panel1.Enabled = e.TabPageIndex == 0 && QueryButton.Enabled;
        }

        //所有装扮下载完成时的提示
        private void DownloadDone(long startTime) {
            DisableOrEnableButton(this, true);
            long endTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            progressBar1.Value = 0;
            string time = FormatTime(endTime - startTime);
            MessageBox.Show(@"导出完成，总共耗时：" + time, @"提示", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //获取所有装扮的信息
        private void GetSuitDataByGroupId() {
            JArray suitArray = new JArray();
            for (var i = 0; i < GetSuitTotalPage(); i++) {
                suitArray.Merge(GetSuitArrayByPage(i));
            }
            
            suitDataGrid.Rows.Add(suitArray.Count);
            for (var i = 0; i < suitArray.Count; i++) {
                JObject tempObject = JObject.Parse(suitArray[i].ToString());
                JObject properties = JObject.Parse(tempObject["properties"].ToString());
                suitDataGrid[1, i].Value = tempObject["item_id"]?.ToString();
                suitDataGrid[2, i].Value = tempObject["name"]?.ToString();
                suitDataGrid[3, i].Value = GetGroupSubTabs()[int.Parse(tempObject["group_id"]?.ToString() ?? "0")];
                suitDataGrid[5, i].Value = int.Parse(properties["sale_bp_forever_raw"]?.ToString() ?? "0") / 100 + "元";
                suitDataGrid[6, i].Value = tempObject["sale_surplus"]?.ToString();
                suitDataGrid[7, i].Value = properties["desc"]?.ToString();
            }
        }

        //获取装扮列表的页数
        private static int GetSuitTotalPage() {
            const string biliUrl = "https://api.bilibili.com/x/garb/v2/mall/partition/item/list?part_id=6&sort_type=2";
            JObject jObject = GetJsonFromUrl(biliUrl);
            JToken token = jObject["data"]?["page"]?["total"];
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0 && token != null) {
                return (int) Math.Ceiling(int.Parse(token.ToString()) / 20.0F);
            }
            
            return 0;
        }

        //获取指定页的装扮信息
        private static JArray GetSuitArrayByPage(int pageNum) {
            string extraParams = "group_id=0&part_id=6&pn=" + pageNum + "&ps=20&sort_type=2";
            JObject jObject = GetJsonFromUrl("https://api.bilibili.com/x/garb/v2/mall/partition/item/list?" + extraParams);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0 && jObject["data"]?["list"] != null) {
                return JArray.Parse(jObject["data"]["list"].ToString());
            }
            
            return null;
        }

        //根据ID来下载装扮内容
        private void DownloadSuitById(string id) {
            string directory = textBox2.Text;
            string biliUrl = "https://api.bilibili.com/x/garb/v2/mall/suit/detail?from=&from_id=&item_id=" + id + "&part=suit";
            JObject jObject = GetJsonFromUrl(biliUrl);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0 && jObject["data"] != null) {
                JToken suitItemsToken = jObject["data"]["suit_items"];
                string itemName = jObject["data"]["name"]?.ToString();
                itemName = itemName != null && itemName.EndsWith("...") ? itemName.Replace("...", "…") : itemName;
                string group = GetGroupSubTabs()[int.Parse(jObject["data"]["group_id"]?.ToString() ?? "0")].ToString();
                directory += (directory.EndsWith("\\") ? "" : "\\") + group + "\\" + itemName + "\\";
                label3.Text = @"装扮名称：" + itemName;
                WebClient webClient = new WebClient();
                if (!Directory.Exists(directory)) {
                    Directory.CreateDirectory(directory);
                }

                if (suitItemsToken == null) return;
                foreach (JToken token in suitItemsToken) {
                    string[] paths = token.Path.Split('.');
                    string path = directory + paths.Last() + "\\";
                    bool isEmojiPackage = paths.Last().Equals("emoji_package");
                    if (!Directory.Exists(path) && !isEmojiPackage) {
                        Directory.CreateDirectory(path);
                    }
                    
                    if (!isEmojiPackage) {
                        JToken tempToken = suitItemsToken[paths.Last()];
                        JArray suitArray = JArray.Parse(tempToken.ToString());
                        foreach (JToken token1 in suitArray) {
                            JToken properties = token1["properties"];
                            foreach (JToken token2 in properties) {
                                string objects = token2.Path.Split('.').Last();
                                string link = properties[objects]?.ToString();
                                Regex regex = new Regex("((http|https)://)");
                                if (link?.Length > 0 && regex.Match(link).Success) {
                                    int lastIndex = link.LastIndexOf("/", StringComparison.Ordinal);
                                    string filename = path + link.Substring(lastIndex).Trim('/');
                                    if (!File.Exists(filename)) {
                                        if (link.Contains("hdslb.com")) {
                                            webClient.DownloadFile(link, filename);
                                            OutPutInfoToTerminal(link, filename);
                                        } else {
                                            int i = filename.IndexOf('?');
                                            filename = filename.Remove(i) + ".txt";
                                            File.WriteAllText(filename, link);
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        JArray emojiArray = JArray.Parse(suitItemsToken["emoji_package"].ToString());
                        foreach (JToken token1 in emojiArray) {
                            JArray itemArray = JArray.Parse(token1["items"].ToString());
                            foreach (JToken itemToken in itemArray) {
                                string emojiName = itemToken["name"]?.ToString()
                                    .Replace("[", "").Replace("]", "");
                                string link = itemToken["properties"]?["image"]?.ToString();
                                if (emojiName != null && emojiName.Contains("?")) {
                                    emojiName = emojiName.Replace("?", "？");
                                }
                                string filename = directory + emojiName + ".png";
                                if (link != null && !File.Exists(filename)) {
                                    webClient.DownloadFile(link, filename);
                                    OutPutInfoToTerminal(link, filename);
                                }
                            }
                        }
                    }
                }
            }
        }

        //获取收藏集的ID、抽奖ID、活动名和售价
        private void GetCollectionData() {
            JObject jObject = GetJsonFromUrl("https://api.bilibili.com/x/garb/card/subject/list?subject_id=42");
            if (jObject["code"] == null || int.Parse(jObject["code"].ToString()) != 0) return;
            JArray subjectCardList = JArray.Parse(jObject["data"]["subject_card_list"].ToString());
            collectionDataGrid.Rows.Add(subjectCardList.Count);
            for (int i = 0; i < subjectCardList.Count; i++) {
                JObject tempObject = JObject.Parse(subjectCardList[i].ToString());
                var actId = tempObject["act_id"]?.ToString();
                var lotteryId = tempObject["lottery_id"]?.ToString();
                var salePrice = tempObject["sale_price"]?.ToString();
                collectionDataGrid[1, i].Value = actId;
                collectionDataGrid[2, i].Value = lotteryId;
                collectionDataGrid[3, i].Value = tempObject["act_name"]?.ToString();
                collectionDataGrid[5, i].Value = (salePrice != null ? int.Parse(salePrice) : 0) / 100 + "元";
                GetCollectionDetail(actId, lotteryId, i);
                Thread.Sleep(i % 50 == 0 ? 2000 : 100);
            }
        }

        //获取收藏集的活动名字、总销量和抽奖信息
        private void GetCollectionDetail(string actId, string lotteryId, int rowIndex) {
            JObject jObject = GetJsonFromUrl("https://api.bilibili.com/x/vas/dlc_act/lottery/detail?act_id=" + actId + "&lottery_id=" + lotteryId);
            if (jObject["code"] == null || int.Parse(jObject["code"].ToString()) != 0) return;
            collectionDataGrid[4, rowIndex].Value = jObject["data"]?["name"]?.ToString();
            collectionDataGrid[6, rowIndex].Value = jObject["data"]?["total_sale_amount"]?.ToString();
            collectionDataGrid[7, rowIndex].Value = jObject["data"]?["lottery_desc"]?.ToString();
        }

        //根据ID来下载收藏集内容
        private void DownloadCollectionById(string actId, string lotteryId, string directory) {
            // string biliUrl = "https://api.bilibili.com/x/vas/dlc_act/act/item/list?act_id=" + actId;
            JObject jObject = GetJsonFromUrl("https://api.bilibili.com/x/vas/dlc_act/lottery_home_detail?act_id=" + actId + "&lottery_id=" + lotteryId);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0 && jObject["data"] != null) {
                JArray itemList = JArray.Parse(jObject["data"]["item_list"].ToString());
                WebClient webClient = new WebClient();
                directory += directory.EndsWith("\\") ? "" : "\\";
                if (!Directory.Exists(directory)) {
                    Directory.CreateDirectory(directory);
                }
                
                DownloadCollectionCover(webClient, actId, directory);
                foreach (JToken token in itemList) {
                    if (token["card_info"] != null) {
                        JObject tempObject = JObject.Parse(token["card_info"].ToString());
                        var cardName = tempObject["card_name"]?.ToString();
                        var cardImg = tempObject["card_img"]?.ToString();
                        if (cardImg != null) {
                            string[] segments = cardImg.Split('/');
                            string filename = directory + cardName + Path.GetExtension(segments.Last());
                            if (!File.Exists(filename)) {
                                webClient.DownloadFile(cardImg, filename);
                                OutPutInfoToTerminal(cardImg, filename);
                            }
                        }

                        JToken cardTypeToken = tempObject["card_type"];
                        if (cardTypeToken != null && cardTypeToken.ToString().Equals("2") && tempObject["video_list"] != null) {
                            JArray videoList = JArray.Parse(tempObject["video_list"].ToString());
                            DownloadStreaming(webClient, videoList[0].ToString(), directory + cardName);
                        }
                    }
                }

                JToken jToken = jObject["data"]["collect_list"];
                if (jToken == null) return;
                JObject collectList = JObject.Parse(jToken.ToString());
                JToken infosToken = collectList["collect_infos"];
                if (infosToken is { HasValues: true }) {
                    JArray collectInfos = JArray.Parse(infosToken.ToString());
                    foreach (JToken token in collectInfos) {
                        var redeemItemName = token["redeem_item_name"]?.ToString();
                        var redeemItemImage = token["redeem_item_image"]?.ToString();
                        JToken cardItemToken = token["card_item"];
                        if (cardItemToken is { HasValues: true } && cardItemToken["card_type_info"] != null) {
                            JToken cardTypeInfoToken = cardItemToken["card_type_info"];
                            if (cardTypeInfoToken.HasValues) {
                                JObject cardTypeInfo = JObject.Parse(cardTypeInfoToken.ToString());
                                var list = cardTypeInfo["content"]?["animation"]?["animation_video_urls"]?.ToString();
                                var cardName = cardTypeInfo["name"]?.ToString();
                                redeemItemName = cardName;
                                if (list != null) {
                                    string animationVideoUrl = JArray.Parse(list)[0].ToString();
                                    string filename = directory + "collect_infos\\" + cardName;
                                    DownloadStreaming(webClient, animationVideoUrl, filename);
                                }
                            }
                        }

                        if (redeemItemName != null && redeemItemImage != null) {
                            string[] segments = redeemItemImage.Split('/');
                            redeemItemName += Path.GetExtension(segments.Last());
                            string newDir = directory + "collect_infos\\";
                            string filename = newDir + redeemItemName;
                            if (!Directory.Exists(newDir)) {
                                Directory.CreateDirectory(newDir);
                            }
                            
                            if (!File.Exists(filename)) {
                                webClient.DownloadFile(redeemItemImage, filename);
                                OutPutInfoToTerminal(redeemItemImage, filename);
                            }
                        }
                    }
                }

                JToken chainToken = collectList["collect_chain"];
                if (chainToken is { HasValues: true }) {
                    JArray collectChain = JArray.Parse(chainToken.ToString());
                    foreach (JToken token in collectChain) {
                        var redeemItemName = token["redeem_item_name"]?.ToString();
                        var redeemItemImage = token["redeem_item_image"]?.ToString();
                        if (redeemItemName != null && redeemItemImage != null) {
                            string[] segments = redeemItemImage.Split('/');
                            redeemItemName += Path.GetExtension(segments.Last());
                            string newDir = directory + "collect_chain\\";
                            string filename = newDir + redeemItemName;
                            if (!Directory.Exists(newDir)) {
                                Directory.CreateDirectory(newDir);
                            }
                            
                            if (!File.Exists(filename)) {
                                webClient.DownloadFile(redeemItemImage, filename);
                                OutPutInfoToTerminal(redeemItemImage, filename);
                            }
                        }
                    }
                }
            }
        }

        //下载收藏集的封面图
        private void DownloadCollectionCover(WebClient webClient, string actId, string directory) {
            JObject jObject = GetJsonFromUrl("https://api.bilibili.com/x/vas/dlc_act/act/basic?act_id=" + actId);
            if (jObject["code"] == null || int.Parse(jObject["code"].ToString()) != 0) return;
            JArray lotteryList = JArray.Parse(jObject["data"]["lottery_list"].ToString());
            string lotteryImage = lotteryList[0]["lottery_image"]?.ToString();
            string coverFile = directory + "封面.png";
            if (lotteryImage != null && !File.Exists(coverFile)) {
                webClient.DownloadFile(lotteryImage, coverFile);
                OutPutInfoToTerminal(lotteryImage, coverFile);
            }
        }

        //获取装扮的分类列表
        private static Hashtable GetGroupSubTabs() {
            Hashtable hashtable = new Hashtable();
            JObject jObject = GetJsonFromUrl("https://api.bilibili.com/x/garb/v2/mall/subtabs?part_id=6");
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                JToken jToken = jObject["data"]?["list"];
                if (jToken == null) return hashtable;
                JArray groupList = JArray.Parse(jToken.ToString());
                foreach (JToken token in groupList) {
                    JObject tempObject = JObject.Parse(token.ToString());
                    var groupId = tempObject["group_id"]?.ToString();
                    var groupName = tempObject["group_name"]?.ToString();
                    if (groupId != null && groupName != null) {
                        hashtable.Add(int.Parse(groupId), groupName);
                    }
                }
            }
            
            return hashtable;
        }

        //获取链接中的Json文本内容
        private static JObject GetJsonFromUrl(string url) {
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);
            req.Method = "GET"; req.ContentType = "application/json, charset=utf-8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36 Edg/112.0.1722.48";
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(stream, false);
            return JObject.Parse(reader.ReadToEnd());
        }
        
        //将时间戳转换成标准的时分秒格式
        private static string FormatTime(long sec) {
            long hour = sec / 3600;
            long minute = sec % 3600 / 60;
            long second = sec % 60;
            return hour + "小时" + minute + "分钟" + second + "秒";
        }

        private HashSet<string> GetAllCheckedBoxInDataGridView() {
            HashSet<string> hashSet = new HashSet<string>();
            for (int i = 0; i < suitDataGrid.RowCount; i++) {
                if (suitDataGrid[0, i].Selected) {
                    hashSet.Add(suitDataGrid[1, i].Value.ToString());
                }
            }

            return hashSet;
        }

        //禁用或启用所有的按钮
        private static void DisableOrEnableButton(Control ctrlTop, bool enabled) {
            foreach (Control control in (ArrangedElementCollection) ctrlTop.Controls) {
                if (control.GetType() == typeof(AntdUI.Button)) {
                    control.Enabled = enabled;
                } 
            }
        }

        //下载流媒体文件
        private void DownloadStreaming(WebClient webClient, string link, string filename) {
            try {
                if (File.Exists(filename + ".mp4")) return;
                webClient.DownloadFile(link, filename + ".mp4");
                OutPutInfoToTerminal(link, filename + ".mp4");
            } catch (Exception) {
                if (File.Exists(filename + ".txt")) return;
                Console.WriteLine(@"资源下载失败，正在将链接保存为：" + filename + @".txt");
                File.WriteAllText(filename + ".txt", link);
            }
        }

        //将下载进度输出至命令行，并显示所下载文件的大小
        private void OutPutInfoToTerminal(string link, string filename) {
            FileInfo fileInfo = new FileInfo(filename);
            double fileSize = fileInfo.Length;
            string[] sizes = { "B", "KB", "MB" };
            int order = 0;
            while (fileSize >= 1024 && order < sizes.Length - 1) {
                fileSize /= 1024;
                order++;
            }
            
            string sizeString = $"{fileSize:0.0} {sizes[order]}";
            label5.Text = @"正在将：" + @"""" + link + @"""" + @" 下载至：" + @"""" + filename + @"""";
            Console.WriteLine(@"(" + label4.Text + @") " + label5.Text + @" [" + sizeString + @"]");
        }
        
    }
}