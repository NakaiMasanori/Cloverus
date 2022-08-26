//*****************************************************************************
//
//  システム名：宅食業販売管理システム CloverusSys
//
//  Copyright 株式会社スプレッド 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/12/31  A.Satou    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

#region using defines
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
#endregion

namespace CloverusSys.Controls
{
    public static class Func
    {

        #region コントロールの初期化
        /// <summary>
        /// コントロールの初期化
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="readOnly"></param>
        public static void InitControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case MenuPanel.ClvsMenuButton menuButton:
                        menuButton.Caption = MenuPanel.ClvsMenuButton.MenuText(menuButton.MenuItem);
                        break;
                    default:
                        break;
                }
                if (control.Controls != null)
                {
                    InitControls(control.Controls);
                }
            }
        }
        #endregion

    }
}
