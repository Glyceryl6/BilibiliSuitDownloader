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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox2 = new AntdUI.Input();
            this.button2 = new AntdUI.Button();
            this.QueryButton = new AntdUI.Button();
            this.textBox1 = new AntdUI.Input();
            this.ExportSelectedSuitButton = new AntdUI.Button();
            this.ExportAllSuitButton = new AntdUI.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.suitDataGrid = new System.Windows.Forms.DataGridView();
            this.check_for_download = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_surplus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.collectionDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lottery_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new AntdUI.Button();
            this.button6 = new AntdUI.Button();
            this.windowBar1 = new AntdUI.WindowBar();
            this.panel1 = new AntdUI.Panel();
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
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(24, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "请输入需要导出的路径";
            this.textBox2.PrefixText = " 导出路径";
            this.textBox2.Radius = 10;
            this.textBox2.Round = true;
            this.textBox2.Size = new System.Drawing.Size(577, 48);
            this.textBox2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(761, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "获取装扮数据";
            this.button2.Type = AntdUI.TTypeMini.Primary;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QueryButton
            // 
            this.QueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QueryButton.Enabled = false;
            this.QueryButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.QueryButton.Location = new System.Drawing.Point(616, 69);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(130, 48);
            this.QueryButton.TabIndex = 12;
            this.QueryButton.Text = "点击查询";
            this.QueryButton.Type = AntdUI.TTypeMini.Primary;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.textBox1.IconRatio = 1F;
            this.textBox1.Location = new System.Drawing.Point(24, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "请输入需要查询的装扮";
            this.textBox1.PrefixText = " 搜索装扮";
            this.textBox1.Radius = 10;
            this.textBox1.Round = true;
            this.textBox1.Size = new System.Drawing.Size(577, 48);
            this.textBox1.TabIndex = 11;
            // 
            // ExportSelectedSuitButton
            // 
            this.ExportSelectedSuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportSelectedSuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportSelectedSuitButton.Enabled = false;
            this.ExportSelectedSuitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.ExportSelectedSuitButton.Location = new System.Drawing.Point(616, 123);
            this.ExportSelectedSuitButton.Name = "ExportSelectedSuitButton";
            this.ExportSelectedSuitButton.Size = new System.Drawing.Size(130, 48);
            this.ExportSelectedSuitButton.TabIndex = 17;
            this.ExportSelectedSuitButton.Text = "导出所选装扮";
            this.ExportSelectedSuitButton.Type = AntdUI.TTypeMini.Primary;
            this.ExportSelectedSuitButton.Click += new System.EventHandler(this.ExportSelectedSuitButton_Click);
            // 
            // ExportAllSuitButton
            // 
            this.ExportAllSuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportAllSuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportAllSuitButton.Enabled = false;
            this.ExportAllSuitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.ExportAllSuitButton.Location = new System.Drawing.Point(761, 123);
            this.ExportAllSuitButton.Name = "ExportAllSuitButton";
            this.ExportAllSuitButton.Size = new System.Drawing.Size(130, 48);
            this.ExportAllSuitButton.TabIndex = 16;
            this.ExportAllSuitButton.Text = "导出所有装扮";
            this.ExportAllSuitButton.Type = AntdUI.TTypeMini.Primary;
            this.ExportAllSuitButton.Click += new System.EventHandler(this.ExportAllSuitButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(616, 186);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 70);
            this.progressBar1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(616, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "装扮名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(616, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 32);
            this.label4.TabIndex = 21;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(616, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(459, 32);
            this.label5.TabIndex = 22;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 492);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 380);
            this.tabControl1.TabIndex = 23;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.suitDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "普通装扮";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suitDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.suitDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suitDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.check_for_download, this.item_id, this.name, this.group_name, this.owner, this.price, this.sale_surplus, this.desc });
            this.suitDataGrid.Location = new System.Drawing.Point(0, 0);
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
            this.suitDataGrid.Size = new System.Drawing.Size(1028, 353);
            this.suitDataGrid.TabIndex = 8;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.collectionDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "收藏集";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.collectionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.collectionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collectionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewCheckBoxColumn1, this.dataGridViewTextBoxColumn1, this.lottery_id, this.dataGridViewTextBoxColumn2, this.Column1, this.dataGridViewTextBoxColumn5, this.dataGridViewTextBoxColumn6, this.dataGridViewTextBoxColumn7 });
            this.collectionDataGrid.Location = new System.Drawing.Point(0, 0);
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
            this.collectionDataGrid.Size = new System.Drawing.Size(1028, 353);
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
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(906, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 48);
            this.button5.TabIndex = 25;
            this.button5.Text = "导出所有收藏集";
            this.button5.Type = AntdUI.TTypeMini.Primary;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(906, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 48);
            this.button6.TabIndex = 24;
            this.button6.Text = "获取收藏集数据";
            this.button6.Type = AntdUI.TTypeMini.Primary;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // windowBar1
            // 
            this.windowBar1.BackColor = System.Drawing.Color.Silver;
            this.windowBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowBar1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar1.ForeColor = System.Drawing.Color.Black;
            this.windowBar1.Location = new System.Drawing.Point(0, 0);
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Size = new System.Drawing.Size(1100, 50);
            this.windowBar1.TabIndex = 0;
            this.windowBar1.Text = "B站个性装扮数据查询工具";
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
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
            this.panel1.Location = new System.Drawing.Point(24, 177);
            this.panel1.Name = "panel1";
            this.panel1.Shadow = 5;
            this.panel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel1.ShadowOpacity = 0.5F;
            this.panel1.Size = new System.Drawing.Size(576, 300);
            this.panel1.TabIndex = 28;
            this.panel1.Text = "panel1";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button18.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button18.GroupId = 39;
            this.button18.Location = new System.Drawing.Point(424, 226);
            this.button18.Name = "button18";
            this.button18.Shape = AntdUI.TShape.Round;
            this.button18.Size = new System.Drawing.Size(100, 40);
            this.button18.TabIndex = 13;
            this.button18.Text = "国创";
            this.button18.Type = AntdUI.TTypeMini.Primary;
            this.button18.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button17.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button17.GroupId = 67;
            this.button17.Location = new System.Drawing.Point(293, 226);
            this.button17.Name = "button17";
            this.button17.Shape = AntdUI.TShape.Round;
            this.button17.Size = new System.Drawing.Size(100, 40);
            this.button17.TabIndex = 12;
            this.button17.Text = "影视综";
            this.button17.Type = AntdUI.TTypeMini.Primary;
            this.button17.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button16.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button16.GroupId = 46;
            this.button16.Location = new System.Drawing.Point(165, 226);
            this.button16.Name = "button16";
            this.button16.Shape = AntdUI.TShape.Round;
            this.button16.Size = new System.Drawing.Size(100, 40);
            this.button16.TabIndex = 11;
            this.button16.Text = "原创";
            this.button16.Type = AntdUI.TTypeMini.Primary;
            this.button16.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button15.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button15.GroupId = 57;
            this.button15.Location = new System.Drawing.Point(34, 226);
            this.button15.Name = "button15";
            this.button15.Shape = AntdUI.TShape.Round;
            this.button15.Size = new System.Drawing.Size(100, 40);
            this.button15.TabIndex = 10;
            this.button15.Text = "番剧";
            this.button15.Type = AntdUI.TTypeMini.Primary;
            this.button15.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button14.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button14.GroupId = 65;
            this.button14.Location = new System.Drawing.Point(424, 156);
            this.button14.Name = "button14";
            this.button14.Shape = AntdUI.TShape.Round;
            this.button14.Size = new System.Drawing.Size(100, 40);
            this.button14.TabIndex = 9;
            this.button14.Text = "UP主";
            this.button14.Type = AntdUI.TTypeMini.Primary;
            this.button14.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button13.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button13.GroupId = 49;
            this.button13.Location = new System.Drawing.Point(293, 156);
            this.button13.Name = "button13";
            this.button13.Shape = AntdUI.TShape.Round;
            this.button13.Size = new System.Drawing.Size(100, 40);
            this.button13.TabIndex = 8;
            this.button13.Text = "游戏";
            this.button13.Type = AntdUI.TTypeMini.Primary;
            this.button13.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button12.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button12.GroupId = 47;
            this.button12.Location = new System.Drawing.Point(165, 156);
            this.button12.Name = "button12";
            this.button12.Shape = AntdUI.TShape.Round;
            this.button12.Size = new System.Drawing.Size(100, 40);
            this.button12.TabIndex = 7;
            this.button12.Text = "虚拟";
            this.button12.Type = AntdUI.TTypeMini.Primary;
            this.button12.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button11.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button11.GroupId = 69;
            this.button11.Location = new System.Drawing.Point(34, 156);
            this.button11.Name = "button11";
            this.button11.Shape = AntdUI.TShape.Round;
            this.button11.Size = new System.Drawing.Size(100, 40);
            this.button11.TabIndex = 6;
            this.button11.Text = "装扮小姐姐";
            this.button11.Type = AntdUI.TTypeMini.Primary;
            this.button11.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button10.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button10.GroupId = 70;
            this.button10.Location = new System.Drawing.Point(424, 89);
            this.button10.Name = "button10";
            this.button10.Shape = AntdUI.TShape.Round;
            this.button10.Size = new System.Drawing.Size(100, 40);
            this.button10.TabIndex = 5;
            this.button10.Text = "2233";
            this.button10.Type = AntdUI.TTypeMini.Primary;
            this.button10.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button9.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button9.GroupId = 101;
            this.button9.Location = new System.Drawing.Point(293, 89);
            this.button9.Name = "button9";
            this.button9.Shape = AntdUI.TShape.Round;
            this.button9.Size = new System.Drawing.Size(100, 40);
            this.button9.TabIndex = 4;
            this.button9.Text = "体育";
            this.button9.Type = AntdUI.TTypeMini.Primary;
            this.button9.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button8.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button8.GroupId = 74;
            this.button8.Location = new System.Drawing.Point(165, 89);
            this.button8.Name = "button8";
            this.button8.Shape = AntdUI.TShape.Round;
            this.button8.Size = new System.Drawing.Size(100, 40);
            this.button8.TabIndex = 3;
            this.button8.Text = "小电视";
            this.button8.Type = AntdUI.TTypeMini.Primary;
            this.button8.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button7.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button7.GroupId = 76;
            this.button7.Location = new System.Drawing.Point(34, 89);
            this.button7.Name = "button7";
            this.button7.Shape = AntdUI.TShape.Round;
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "其它";
            this.button7.Type = AntdUI.TTypeMini.Primary;
            this.button7.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.button4.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.button4.GroupId = 104;
            this.button4.Location = new System.Drawing.Point(424, 23);
            this.button4.Name = "button4";
            this.button4.Shape = AntdUI.TShape.Round;
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "娱乐";
            this.button4.Type = AntdUI.TTypeMini.Primary;
            this.button4.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button3.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(293, 23);
            this.button3.Name = "button3";
            this.button3.Shape = AntdUI.TShape.Round;
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "全部分区";
            this.button3.Type = AntdUI.TTypeMini.Primary;
            this.button3.UncheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(616, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(459, 74);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 900);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ExportSelectedSuitButton);
            this.Controls.Add(this.ExportAllSuitButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.BindingDataGridViewToButton);
            this.SizeChanged += new System.EventHandler(this.FixLastColumnWidth);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suitDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

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

        private AntdUI.Panel panel1;

        private AntdUI.WindowBar windowBar1;

        private System.Windows.Forms.DataGridViewTextBoxColumn lottery_id;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView collectionDataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private AntdUI.Button button5;
        private AntdUI.Button button6;

        private System.Windows.Forms.TabControl tabControl1;
        
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DataGridViewCheckBoxColumn check_for_download;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_surplus;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;

        private AntdUI.Button ExportSelectedSuitButton;
        private AntdUI.Button ExportAllSuitButton;

        private AntdUI.Input textBox2;
        private AntdUI.Button button2;
        private AntdUI.Button QueryButton;
        private AntdUI.Input textBox1;

        public System.Windows.Forms.DataGridView suitDataGrid;

        #endregion

    }
}