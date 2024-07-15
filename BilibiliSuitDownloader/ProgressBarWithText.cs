using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilibiliSuitDownloader {
    
    public enum ProgressBarDisplayText {
        Percentage,
        CustomText
    }

    public partial class ProgressBarWithText : ProgressBar {

        private ProgressBarDisplayText DisplayStyle { get; set; }

        private String CustomText { get; set; }

        public ProgressBarWithText() {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e) {
            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;
            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);
            if (Value > 0) {
                int width = (int)Math.Round((float)Value / Maximum * rect.Width);
                Rectangle clip = new Rectangle(rect.X, rect.Y, width, rect.Height);
                ProgressBarRenderer.DrawHorizontalChunks(g, clip);
            }

            string text = DisplayStyle == ProgressBarDisplayText.Percentage ? Value.ToString() + '%' : CustomText;
            using (Font f = new Font(FontFamily.GenericSerif, 10)) {
                SizeF len = g.MeasureString(text, f);
                Point location = new Point(Convert.ToInt32(Width / 2.0F - len.Width / 2.0F),
                    Convert.ToInt32(Height / 2.0F - len.Height / 2.0F));
                g.DrawString(text, f, Brushes.Red, location);
            }
        }

    }
    
}