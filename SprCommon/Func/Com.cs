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
                    case Controls.SprTextBox textBox:
                        if (textBox.Name == "TxtName")
                        {
                            var x = 0;
                        }
                        if (!string.IsNullOrEmpty(textBox.TableColumn) && row.Table.Columns.Contains(textBox.TableColumn))
                        {
                            textBox.TextValue = row[textBox.TableColumn].ToString();
                        }
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

        #endregion

    }
}
