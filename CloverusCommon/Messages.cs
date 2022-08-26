//*****************************************************************************
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
using SprCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace CloverusCommon
{
    public class Messages
    {
        #region メッセージダイアログ表示
        /// <summary>
        /// メッセージダイアログ表示
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="addtionalInfo"></param>
        /// <returns></returns>
        public static DialogResult ShowDialog(Sentence.Messages messageId, object[] addtionalInfo = null)
        {
            var text = GetText(messageId, addtionalInfo);
            var info = GetInfo(messageId);
            var caption = "メッセージ";
            var buttons = MessageBoxButtons.OK;
            switch ((Log.LogType)info.Order)
            {
                case Log.LogType.Info:
                    caption = "情報";
                    break;
                case Log.LogType.Warn:
                    caption = "警告";
                    break;
                case Log.LogType.Error:
                    caption = "エラー";
                    break;
                case Log.LogType.Critical:
                    caption = "緊急";
                    break;
                case Log.LogType.Question:
                    caption = "質問";
                    buttons = MessageBoxButtons.YesNo;
                    break;
                case Log.LogType.Debug:
                    break;
            }
            return MessageBox.Show(text, caption, buttons);
        }
        /// <summary>
        /// メッセージダイアログ表示
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="addtionalInfo"></param>
        /// <returns></returns>
        public static DialogResult ShowDialog(Sentence.Messages messageId, string addtionalInfo)
        {
            if (string.IsNullOrEmpty(addtionalInfo))
            {
                return ShowDialog(messageId);
            }
            else
            {
                return ShowDialog(messageId, new string[] { addtionalInfo });
            }
        }
        #endregion

        #region メッセージ情報取得
        /// <summary>
        /// メッセージ情報取得
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns></returns>
        public static DisplayAttribute GetInfo(Sentence.Messages messageId)
        {
            return messageId.GetApplied<DisplayAttribute>().First();
        }
        #endregion

        #region メッセージ文言取得
        /// <summary>
        /// メッセージ文言取得
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="addtionalInfo"></param>
        /// <returns></returns>
        public static string GetText(Sentence.Messages messageId, object[] addtionalInfo = null)
        {
            if (addtionalInfo == null || !addtionalInfo.Any())
            {
                return GetInfo(messageId).Description;
            }
            else
            {
                return string.Format(GetInfo(messageId).Description, addtionalInfo);
            }
        }
        #endregion

        #region ログ種別文言の取得
        /// <summary>
        /// ログ種別文言の取得
        /// </summary>
        /// <param name="logType"></param>
        /// <returns></returns>
        public static string GetLogTypeText(Log.LogType logType)
        {
            return logType.GetApplied<DisplayAttribute>().First().Description;
        }
        #endregion

        #region アプリケーション種別文言の取得
        /// <summary>
        /// アプリケーション種別文言の取得
        /// </summary>
        /// <param name="applicationType"></param>
        /// <returns></returns>
        public static string GetApplicationTypeText(Log.ApplicationType applicationType)
        {
            return applicationType.GetApplied<DisplayAttribute>().First().Description;
        }
        #endregion

    }
}
