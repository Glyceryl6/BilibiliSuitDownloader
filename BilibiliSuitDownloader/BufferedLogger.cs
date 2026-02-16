using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BilibiliSuitDownloader;

public class BufferedLogger {
    
    private readonly object _lock = new ();
    private readonly Timer _timer;
    private readonly Queue<string> _logQueue = new ();
    private readonly Action<List<string>> _batchHandler;

    public BufferedLogger(Action<List<string>> batchHandler, int flushInterval = 500) {
        _batchHandler = batchHandler;
        _timer = new Timer { Interval = flushInterval };
        _timer.Tick += FlushLogs;
        _timer.Start();
    }

    public void Log(string message) {
        lock (_lock) {
            _logQueue.Enqueue($"{DateTime.Now:HH:mm:ss} - {message}");
            if (_logQueue.Count > 100) {
                _timer.Stop();
                FlushLogs(null, EventArgs.Empty);
                _timer.Start();
            }
        }
    }

    private void FlushLogs(object sender, EventArgs e) {
        List<string> batch;
        lock (_lock) {
            if (_logQueue.Count == 0) {
                return;
            }
            
            batch = _logQueue.ToList();
            _logQueue.Clear();
        }
        _batchHandler?.Invoke(batch);
    }
    
}