using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Newtonsoft.Json.Linq;

namespace BilibiliSuitDownloader;

public partial class MainForm : Form {

    private readonly LogForm _logForm;
    private readonly WebClient _client;
    
    public MainForm() {
        InitializeComponent();
        _logForm = new LogForm();
        _client = new WebClient {
            Proxy = null,
            Encoding = Encoding.UTF8
        };
    }

    private void MainForm_Load(object sender, EventArgs e) {
        _logForm.Show();
        foreach (Control control in panel1.Controls) {
            if (control is BiliRadioButton button && control.Parent is Panel) {
                button.BindingForm = this;
            }
        }
    }

    private void suitDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
        if (suitDataGrid.Columns[e.ColumnIndex].Name == "check_for_download") e.Value ??= false;
    }

    private void suitDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e) {
        e.ThrowException = false;
        _logForm.BufferedLogger.Log(e.ToString());
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
    
    private void QuerySuitButton_Click(object sender, EventArgs e) {
        MiscUtils.CopyDataGridViewContent(dataGridView1, suitDataGrid);
        string text = textBox1.Text;
        if (string.IsNullOrEmpty(text)) return;
        string rowFilter = $"名称 like '%{text}%' or 分组 like '%{text}%' or 描述 like '%{text}%'";
        MiscUtils.QueryDataFromDataGridView(suitDataGrid, rowFilter);
    }

    private void GetSuitDataButton_Click(object sender, EventArgs e) {
        DisableOrEnableButton(tabPage1, false);
        suitDataGrid.DataSource = null;
        suitDataGrid.Rows.Clear();
        GetSuitDataByGroupId();
        panel1.Enabled = true;
        MiscUtils.CopyDataGridViewContent(suitDataGrid, dataGridView1);
        DisableOrEnableButton(tabPage1, true);
    }
    
    private void GetCollectionDataButton_Click(object sender, EventArgs e) {
        int i = collectionDataGrid.ColumnCount - 1;
        DisableOrEnableButton(tabPage2, false);
        int width = collectionDataGrid.Columns[i].Width;
        collectionDataGrid.Rows.Clear();
        GetCollectionData();
        collectionDataGrid.Columns[i].Width = width;
        tabControl1.SelectedIndex = 1;
        DisableOrEnableButton(tabPage2, true);
    }

    //下载所有的装扮并在进度条上同步
    private async void DownloadAllSuitButton_Click(object sender, EventArgs e) {
        int rowCount = suitDataGrid.RowCount;
        if (rowCount <= 0) return;
        long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        progressBar1.Maximum = rowCount;
        label4.Text = progressBar1.Value + 1 + @"/" + rowCount;
        await Task.Run(() => {
            for (int i = 0; i < rowCount; i++) {
                DownloadSuitById(suitDataGrid[1, i].Value.ToString());
                label4.Text = progressBar1.Value + 1 + @"/" + rowCount;
                if (progressBar1.Value % 100 == 0) Task.Delay(2000);
                progressBar1.Invoke(new Action(() => progressBar1.Value++));
            }
        });
        
        DownloadDone(startTime);
    }
    
    //下载所有的收藏集并在进度条上同步
    private void button5_Click(object sender, EventArgs e) {
        int rowCount = collectionDataGrid.RowCount;
        if (rowCount <= 0) return;
        long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        progressBar1.Maximum = rowCount;
        label4.Text = progressBar1.Value + 1 + @"/" + rowCount;
        for (int i = 0; i < rowCount; i++) {
            string filename = collectionDataGrid[3, i].Value.ToString();
            filename = FilenameThatRemoveAllInvalidChars(filename);
            string directory = textBox2.Text + "\\" + filename;
            string actId = collectionDataGrid[1, i].Value.ToString();
            string lotteryId = collectionDataGrid[2, i].Value.ToString();
            DownloadCollectionById(actId, lotteryId, directory);
            label4.Text = progressBar1.Value + 1 + @"/" + progressBar1.Maximum;
            //短时间内频繁访问同一个API链接会导致IP被短暂封禁，这里通过设置延迟以绕过风控
            //除了这个地方之外，程序的其它地方也用了这段代码，作用相同
            Thread.Sleep(i % 50 == 0 ? 2000 : 10);
            progressBar1.Value++;
        }
        
        DownloadDone(startTime);
    }

    //下载勾选的装扮
    private async void ExportSelectedSuitButton_Click(object sender, EventArgs e) {
        long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        HashSet<string> hashSet = GetAllCheckedBoxInDataGridView();
        if (hashSet.Count > 0) {
            progressBar1.Maximum = hashSet.Count;
            await Task.Run(() => {
                foreach (string id in hashSet) {
                    DownloadSuitById(id);
                    label4.Text = progressBar1.Value + 1 + @"/" + hashSet.Count;
                    if (progressBar1.Value % 100 == 0) Task.Delay(2000);
                    progressBar1.Invoke(new Action(() => progressBar1.Value++));
                }
            });
        }
        
        DownloadDone(startTime);
    }

    private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e) {
        panel1.Enabled = e.TabPageIndex == 0 && QuerySuitButton.Enabled;
    }

    //所有装扮下载完成时的提示
    private void DownloadDone(long startTime) {
        long endTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        progressBar1.Value = 0;
        string time = FormatTime(endTime - startTime);
        _logForm.BufferedLogger.Log("下载完成，总共耗时：" + time);
    }

    //获取所有装扮的信息
    private async void GetSuitDataByGroupId() {
        int totalPage = GetSuitTotalPage(); 
        int totalCount = 0;
        await Task.Run(() => {
            for (var i = 1; i <= totalPage; i++) {
                JArray array = GetSuitArrayByPage(i);
                for (var j = 0; j < array.Count; j++) {
                    int k = totalCount + j;
                    JObject tempObject = JObject.Parse(array[j].ToString());
                    JObject properties = JObject.Parse(tempObject["properties"].ToString());
                    suitDataGrid.Invoke(new Action(() => {
                        suitDataGrid.Rows.Add(1);
                        suitDataGrid.FirstDisplayedScrollingRowIndex = suitDataGrid.RowCount - 1;
                        suitDataGrid[1, k].Value = tempObject["item_id"]?.ToString();
                        suitDataGrid[2, k].Value = tempObject["name"]?.ToString();
                        suitDataGrid[4, k].Value = properties["owner_uid"]?.ToString();
                        suitDataGrid[3, k].Value = GetGroupSubTabs()[int.Parse(tempObject["group_id"]?.ToString() ?? "0")];
                        suitDataGrid[5, k].Value = int.Parse(properties["sale_bp_forever_raw"]?.ToString() ?? "0") / 100 + "元";
                        suitDataGrid[6, k].Value = tempObject["sale_surplus"]?.ToString();
                        suitDataGrid[7, k].Value = properties["desc"]?.ToString();
                    }));
                }
                
                totalCount += array.Count;
                _logForm.BufferedLogger.Log($"正在获取第 {i}/{totalPage} 页装扮");
                if (i % 100 == 0) Task.Delay(2000);
            }
        });
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
        string biliUrl = "https://api.bilibili.com/x/garb/v2/mall/suit/detail?item_id=" + id + "&part=suit";
        JObject jObject = GetJsonFromUrl(biliUrl);
        if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0 && jObject["data"] != null) {
            JToken suitItemsToken = jObject["data"]["suit_items"];
            string itemName = jObject["data"]["name"]?.ToString();
            itemName = itemName != null && itemName.EndsWith("...") ? itemName.Replace("...", "…") : itemName;
            string group = GetGroupSubTabs()[int.Parse(jObject["data"]["group_id"]?.ToString() ?? "0")].ToString();
            directory += (directory.EndsWith("\\") ? "" : "\\") + group + "\\" + itemName + "\\";
            _logForm.BufferedLogger.Log("开始下载装扮：" + itemName);
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
                    DownloadNonEmojiPackageFromSuit(suitItemsToken, paths, path);
                } else {
                    DownloadEmojiPackageFromSuit(suitItemsToken, directory);
                }
            }
        }
    }

    //下载装扮中除了表情包之外的其它部分，并根据json的对象名创建并下载至相应的文件夹
    private void DownloadNonEmojiPackageFromSuit(JToken suitItemsToken, string[] paths, string path) {
        JToken tempToken = suitItemsToken[paths.Last()];
        JArray suitArray = JArray.Parse(tempToken.ToString());
        foreach (JToken token1 in suitArray) {
            JToken properties = token1["properties"];
            if (properties == null) continue;
            foreach (JToken token2 in properties) {
                string objects = token2.Path.Split('.').Last();
                string link = properties[objects]?.ToString();
                Regex regex = new Regex("((http|https)://)");
                if (link?.Length > 0 && regex.Match(link).Success) {
                    int lastIndex = link.LastIndexOf("/", StringComparison.Ordinal);
                    string filename = path + link.Substring(lastIndex).Trim('/');
                    if (!File.Exists(filename)) {
                        if (link.Contains("hdslb.com")) {
                            _client.DownloadFile(link, filename);
                            OutPutInfoToLogWindow(link, filename);
                        } else {
                            DownloadStreaming(JArray.Parse(link)[0].ToString(), filename);
                        }
                    } else {
                        _logForm.BufferedLogger.Log(string.Concat("文件：“", filename, "”已存在，跳过下载。"));
                    }
                }
            }
        }
    }

    //下载装扮中的表情包部分
    private void DownloadEmojiPackageFromSuit(JToken suitItemsToken, string directory) {
        JArray emojiArray = JArray.Parse(suitItemsToken["emoji_package"].ToString());
        foreach (JToken token1 in emojiArray) {
            JArray itemArray = JArray.Parse(token1["items"].ToString());
            foreach (JToken itemToken in itemArray) {
                //移除获取到的表情包的名称中的方括号（[]）
                string emojiName = itemToken["name"]?.ToString().Trim('[', ']');
                string link = itemToken["properties"]?["image"]?.ToString();
                if (emojiName != null && emojiName.Contains("?")) {
                    emojiName = emojiName.Replace("?", "？");
                }
                
                string filename = directory + emojiName + ".png";
                if (link == null) continue;
                if (!File.Exists(filename)) {
                    _client.DownloadFile(link, filename);
                    OutPutInfoToLogWindow(link, filename);
                } else {
                    _logForm.BufferedLogger.Log(string.Concat("文件：“", filename, "”已存在，跳过下载。"));
                }
            }
        }
    }

    //获取所有收藏集的信息（ID、抽奖ID、活动名和售价）
    private void GetCollectionData() {
        var collectionArray = new JArray();
        var site = 0;
        while (true) {
            var jObject = GetJsonFromUrl("https://api.bilibili.com/x/vas/dlc_act/act/list?scene=1&site=" + site);
            if (jObject["code"] == null || int.Parse(jObject["code"].ToString()) != 0) continue;
            var listToken = jObject["data"]?["list"];
            var isMoreToken = jObject["data"]?["is_more"];
            if (listToken != null && isMoreToken != null && bool.Parse(isMoreToken.ToString())) {
                collectionArray.Merge(JArray.Parse(listToken.ToString()));
                site += 20;
            } else {
                break;
            }
        }

        collectionDataGrid.Rows.Add(collectionArray.Count);
        for (var i = 0; i < collectionArray.Count; i++) {
            var tempObject = JObject.Parse(collectionArray[i].ToString());
            var actId = tempObject["act_id"]?.ToString();
            var lotteryId = tempObject["lottery_id"]?.ToString();
            var salePrice = tempObject["sale_price"]?.ToString();
            collectionDataGrid[1, i].Value = actId;
            collectionDataGrid[2, i].Value = lotteryId;
            collectionDataGrid[3, i].Value = tempObject["act_name"]?.ToString().Trim();
            collectionDataGrid[5, i].Value = (salePrice != null ? int.Parse(salePrice) : 0) / 100 + "元";
            GetCollectionDetail(actId, lotteryId, i);
        }
    }

    //获取收藏集的活动名字、总销量和抽奖信息
    private void GetCollectionDetail(string actId, string lotteryId, int rowIndex) {
        var jObject = GetJsonFromUrl("https://api.bilibili.com/x/vas/dlc_act/lottery/detail?act_id=" + actId + "&lottery_id=" + lotteryId);
        if (jObject["code"] == null || int.Parse(jObject["code"].ToString()) != 0) return;
        collectionDataGrid[4, rowIndex].Value = jObject["data"]?["name"]?.ToString();
        collectionDataGrid[6, rowIndex].Value = jObject["data"]?["total_sale_amount"]?.ToString();
        collectionDataGrid[7, rowIndex].Value = jObject["data"]?["lottery_desc"]?.ToString();
    }

    //根据ID来下载收藏集内容
    private void DownloadCollectionById(string actId, string lotteryId, string directory) {
        JObject jObject = GetJsonFromUrl("https://api.bilibili.com/x/vas/dlc_act/lottery_home_detail?act_id=" + actId + "&lottery_id=" + lotteryId);
        if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0 && jObject["data"] != null) {
            JArray itemList = JArray.Parse(jObject["data"]["item_list"].ToString());
            directory += directory.EndsWith("\\") ? "" : "\\";
            if (!Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
            }
            
            DownloadCollectionCover(actId, directory);
            foreach (JToken token in itemList) {
                if (token["card_info"] != null) {
                    JObject tempObject = JObject.Parse(token["card_info"].ToString());
                    var cardName = tempObject["card_name"]?.ToString();
                    var cardImg = tempObject["card_img"]?.ToString();
                    cardName = FilenameThatRemoveAllInvalidChars(cardName);
                    if (!string.IsNullOrEmpty(cardImg)) {
                        string[] segments = cardImg.Split('/');
                        string filename = directory + cardName + Path.GetExtension(segments.Last());
                        if (!File.Exists(filename)) {
                            _client.DownloadFile(cardImg, filename);
                            OutPutInfoToLogWindow(cardImg, filename);
                        } else {
                            _logForm.BufferedLogger.Log(string.Concat("文件：“", filename, "”已存在，跳过下载。"));
                        }
                    }

                    JToken cardTypeToken = tempObject["card_type"];
                    if (cardTypeToken != null && cardTypeToken.ToString().Equals("2") && tempObject["video_list"] != null) {
                        JArray videoList = JArray.Parse(tempObject["video_list"].ToString());
                        DownloadStreaming(videoList[0].ToString(), directory + cardName);
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
                            var animationToken = cardTypeInfo["content"]?["animation"];
                            string list = animationToken is { HasValues: true } ? 
                                animationToken["animation_video_urls"]?.ToString() : string.Empty;
                            var cardName = cardTypeInfo["name"]?.ToString();
                            redeemItemName = cardName;
                            if (!string.IsNullOrEmpty(list)) {
                                string animationVideoUrl = JArray.Parse(list)[0].ToString();
                                string filename = directory + "collect_infos\\" + FilenameThatRemoveAllInvalidChars(cardName);
                                DownloadStreaming(animationVideoUrl, filename);
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(redeemItemName) && !string.IsNullOrEmpty(redeemItemImage)) {
                        string[] segments = redeemItemImage.Split('/');
                        redeemItemName += Path.GetExtension(segments.Last());
                        string newDir = directory + "collect_infos\\";
                        string filename = newDir + FilenameThatRemoveAllInvalidChars(redeemItemName);
                        if (!Directory.Exists(newDir)) {
                            Directory.CreateDirectory(newDir);
                        }

                        if (!File.Exists(filename)) {
                            _client.DownloadFile(redeemItemImage, filename);
                            OutPutInfoToLogWindow(redeemItemImage, filename);
                        } else {
                            _logForm.BufferedLogger.Log(string.Concat("文件：“", filename, "”已存在，跳过下载。"));
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
                    if (!string.IsNullOrEmpty(redeemItemName) && !string.IsNullOrEmpty(redeemItemImage)) {
                        string[] segments = redeemItemImage.Split('/');
                        redeemItemName += Path.GetExtension(segments.Last());
                        string newDir = directory + "collect_chain\\";
                        string filename = newDir + FilenameThatRemoveAllInvalidChars(redeemItemName);
                        if (!Directory.Exists(newDir)) Directory.CreateDirectory(newDir);
                        if (!File.Exists(filename)) {
                            _client.DownloadFile(redeemItemImage, filename);
                            OutPutInfoToLogWindow(redeemItemImage, filename);
                        } else {
                            _logForm.BufferedLogger.Log(string.Concat("文件：“", filename, "”已存在，跳过下载。"));
                        }
                    }
                }
            }
        }
    }

    //下载收藏集的封面图
    private void DownloadCollectionCover(string actId, string directory) {
        var jObject = GetJsonFromUrl("https://api.bilibili.com/x/vas/dlc_act/act/basic?act_id=" + actId);
        if (jObject["code"] == null || int.Parse(jObject["code"].ToString()) != 0) return;
        JArray lotteryList = JArray.Parse(jObject["data"]["lottery_list"].ToString());
        string lotteryImage = lotteryList[0]["lottery_image"]?.ToString();
        string coverFile = directory + "封面.png";
        if (lotteryImage != null && !File.Exists(coverFile)) {
            _client.DownloadFile(lotteryImage, coverFile);
            OutPutInfoToLogWindow(lotteryImage, coverFile);
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
        req.Method = "GET"; 
        req.ContentType = "application/json, charset=utf-8";
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

    //移除文件名中的所有非法字符
    private static string FilenameThatRemoveAllInvalidChars(string filename) {
        return Path.GetInvalidFileNameChars().Aggregate(filename, (current, invalidChar) => 
            current.Replace(invalidChar.ToString(), string.Empty));
    }

    //禁用或启用所有的按钮
    private static void DisableOrEnableButton(Control ctrlTop, bool enabled) {
        foreach (Control control in (ArrangedElementCollection) ctrlTop.Controls) {
            if (control.GetType() == typeof(Button)) {
                control.Enabled = enabled;
            } 
        }
    }

    //下载流媒体文件
    private void DownloadStreaming(string link, string filename) {
        try {
            if (File.Exists(filename + ".mp4")) {
                _logForm.BufferedLogger.Log($"文件：“{filename}.mp4”已存在，跳过下载。");
                return;
            }
            
            string fullPath = Path.Combine(Application.StartupPath, @"wget.exe");
            string arguments = @"-O " + @"""" + filename + ".mp4" + @"""" + " " + link;
            ProcessStartInfo startInfo = new ProcessStartInfo {
                FileName = fullPath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            OutPutInfoToLogWindow(link, filename + ".mp4");
        } catch (Exception e) {
            _logForm.BufferedLogger.Log(e.Message);
        }
    }

    //将下载进度输出至日志窗口，并显示所下载文件的大小
    private void OutPutInfoToLogWindow(string link, string filename) {
        FileInfo fileInfo = new FileInfo(filename);
        double fileSize = fileInfo.Length;
        string[] sizes = { "B", "KB", "MB" };
        int order = 0;
        while (fileSize >= 1024 && order < sizes.Length - 1) {
            fileSize /= 1024;
            order++;
        }
        
        string sizeString = $"{fileSize:0.0} {sizes[order]}";
        string info = @"正在将：" + @"""" + link + @"""" + @" 下载至：" + @"""" + filename + @"""";
        _logForm.BufferedLogger.Log(string.Concat("(", label4.Text, ") ", info, " [", sizeString, "]"));
    }
    
}