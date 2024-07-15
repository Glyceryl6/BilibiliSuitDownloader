using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BilibiliSuitDownloader {
    
    public partial class GroupBoxEx : GroupBox {
        
        private Color _borderColor = Color.Black;

        [Browsable(true),Description("边框颜色"),Category("自定义分组")]
        public Color BorderColor {
            get => _borderColor;
            set {
                _borderColor = value;
                Invalidate();
            }
        }

        public GroupBoxEx() {
            InitializeComponent();
        }

        public GroupBoxEx(IContainer container) {
            container.Add(this);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) {
            var vSize = e.Graphics.MeasureString(Text,Font);
            e.Graphics.Clear(BackColor);
            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), 10, 1);
            Pen vPen = new Pen(_borderColor);
            e.Graphics.DrawLine(vPen, 1, vSize.Height / 2, 8, vSize.Height / 2);
            e.Graphics.DrawLine(vPen, vSize.Width + 8, vSize.Height / 2, Width - 2, vSize.Height / 2);
            e.Graphics.DrawLine(vPen, 1, vSize.Height / 2, 1, Height - 2);
            e.Graphics.DrawLine(vPen, 1, Height - 2, Width - 2, Height - 2);
            e.Graphics.DrawLine(vPen, Width - 2, vSize.Height / 2, Width - 2, Height - 2);
        }
        
    }
    
}