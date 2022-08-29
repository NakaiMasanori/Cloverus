//*****************************************************************************
//
//  システム名：宅食業販売管理システム CloverusSys
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlBase = CloverusCommon.Database.SqlServer.SqlBase;
using CloverusCommon.Database.SqlServer.Sql;
#endregion

namespace CloverusCommon.Controls
{
    public partial class ClvsRouteSelect : UserControl
    {

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ClvsRouteSelect()
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
        /// タイトル部の幅
        /// </summary>
        public int TitleWidth
        {
            get { return LblTitle.Width; }
            set { LblTitle.Width = value; }
        }
        /// <summary>
        /// 値
        /// </summary>
        public string TextValue
        {
            get { return TxtData.Text; }
            set { TxtData.Text = value; }
        }
        /// <summary>
        /// テキストボックス部の幅
        /// </summary>
        public int TextBoxWidth
        {
            get { return TxtData.Width; }
            set { TxtData.Width = value; }
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string LabelValue
        {
            get { return LblRouteName.Text; }
            set { LblRouteName.Text = value; }
        }
        /// <summary>
        /// 昼、夜区分
        /// </summary>
        public M_ROUTE.RouteType Route
        {
            get;
            set;
        }

        #endregion

        #region データベースの値をコントロールにセット
        /// <summary>
        /// データベースの値をコントロールにセット
        /// </summary>
        /// <param name="row"></param>
        public void SetFromDb(DataRow row, SqlBase db)
        {
            if (!string.IsNullOrEmpty(TableColumn) && row.Table.Columns.Contains(TableColumn))
            {
                TextValue = row[TableColumn].ToString();
                var dt = db.Select(M_ROUTE.GetName(Route, TextValue));
                if (dt != null && dt.Rows.Count > 0)
                {
                    LabelValue = dt.Rows[0][M_ROUTE.ROUTE_NAME].ToString();
                }
                else
                {
                    LabelValue = string.Empty;
                }
            }
        }
        #endregion
    }
}
