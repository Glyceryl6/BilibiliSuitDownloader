using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BilibiliSuitDownloader {
    
    public static class MiscUtils {
        
        //用于将一个数据表的数据复制到另一个数据表中
        public static void CopyDataGridViewContent(DataGridView source, DataGridView target) {
            target.DataSource = null;
            target.Rows.Clear();
            if (target.Columns.Count < source.Columns.Count) {
                foreach (DataGridViewColumn column in source.Columns) {
                    if (column.Clone() is DataGridViewColumn cloneColumn) {
                        target.Columns.Add(cloneColumn);
                    }
                }
            }
 
            for (int i = 0; i < source.Rows.Count; i++) {
                IEnumerable<DataGridViewCell> cells = source.Rows[i].Cells.Cast<DataGridViewCell>();
                target.Rows.Add(cells.Select(cell => cell.Value).ToArray());
            }
        }
        
        //从数据表中查询数据，其中rowFilter参数可以按照SQL语句来写
        public static void QueryDataFromDataGridView(DataGridView bindingDataGrid, string rowFilter) {
            DataTable dt = new DataTable();
            DataGridViewColumnCollection columns = bindingDataGrid.Columns;
            DataGridViewRowCollection rows = bindingDataGrid.Rows;
            for (int count = 0; count < columns.Count; count++) {
                DataColumn dc = new DataColumn(columns[count].HeaderText);
                dt.Columns.Add(dc);
            }

            for (int count = 0; count < rows.Count; count++) {
                DataRow dr = dt.NewRow();
                for (int countSub = 0; countSub < columns.Count; countSub++) {
                    dr[countSub] = rows[count].Cells[countSub].Value;
                }
                
                dt.Rows.Add(dr);
            }

            bindingDataGrid.DataSource = dt.Select(rowFilter).CopyToDataTable();
            int validColCount = columns.Count / 2;
            for (int i = 1; i < validColCount; i++) {
                for (int j = 0; j < rows.Count; j++) {
                    bindingDataGrid[i, j].Value = bindingDataGrid[i + validColCount, j].Value;
                }
            }

            for (int i = 1; i <= validColCount; i++) {
                bindingDataGrid.Columns.RemoveAt(validColCount);
            }
        }
        
        //用于加深或者淡化颜色
        public static Color ChangeColor(Color color, float factor) {
            float red = color.R;
            float green = color.G;
            float blue = color.B;
            if (factor < 0) {
                factor = 1 + factor;
                red *= factor;
                green *= factor;
                blue *= factor;
            } else {
                red = (255 - red) * factor + red;
                green = (255 - green) * factor + green;
                blue = (255 - blue) * factor + blue;
            }

            red = Clamp((int) red, 0, 255);
            green = Clamp((int) green, 0, 255);
            blue = Clamp((int) blue, 0, 255);
            return Color.FromArgb((int) red, (int) green, (int) blue);
        }
        
        private static int Clamp(int value, int min, int max) {
            return value < min ? min : value > max ? max : value;
        }
        
    }
    
}