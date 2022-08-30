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
using CloverusCommon.Database.SqlServer.Sql;
using SprCommon;
using SprCommon.Database.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using SQL = CloverusCommon.Database.SqlServer.Sql;
#endregion

namespace CloverusCommon.Controls
{
    public partial class ClvsDropdown : UserControl
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ClvsDropdown()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ           
        /// <summary>
        /// コントロールと紐づくデータベースのカラム
        /// </summary>
        public string TableColumn
        {
            get;
            set;
        }
        /// <summary>
        /// タイトル
        /// </summary>
        public string TitleText
        {
            get { return LblTitle.Text; }
            set { LblTitle.Text = value; }
        }
        /// <summary>
        /// 値
        /// </summary>
        public string Value
        {

            get { return DrpDown.SelectedValue.ToString(); }
            set { DrpDown.SelectedValue = value; }
        }
        #endregion

        #region 要素の初期化
        public void InitializeDropdown()
        {
            if (TableColumn != null)
            {
                using (var db = new SqlBase(SqlBase.DatabaseKind.SYSTEM, SqlBase.TransactionUse.No))
                {
                    DrpDown.ValueMember = SQL.M_OTHER.ITEM_CODE;
                    DrpDown.DisplayMember = SQL.M_OTHER.ITEM_NAME;
                    DrpDown.DataSource = db.Select(SQL.M_OTHER.GetDropDownItems(TableColumn));
                }
            }
        }
        #endregion

        #region データベースの値をコントロールにセット
        /// <summary>
        /// データベースの値をコントロールにセット
        /// </summary>
        /// <param name="row"></param>
        public void SetFromDb(DataRow row)
        {
            if (!string.IsNullOrEmpty(TableColumn))
            {
                Value = row[TableColumn].ToString();
            }
        }
        #endregion

    }
}