//*****************************************************************************
//
//  システム名：汎用ライブラリ SprCommon
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
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SprCommon.Database.SqlServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
#endregion

namespace SprCommon.Func
{
    public class Com
    {
        #region 文字データ変換

        #region ひらがな から カタカナ
        /// <summary>
        /// ひらがな から カタカナ
        /// </summary>
        /// <param name="hiragana"></param>
        /// <returns></returns>
        public static string HiraganaToKatakana(string hiragana)
        {
            return Strings.StrConv(hiragana, VbStrConv.Katakana);
        }
        #endregion

        #region 全角 から 半角
        /// <summary>
        /// 全角 から 半角
        /// </summary>
        /// <param name="zenkaku"></param>
        /// <returns></returns>
        public static string ZenkakuToHankaku(string zenkaku)
        {
            return Strings.StrConv(zenkaku, VbStrConv.Narrow);
        }
        #endregion

        #endregion

        #region 画面制御

        //public static void InitializeControls(Control.ControlCollection controls)
        //{
        //    foreach (Control control in controls)
        //    {
        //        switch (control)
        //        {
        //            case TextBox textBox:
        //                textBox.GotFocus += TextBox_GotFocus;
        //                break;
        //            case Controls.SprDropdown dropDown:
        //                //dropDown.InitializeDropdown();
        //                break;
        //            default:
        //                break;
        //        }
        //        if (control.Controls != null)
        //        {
        //            InitializeControls(control.Controls);
        //        }
        //    }
        //}

        //private static void TextBox_GotFocus(object sender, EventArgs e)
        //{
        //    ((TextBox)sender).SelectAll();
        //}

        #endregion

    }
}
