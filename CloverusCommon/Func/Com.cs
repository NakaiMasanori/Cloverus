﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CloverusCommon.Database.SqlServer;
using SprCommon.Controls;

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
        public static void DataRowToControl(DataRow row, Control.ControlCollection controls, SqlBase db)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case SprTextBox textBox:
                        if (textBox.Name == "TxtName")
                        {
                            var x = 0;
                        }
                        textBox.SetFromDb(row);
                        break;
                    case SprMultiTextBox textBox:
                        textBox.SetFromDb(row);
                        break;
                    case Controls.ClvsAddressBox addressBox:
                        addressBox.SetFromDb(row);
                        break;
                    case Controls.ClvsRouteSelect routeSelect:
                        routeSelect.SetFromDb(row, db);
                        break;
                    case SprDateText dateBox:
                        dateBox.SetFromDb(row);
                        break;
                    default:
                        break;
                }
                if (control.Controls != null)
                {
                    DataRowToControl(row, control.Controls, db);
                }
            }
        }
        #endregion
    }
}
