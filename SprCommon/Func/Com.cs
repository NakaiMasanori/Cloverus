using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

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
