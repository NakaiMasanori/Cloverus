using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

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
