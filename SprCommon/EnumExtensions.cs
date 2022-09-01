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
#endregion

namespace SprCommon
{
    public static class EnumExtensions
    {
        /// <summary>
        /// enumに適用されている属性を取得
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IEnumerable<TAttribute> GetApplied<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            return value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(false)
                .OfType<TAttribute>();
        }
    }
}
