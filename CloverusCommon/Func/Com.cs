using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CloverusCommon.Func
{
    public class Com
    {
        #region データベースから読み込んだ値を画面のコントロールへ反映する
        /// <summary>
        /// データベースから読み込んだ値を画面のコントロールへ反映する
        /// </summary>
        /// <param name="row"></param>
        /// <param name="controls"></param>
        public static void DataRowToControl(DataRow row, Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case SprCommon.Controls.SprTextBox textBox:
                        if (textBox.Name == "TxtName")
                        {
                            var x = 0;
                        }
                        if (!string.IsNullOrEmpty(textBox.TableColumn) && row.Table.Columns.Contains(textBox.TableColumn))
                        {
                            textBox.TextValue = row[textBox.TableColumn].ToString();
                        }
                        break;
                    case SprCommon.Controls.SprMultiTextBox textBox:
                        if (!string.IsNullOrEmpty(textBox.TableColumn) && row.Table.Columns.Contains(textBox.TableColumn))
                        {
                            textBox.TextValue = row[textBox.TableColumn].ToString();
                        }
                        break;
                    case Controls.SprAddressBox addressBox:
                        break;
                    default:
                        break;
                }
                if (control.Controls != null)
                {
                    DataRowToControl(row, control.Controls);
                }
            }
        }
        #endregion

    }
}
