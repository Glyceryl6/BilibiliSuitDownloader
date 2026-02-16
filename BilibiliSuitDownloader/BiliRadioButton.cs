#nullable enable
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BilibiliSuitDownloader {
    
    public class BiliRadioButton : Button {
        
        private Form? _bindingForm;
        private Color _checkColor;
        private Color _uncheckColor;
        private bool _checked;

        [Description("绑定的窗口")]
        [Category("数据")]
        [DefaultValue(null)]
        [Browsable(true)]
        public Form? BindingForm {
            set {
                _bindingForm = value;
                Invalidate();
            }
        }

        [Description("选中时的颜色")]
        [Category("外观")]
        [DefaultValue(null)]
        [Browsable(true)]
        public Color CheckColor {
            get => _checkColor;
            set {
                _checkColor = value;
                Invalidate();
            }
        }

        [Description("未选中时的颜色")]
        [Category("外观")]
        [DefaultValue(null)]
        [Browsable(true)] 
        public Color UncheckColor {
            get => _uncheckColor;
            set {
                _uncheckColor = value;
                Invalidate();
            }
        }

        [Description("分组编号")]
        [Category("数据")]
        [DefaultValue(0)]
        public int GroupId { get; set; }

        [Description("选中状态")]
        [Category("数据")]
        [DefaultValue(false)]
        private bool Checked {
            set {
                if (_checked == value) {
                    return;
                }
                
                _checked = value;
                if (_bindingForm is MainForm mainForm) {
                    DataGridView suitDataGrid = mainForm.suitDataGrid;
                    MiscUtils.CopyDataGridViewContent(mainForm.dataGridView1, suitDataGrid);
                    if (GroupId != 0 && !string.IsNullOrEmpty(Text)) {
                        MiscUtils.QueryDataFromDataGridView(suitDataGrid, "分组 like '%" + Text + "%'");
                    }
                }
                
                if (value && Parent != null) {
                    foreach (Control control in Parent.Controls) {
                        if (control != this && control is BiliRadioButton button) {
                            button.BackColor = UncheckColor;
                            button.Checked = false;
                        }
                    }
                }
                
                Invalidate();
            }
        }

        protected override void OnClick(EventArgs e) {
            BackColor = CheckColor;
            Checked = true;
            base.OnClick(e);
        }
        
    }
    
}