using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BilibiliSuitDownloader;

partial class LogForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
    private RichTextBox richTextBox1;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilibiliSuitDownloader.LogForm));
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();
        this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.richTextBox1.BackColor = System.Drawing.Color.White;
        this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.richTextBox1.Font = new System.Drawing.Font("新宋体", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
        this.richTextBox1.Location = new System.Drawing.Point(12, 12);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.ReadOnly = true;
        this.richTextBox1.Size = new System.Drawing.Size(770, 541);
        this.richTextBox1.TabIndex = 31;
        this.richTextBox1.Text = "";
        this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 15f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(794, 565);
        this.Controls.Add(this.richTextBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        this.Name = "LogForm";
        this.Text = "日志输出";
        this.ResumeLayout(false);
    }

    #endregion

}