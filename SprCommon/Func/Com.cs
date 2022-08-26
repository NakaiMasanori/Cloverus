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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
#endregion

namespace SprCommon.Func
{
    public class Com
    {
        public static string HiraganaToKatakana(string hiragana)
        {
            return Strings.StrConv(hiragana, VbStrConv.Katakana);
        }

        public static string ZenkakuToHankaku(string zenkaku)
        {
            return Strings.StrConv(zenkaku, VbStrConv.Narrow);
        }

    }
}
