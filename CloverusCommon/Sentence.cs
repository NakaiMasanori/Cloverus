﻿//*****************************************************************************
//
//  システム名：宅食業販売管理システム CloverusCommon
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace CloverusCommon
{
    public class Sentence
    {
        public enum Messages
        {
            /// <summary>
            /// 例外
            /// </summary>
            [Display(Order = (int)Log.LogType.Critical, Description = "例外が発生しました（内容：{0}）")]
            Exception,

            /// <summary>
            /// 例外
            /// </summary>
            [Display(Order = (int)Log.LogType.Critical, Description = "例外が発生しました。アプリケーションを強制終了します（内容：{0}）")]
            ExceptionExit,
        }
    }
}
