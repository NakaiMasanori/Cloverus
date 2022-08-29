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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace SprCommon.Controls
{
    public partial class SprAddressBox : UserControl
    {
        public SprAddressBox()
        {
            InitializeComponent();
        }

        private void BtnPreviewAddress_Click(object sender, EventArgs e)
        {
            var frm = new CloverusCommon.Forms.AddressSelector.Preview(TxtPostCode.Text);
            frm.ShowDialog();
        }
    }
}
