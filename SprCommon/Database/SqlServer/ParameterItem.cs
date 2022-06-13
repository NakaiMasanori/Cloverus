//*****************************************************************************
//
//  システム名：共通クラス
//
//  Copyright 株式会社スプレッド 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/06/08  A.Satou    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprCommon.Database.SqlServer
{
    public class ParameterItem
    {
        /// <summary>
        /// キー
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 値
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public ParameterItem(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
