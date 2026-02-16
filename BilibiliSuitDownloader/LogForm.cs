using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Serilog;

namespace BilibiliSuitDownloader;

public partial class LogForm : Form {
    
    public readonly BufferedLogger BufferedLogger;
    
    public LogForm() {
        InitializeComponent();
        BufferedLogger = new BufferedLogger(BatchLogHandler, 300);
        Log.Logger = new LoggerConfiguration().WriteTo.RichTextBox(
            richTextBox1, null, autoScroll: true, 256, 
            "[{Timestamp:HH:mm:ss}] {Message}{NewLine}{Exception}").CreateLogger();
    }

    private void BatchLogHandler(List<string> messages) {
        richTextBox1.ScrollToCaret();
        if (richTextBox1.InvokeRequired) {
            richTextBox1.BeginInvoke(new Action<List<string>>(BatchLogHandler), messages);
            return;
        }
        
        StringBuilder builder = new StringBuilder();
        foreach (string msg in messages) {
            builder.AppendLine(msg);
        }
        
        if (richTextBox1.Lines.Length + messages.Count > 1000) {
            string[] currentLines = richTextBox1.Lines;
            string[] newLines = currentLines.Skip(currentLines.Length - 800 + messages.Count).Concat(messages).ToArray();
            richTextBox1.Lines = newLines;
        } else {
            richTextBox1.AppendText(builder.ToString());
        }
    }

    public void WriteLog(string message) {
        if (richTextBox1.InvokeRequired) {
            richTextBox1.Invoke(new Action<string>(WriteLog), message);
        } else {
            richTextBox1.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
            richTextBox1.ScrollToCaret();
        }
    }
    
}