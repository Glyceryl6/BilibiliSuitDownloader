using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BilibiliSuitDownloader.Properties;

namespace BilibiliSuitDownloader {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GetSuitDataButton = new System.Windows.Forms.Button();
            this.QuerySuitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExportSelectedSuitButton = new System.Windows.Forms.Button();
            this.DownloadAllSuitButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.suitDataGrid = new System.Windows.Forms.DataGridView();
            this.check_for_download = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_surplus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StopGetSuitButton = new System.Windows.Forms.Button();
            this.PauseGetSuitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GetCollectionDataButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.collectionDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lottery_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button18 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button17 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button16 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button15 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button14 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button13 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button12 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button11 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button10 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button9 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button8 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button7 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button4 = new BilibiliSuitDownloader.BiliRadioButton();
            this.button3 = new BilibiliSuitDownloader.BiliRadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suitDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(209, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(408, 29);
            this.textBox2.TabIndex = 15;
            // 
            // GetSuitDataButton
            // 
            this.GetSuitDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetSuitDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetSuitDataButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.GetSuitDataButton.Location = new System.Drawing.Point(773, 60);
            this.GetSuitDataButton.Name = "GetSuitDataButton";
            this.GetSuitDataButton.Size = new System.Drawing.Size(130, 32);
            this.GetSuitDataButton.TabIndex = 13;
            this.GetSuitDataButton.Text = "获取装扮数据";
            this.GetSuitDataButton.Click += new System.EventHandler(this.GetSuitDataButton_Click);
            // 
            // QuerySuitButton
            // 
            this.QuerySuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuerySuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuerySuitButton.Enabled = false;
            this.QuerySuitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.QuerySuitButton.Location = new System.Drawing.Point(773, 18);
            this.QuerySuitButton.Name = "QuerySuitButton";
            this.QuerySuitButton.Size = new System.Drawing.Size(130, 32);
            this.QuerySuitButton.TabIndex = 12;
            this.QuerySuitButton.Text = "点击查询";
            this.QuerySuitButton.Click += new System.EventHandler(this.QuerySuitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(209, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 29);
            this.textBox1.TabIndex = 11;
            // 
            // ExportSelectedSuitButton
            // 
            this.ExportSelectedSuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportSelectedSuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportSelectedSuitButton.Enabled = false;
            this.ExportSelectedSuitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.ExportSelectedSuitButton.Location = new System.Drawing.Point(909, 18);
            this.ExportSelectedSuitButton.Name = "ExportSelectedSuitButton";
            this.ExportSelectedSuitButton.Size = new System.Drawing.Size(130, 32);
            this.ExportSelectedSuitButton.TabIndex = 17;
            this.ExportSelectedSuitButton.Text = "下载所选装扮";
            this.ExportSelectedSuitButton.Click += new System.EventHandler(this.ExportSelectedSuitButton_Click);
            // 
            // DownloadAllSuitButton
            // 
            this.DownloadAllSuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadAllSuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadAllSuitButton.Enabled = false;
            this.DownloadAllSuitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.DownloadAllSuitButton.Location = new System.Drawing.Point(909, 60);
            this.DownloadAllSuitButton.Name = "DownloadAllSuitButton";
            this.DownloadAllSuitButton.Size = new System.Drawing.Size(130, 32);
            this.DownloadAllSuitButton.TabIndex = 16;
            this.DownloadAllSuitButton.Text = "下载所有装扮";
            this.DownloadAllSuitButton.Click += new System.EventHandler(this.DownloadAllSuitButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(593, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(485, 32);
            this.progressBar1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(593, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(485, 32);
            this.label4.TabIndex = 21;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(23, 194);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 559);
            this.tabControl1.TabIndex = 23;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.suitDataGrid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ExportSelectedSuitButton);
            this.tabPage1.Controls.Add(this.QuerySuitButton);
            this.tabPage1.Controls.Add(this.GetSuitDataButton);
            this.tabPage1.Controls.Add(this.DownloadAllSuitButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "普通装扮";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.Enabled = false;
            this.button21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button21.Location = new System.Drawing.Point(637, 60);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(130, 32);
            this.button21.TabIndex = 33;
            this.button21.Text = "终止获取";
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Enabled = false;
            this.button20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button20.Location = new System.Drawing.Point(637, 18);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(130, 32);
            this.button20.TabIndex = 32;
            this.button20.Text = "暂停获取";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "请输入需要导出的路径：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // suitDataGrid
            // 
            this.suitDataGrid.AllowUserToAddRows = false;
            this.suitDataGrid.AllowUserToDeleteRows = false;
            this.suitDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.suitDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.suitDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.suitDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suitDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.suitDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suitDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.check_for_download, this.item_id, this.name, this.group_name, this.owner, this.price, this.sale_surplus, this.desc });
            this.suitDataGrid.Location = new System.Drawing.Point(0, 109);
            this.suitDataGrid.Name = "suitDataGrid";
            this.suitDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.suitDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suitDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.suitDataGrid.RowTemplate.Height = 27;
            this.suitDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.suitDataGrid.ShowCellToolTips = false;
            this.suitDataGrid.ShowEditingIcon = false;
            this.suitDataGrid.Size = new System.Drawing.Size(1045, 415);
            this.suitDataGrid.TabIndex = 8;
            this.suitDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.suitDataGrid_CellFormatting);
            this.suitDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.suitDataGrid_DataError);
            // 
            // check_for_download
            // 
            this.check_for_download.HeaderText = "";
            this.check_for_download.Name = "check_for_download";
            this.check_for_download.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.check_for_download.Width = 25;
            // 
            // item_id
            // 
            this.item_id.HeaderText = "商品ID";
            this.item_id.Name = "item_id";
            this.item_id.ReadOnly = true;
            this.item_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.item_id.Width = 90;
            // 
            // name
            // 
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // group_name
            // 
            this.group_name.HeaderText = "分组";
            this.group_name.Name = "group_name";
            this.group_name.ReadOnly = true;
            this.group_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.group_name.Width = 80;
            // 
            // owner
            // 
            this.owner.HeaderText = "所有者";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            this.owner.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.owner.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "定价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.Width = 70;
            // 
            // sale_surplus
            // 
            this.sale_surplus.HeaderText = "库存";
            this.sale_surplus.Name = "sale_surplus";
            this.sale_surplus.ReadOnly = true;
            this.sale_surplus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sale_surplus.Width = 70;
            // 
            // desc
            // 
            this.desc.HeaderText = "描述";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 500;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "请输入需要查询的装扮：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StopGetSuitButton);
            this.tabPage2.Controls.Add(this.PauseGetSuitButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.GetCollectionDataButton);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button19);
            this.tabPage2.Controls.Add(this.collectionDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "收藏集";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StopGetSuitButton
            // 
            this.StopGetSuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopGetSuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopGetSuitButton.Enabled = false;
            this.StopGetSuitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.StopGetSuitButton.Location = new System.Drawing.Point(593, 60);
            this.StopGetSuitButton.Name = "StopGetSuitButton";
            this.StopGetSuitButton.Size = new System.Drawing.Size(130, 32);
            this.StopGetSuitButton.TabIndex = 41;
            this.StopGetSuitButton.Text = "终止获取";
            // 
            // PauseGetSuitButton
            // 
            this.PauseGetSuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseGetSuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseGetSuitButton.Enabled = false;
            this.PauseGetSuitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.PauseGetSuitButton.Location = new System.Drawing.Point(593, 18);
            this.PauseGetSuitButton.Name = "PauseGetSuitButton";
            this.PauseGetSuitButton.Size = new System.Drawing.Size(130, 32);
            this.PauseGetSuitButton.TabIndex = 40;
            this.PauseGetSuitButton.Text = "暂停获取";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "请输入需要导出的路径：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "请输入需要查询的收藏集：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GetCollectionDataButton
            // 
            this.GetCollectionDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetCollectionDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetCollectionDataButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.GetCollectionDataButton.Location = new System.Drawing.Point(729, 60);
            this.GetCollectionDataButton.Name = "GetCollectionDataButton";
            this.GetCollectionDataButton.Size = new System.Drawing.Size(130, 32);
            this.GetCollectionDataButton.TabIndex = 24;
            this.GetCollectionDataButton.Text = "获取收藏集数据";
            this.GetCollectionDataButton.Click += new System.EventHandler(this.GetCollectionDataButton_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(865, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 32);
            this.button5.TabIndex = 25;
            this.button5.Text = "下载所有收藏集";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(224, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(351, 29);
            this.textBox3.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(224, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(351, 29);
            this.textBox4.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(865, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "下载所选收藏集";
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.Enabled = false;
            this.button19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button19.Location = new System.Drawing.Point(729, 18);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(130, 32);
            this.button19.TabIndex = 33;
            this.button19.Text = "点击查询";
            // 
            // collectionDataGrid
            // 
            this.collectionDataGrid.AllowUserToAddRows = false;
            this.collectionDataGrid.AllowUserToDeleteRows = false;
            this.collectionDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.collectionDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.collectionDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.collectionDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.collectionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.collectionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collectionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewCheckBoxColumn1, this.dataGridViewTextBoxColumn1, this.lottery_id, this.dataGridViewTextBoxColumn2, this.Column1, this.dataGridViewTextBoxColumn5, this.dataGridViewTextBoxColumn6, this.dataGridViewTextBoxColumn7 });
            this.collectionDataGrid.Location = new System.Drawing.Point(0, 109);
            this.collectionDataGrid.Name = "collectionDataGrid";
            this.collectionDataGrid.ReadOnly = true;
            this.collectionDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.collectionDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.collectionDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.collectionDataGrid.RowTemplate.Height = 27;
            this.collectionDataGrid.ShowCellToolTips = false;
            this.collectionDataGrid.ShowEditingIcon = false;
            this.collectionDataGrid.Size = new System.Drawing.Size(1045, 415);
            this.collectionDataGrid.TabIndex = 9;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "活动ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // lottery_id
            // 
            this.lottery_id.HeaderText = "抽奖ID";
            this.lottery_id.Name = "lottery_id";
            this.lottery_id.ReadOnly = true;
            this.lottery_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lottery_id.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "活动名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "定价";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "销量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "描述";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 500;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 153);
            this.panel1.TabIndex = 28;
            this.panel1.Text = "panel1";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button18.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button18.GroupId = 39;
            this.button18.Location = new System.Drawing.Point(329, 99);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 40);
            this.button18.TabIndex = 13;
            this.button18.Text = "国创";
            this.button18.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button17.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button17.GroupId = 67;
            this.button17.Location = new System.Drawing.Point(223, 99);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 40);
            this.button17.TabIndex = 12;
            this.button17.Text = "影视综";
            this.button17.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button16.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button16.GroupId = 46;
            this.button16.Location = new System.Drawing.Point(117, 99);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 40);
            this.button16.TabIndex = 11;
            this.button16.Text = "原创";
            this.button16.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button15.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button15.GroupId = 57;
            this.button15.Location = new System.Drawing.Point(11, 99);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 40);
            this.button15.TabIndex = 10;
            this.button15.Text = "番剧";
            this.button15.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button14.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button14.GroupId = 65;
            this.button14.Location = new System.Drawing.Point(435, 53);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 40);
            this.button14.TabIndex = 9;
            this.button14.Text = "UP主";
            this.button14.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button13.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button13.GroupId = 49;
            this.button13.Location = new System.Drawing.Point(329, 53);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 40);
            this.button13.TabIndex = 8;
            this.button13.Text = "游戏";
            this.button13.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button12.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button12.GroupId = 47;
            this.button12.Location = new System.Drawing.Point(223, 53);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 40);
            this.button12.TabIndex = 7;
            this.button12.Text = "虚拟";
            this.button12.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button11.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button11.GroupId = 69;
            this.button11.Location = new System.Drawing.Point(117, 53);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 40);
            this.button11.TabIndex = 6;
            this.button11.Text = "装扮小姐姐";
            this.button11.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button10.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button10.GroupId = 70;
            this.button10.Location = new System.Drawing.Point(11, 53);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 40);
            this.button10.TabIndex = 5;
            this.button10.Text = "2233";
            this.button10.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button9.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button9.GroupId = 101;
            this.button9.Location = new System.Drawing.Point(435, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 40);
            this.button9.TabIndex = 4;
            this.button9.Text = "体育";
            this.button9.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button8.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button8.GroupId = 74;
            this.button8.Location = new System.Drawing.Point(329, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 40);
            this.button8.TabIndex = 3;
            this.button8.Text = "小电视";
            this.button8.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button7.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button7.GroupId = 76;
            this.button7.Location = new System.Drawing.Point(223, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "其它";
            this.button7.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button4.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button4.GroupId = 104;
            this.button4.Location = new System.Drawing.Point(117, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "娱乐";
            this.button4.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button3.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(11, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "全部分区";
            this.button3.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(593, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(485, 27);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1104, 765);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B站个性装扮数据查询工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.FixLastColumnWidth);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suitDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button StopGetSuitButton;
        private System.Windows.Forms.Button PauseGetSuitButton;

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button19;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        public System.Windows.Forms.DataGridView dataGridView1;

        private BilibiliSuitDownloader.BiliRadioButton button17;
        private BilibiliSuitDownloader.BiliRadioButton button18;
        private BilibiliSuitDownloader.BiliRadioButton button8;
        private BilibiliSuitDownloader.BiliRadioButton button9;
        private BilibiliSuitDownloader.BiliRadioButton button10;
        private BilibiliSuitDownloader.BiliRadioButton button11;
        private BilibiliSuitDownloader.BiliRadioButton button12;
        private BilibiliSuitDownloader.BiliRadioButton button13;
        private BilibiliSuitDownloader.BiliRadioButton button14;
        private BilibiliSuitDownloader.BiliRadioButton button15;
        private BilibiliSuitDownloader.BiliRadioButton button16;
        private BilibiliSuitDownloader.BiliRadioButton button4;
        private BilibiliSuitDownloader.BiliRadioButton button7;
        private BilibiliSuitDownloader.BiliRadioButton button3;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.DataGridViewTextBoxColumn lottery_id;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView collectionDataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button GetCollectionDataButton;

        private System.Windows.Forms.TabControl tabControl1;
        
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ProgressBar progressBar1;

        private System.Windows.Forms.DataGridViewCheckBoxColumn check_for_download;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_surplus;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;

        private System.Windows.Forms.Button ExportSelectedSuitButton;
        private System.Windows.Forms.Button DownloadAllSuitButton;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button GetSuitDataButton;
        private System.Windows.Forms.Button QuerySuitButton;
        private System.Windows.Forms.TextBox textBox1;

        public System.Windows.Forms.DataGridView suitDataGrid;

        #endregion

    }
}