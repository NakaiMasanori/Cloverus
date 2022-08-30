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
        public string TableColumnDay
        {
            get;
            set;
        }
        public string TableColumnNight
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
        /// 値(昼)
        /// </summary>
        public string DayValue
        {
            get { return TxtDay.Text; }
            set { TxtDay.Text = value; }
        }
        /// <summary>
        /// 値(夜)
        /// </summary>
        public string NightValue
        {
            get { return TxtNight.Text; }
            set { TxtNight.Text = value; }
        }
        /// <summary>
        /// 名称(昼)
        /// </summary>
        public string DayText
        {
            get { return LblNameDay.Text; }
            set { LblNameDay.Text = value; }
        }
        /// <summary>
        /// 名称(夜)
        /// </summary>
        public string NightText
        {
            get { return LblNameNight.Text; }
            set { LblNameNight.Text = value; }
        }

        #endregion

        #region データベースの値をコントロールにセット
        /// <summary>
        /// データベースの値をコントロールにセット
        /// </summary>
        /// <param name="row"></param>
        public void SetFromDb(DataRow row, SqlBase db)
        {
            if (!string.IsNullOrEmpty(TableColumnDay) && row.Table.Columns.Contains(TableColumnDay))
            {
                DayValue = row[TableColumnDay].ToString();
                var dt = db.Select(M_ROUTE.GetName(M_ROUTE.RouteType.DayTime, DayValue));
                if (dt != null && dt.Rows.Count > 0)
                {
                    DayText = dt.Rows[0][M_ROUTE.ROUTE_NAME].ToString();
                }
                else
                {
                    DayText = string.Empty;
                }
                NightValue = row[TableColumnNight].ToString();
                dt = db.Select(M_ROUTE.GetName(M_ROUTE.RouteType.NightTime, NightValue));
                if (dt != null && dt.Rows.Count > 0)
                {
                    NightText = dt.Rows[0][M_ROUTE.ROUTE_NAME].ToString();
                }
                else
                {
                    NightText = string.Empty;
                }
            }
        }
        #endregion
    }
}
