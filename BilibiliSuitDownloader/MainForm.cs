using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using BilibiliSuitDownloader.Properties;
using Newtonsoft.Json.Linq;

namespace BilibiliSuitDownloader {
    
    public partial class MainForm : Form {
        
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
            for (var i = 0; i < suitDataGrid.ColumnCount - 1; i++) {
                suitDataGridWidth += suitDataGrid.Columns[i].Width;
            }

            for (var i = 0; i < collectionDataGrid.ColumnCount - 1; i++) {
                collectionDataGridWidth += collectionDataGrid.Columns[i].Width;
            }

            suitDataGrid.Columns[7].Width = suitDataGrid.Width - suitDataGridWidth;
            collectionDataGrid.Columns[6].Width = collectionDataGrid.Width - collectionDataGridWidth;
        }
        
        private void PutGroupDataInCheckedListBox(object sender, EventArgs e) {
            foreach (DictionaryEntry group in GetGroupSubTabs()) {
                if (!group.Key.ToString().Equals("0")) {
                    checkedListBox1.Items.Add(group.Key + "_" + group.Value);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DisableOrEnableButton(this, false);
            suitDataGrid.Rows.Clear();
            GetSuitDataFromPage();
            DisableOrEnableButton(this, true);
        }
        
        private void button6_Click(object sender, EventArgs e) {
            DisableOrEnableButton(this, false);
            int width = collectionDataGrid.Columns[6].Width;
            collectionDataGrid.Rows.Clear();
            GetCollectionData();
            collectionDataGrid.Columns[6].Width = width;
            tabControl1.SelectedIndex = 1;
            DisableOrEnableButton(this, true);
        }

        private void ExportAllSuitButton_Click(object sender, EventArgs e) {
            int rowCount = suitDataGrid.RowCount;
            if (rowCount > 0) {
                long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                // DisableOrEnableButton(this, false);
                progressBar1.Maximum = rowCount;
                for (int i = 0; i < rowCount; i++) {
                    DownloadSuitById(suitDataGrid[1, i].Value.ToString());
                    label4.Text = progressBar1.Value + @"/" + progressBar1.Maximum;
                    Thread.Sleep(i % 50 == 0 ? 3000 : 100);
                    progressBar1.Value++;
                }
                DownloadDone(startTime);
            }
        }
        
        private void button5_Click(object sender, EventArgs e) {
            int rowCount = collectionDataGrid.RowCount;
            if (rowCount > 0) {
                long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                // DisableOrEnableButton(this, false);
                progressBar1.Maximum = rowCount;
                for (int i = 0; i < rowCount; i++) {
                    string filename = collectionDataGrid[2, i].Value.ToString();
                    foreach (char invalidChar in Path.GetInvalidFileNameChars()) {
                        filename = filename.Replace(invalidChar.ToString(), string.Empty);
                    }
                    string directory = textBox2.Text + "\\" + filename;
                    DownloadCollectionById(collectionDataGrid[1, i].Value.ToString(), directory);
                    label4.Text = progressBar1.Value + @"/" + progressBar1.Maximum;
                    Thread.Sleep(i % 100 == 0 ? 2000 : 10);
                    progressBar1.Value++;
                }
                DownloadDone(startTime);
            }
        }

        private void ExportSelectedSuitButton_Click(object sender, EventArgs e) {
            long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            // DisableOrEnableButton(this, false);
            HashSet<string> hashSet = checkBox13.Checked ? 
                GetAllCheckedBoxInCheckedListBox() : GetAllCheckedBoxInDataGridView();
            if (hashSet.Count > 0) {
                progressBar1.Maximum = hashSet.Count;
                foreach (string id in hashSet) {
                    DownloadSuitById(id);
                    label4.Text = progressBar1.Value + @"/" + progressBar1.Maximum;
                    Thread.Sleep(progressBar1.Value % 50 == 0 ? 3000 : 10);
                    progressBar1.Value++;
                }
            }
            
            DownloadDone(startTime);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e) {
            checkBox13.BackgroundImage = checkBox13.Checked ? 
                Resources.switch_on : Resources.switch_off;
            checkedListBox1.Enabled = checkBox13.Checked;
        }

        private void DownloadDone(long startTime) {
            DisableOrEnableButton(this, true);
            long endTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            progressBar1.Value = 0;
            string time = FormatTime(endTime - startTime);
            MessageBox.Show(@"导出完成，总共耗时：" + time, @"提示", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetSuitDataFromPage() {
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
                suitDataGrid[3, i].Value = GetGroupSubTabs()[int.Parse(tempObject["group_id"].ToString())];
                suitDataGrid[5, i].Value = int.Parse(properties["sale_bp_forever_raw"].ToString()) / 100 + "元";
                suitDataGrid[6, i].Value = tempObject["sale_surplus"]?.ToString();
                suitDataGrid[7, i].Value = properties["desc"]?.ToString();
            }
        }

        private static int GetSuitTotalPage() {
            string biliUrl = "https://api.bilibili.com/x/garb/v2/mall/partition/item/list?part_id=6&sort_type=2";
            JObject jObject = GetJsonFromUrl(biliUrl);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                int totalCount = int.Parse(jObject["data"]["page"]["total"].ToString());
                return (int) Math.Ceiling(totalCount / 20.0F);
            }
            return 0;
        }

        private static JArray GetSuitArrayByPage(int pageNum) {
            string biliUrl = "https://api.bilibili.com/x/garb/v2/mall/partition/item/list?group_id=0&part_id=6&pn=" + pageNum + "&ps=20&sort_type=2";
            JObject jObject = GetJsonFromUrl(biliUrl);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                return JArray.Parse(jObject["data"]["list"].ToString());
            }
            return null;
        }

        private void DownloadSuitById(string id) {
            string directory = textBox2.Text;
            string biliUrl = "https://api.bilibili.com/x/garb/v2/mall/suit/detail?from=&from_id=&item_id=" + id + "&part=suit";
            JObject jObject = GetJsonFromUrl(biliUrl);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                JToken suitItemsToken = jObject["data"]?["suit_items"];
                string itemName = jObject["data"]?["name"]?.ToString();
                itemName = itemName != null && itemName.EndsWith("...") ? itemName.Replace("...", "…") : itemName;
                string group = GetGroupSubTabs()[int.Parse(jObject["data"]["group_id"].ToString())].ToString();
                directory += (directory.EndsWith("\\") ? "" : "\\") + group + "\\" + itemName + "\\";
                label3.Text = @"装扮名称：" + itemName;
                WebClient webClient = new WebClient();
                if (!Directory.Exists(directory)) {
                    Directory.CreateDirectory(directory);
                }

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
                                            label5.Text = @"正在将：" + @"""" + link + @"""" + @" 下载至：" + @"""" + filename + @"""";
                                            Console.WriteLine(@"(" + label4.Text + @") " + label5.Text);
                                            webClient.DownloadFile(link, filename);
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
                                    label5.Text = @"正在将：" + @"""" + link + @"""" + @" 下载至：" + @"""" + filename + @"""";
                                    Console.WriteLine(@"(" + label4.Text + @") " + label5.Text);
                                    webClient.DownloadFile(link, filename);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void GetCollectionData() {
            JObject jObject = GetJsonFromUrl("https://api.bilibili.com/x/garb/card/subject/list?subject_id=42");
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                JArray subjectCardList = JArray.Parse(jObject["data"]["subject_card_list"].ToString());
                collectionDataGrid.Rows.Add(subjectCardList.Count);
                for (int i = 0; i < subjectCardList.Count; i++) {
                    JObject tempObject = JObject.Parse(subjectCardList[i].ToString());
                    string actId = tempObject["act_id"]?.ToString();
                    string lotteryId = tempObject["lottery_id"]?.ToString();
                    collectionDataGrid[1, i].Value = actId;
                    collectionDataGrid[2, i].Value = lotteryId;
                    collectionDataGrid[3, i].Value = tempObject["act_name"]?.ToString();
                    collectionDataGrid[5, i].Value = int.Parse(tempObject["sale_price"].ToString()) / 100 + "元";
                    GetCollectionDetail(actId, lotteryId, i);
                    Thread.Sleep(i % 50 == 0 ? 2000 : 100);
                }
            }
        }

        private void GetCollectionDetail(string actId, string lotteryId, int rowIndex) {
            string biliUrl = "https://api.bilibili.com/x/vas/dlc_act/lottery/detail?act_id=" + actId + "&lottery_id=" + lotteryId;
            JObject jObject = GetJsonFromUrl(biliUrl);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                collectionDataGrid[4, rowIndex].Value = jObject["data"]?["name"]?.ToString();
                collectionDataGrid[6, rowIndex].Value = jObject["data"]?["total_sale_amount"]?.ToString();
                collectionDataGrid[7, rowIndex].Value = jObject["data"]?["lottery_desc"]?.ToString();
            }
        }

        private void DownloadCollectionById(string actId, string directory) {
            string biliUrl = "https://api.bilibili.com/x/vas/dlc_act/act/item/list?act_id=" + actId;
            JObject jObject = GetJsonFromUrl(biliUrl);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                directory += directory.EndsWith("\\") ? "" : "\\";
                JArray itemList = JArray.Parse(jObject["data"]["item_list"].ToString());
                WebClient webClient = new WebClient();
                if (!Directory.Exists(directory)) {
                    Directory.CreateDirectory(directory);
                }
                
                webClient.DownloadFile(jObject["data"]["act_y_img"].ToString(), directory + "act_cover.png");
                foreach (JToken token in itemList) {
                    JObject tempObject = JObject.Parse(token["card_item"].ToString());
                    string cardName = tempObject["card_name"]?.ToString();
                    string cardImg = tempObject["card_img"]?.ToString();
                    string filename = directory + cardName + ".png";
                    if (cardImg != null && !File.Exists(filename)) {
                        label5.Text = @"正在将：" + @"""" + cardImg + @"""" + @" 下载至：" + @"""" + filename + @"""";
                        Console.WriteLine(@"(" + label4.Text + @") " + label5.Text);
                        webClient.DownloadFile(cardImg, filename);
                    }
                    
                    if (tempObject["card_type"] != null && tempObject["card_type"].ToString().Equals("2")) {
                        JArray videoList = JArray.Parse(tempObject["video_list"].ToString());
                        string videoLink = videoList[0].ToString();
                        File.WriteAllText(directory + cardName + ".txt", videoLink);
                        // webClient.DownloadFile(videoLink, directory + cardName + ".mp4");
                    }
                }
            }
        }

        private static Hashtable GetGroupSubTabs() {
            Hashtable hashtable = new Hashtable();
            string biliUrl = "https://api.bilibili.com/x/garb/v2/mall/subtabs?part_id=6";
            JObject jObject = GetJsonFromUrl(biliUrl);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                JArray groupList = JArray.Parse(jObject["data"]["list"].ToString());
                foreach (JToken token in groupList) {
                    JObject tempObject = JObject.Parse(token.ToString());
                    string groupId = tempObject["group_id"]?.ToString();
                    string groupName = tempObject["group_name"]?.ToString();
                    if (groupId != null && groupName != null) {
                        hashtable.Add(int.Parse(groupId), groupName);
                    }
                }
            }
            
            return hashtable;
        }

        private static JObject GetJsonFromUrl(string url) {
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);
            req.Method = "GET"; req.ContentType = "application/json, charset=utf-8";
            // req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36 Edg/112.0.1722.48";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36";
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(stream, false);
            return JObject.Parse(reader.ReadToEnd());
        }
        
        private static string FormatTime(long sec) {
            long hour = sec / 3600;
            long minute = sec % 3600 / 60;
            long second = sec % 60;
            return hour + "小时" + minute + "分钟" + second + "秒";
        }

        private HashSet<string> GetAllCheckedBoxInCheckedListBox() {
            HashSet<string> hashSet = new HashSet<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                if (checkedListBox1.GetItemChecked(i)) {
                    string[] checkBoxName = checkedListBox1.Items[i].ToString().Split('_');
                    hashSet.Add(new List<string>(checkBoxName)[0]);
                }
            }
            
            return hashSet;
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

        private static void DisableOrEnableButton(Control ctrlTop, bool enabled) {
            foreach (Control control in (ArrangedElementCollection)ctrlTop.Controls) {
                if (control.GetType() == typeof(Button)) {
                    control.Enabled = enabled;
                } 
            }
        }
        
    }
}