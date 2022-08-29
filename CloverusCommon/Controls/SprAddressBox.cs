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
            var postCode = TxtPostCode.Text.Replace("-", "");
            if (!CheckPostCode(postCode))
            {
                Messages.ShowDialog(Sentence.Messages.InvalidPostalCode);
                TxtPostCode.Focus();
                return;
            }
            var prefectures = string.Empty;
            var municipalities = string.Empty;
            var townArea = string.Empty;
            var frm = new CloverusCommon.Forms.AddressSelector.Preview(postCode);
            switch (frm.Count)
            {
                case 0:
                    Messages.ShowDialog(Sentence.Messages.InvalidPostalCode);
                    return;
                case 1:
                    prefectures = frm.Prefectures;
                    municipalities = frm.Municipalities;
                    townArea = frm.TownArea;
                    break;
                default:
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        prefectures = frm.Prefectures;
                        municipalities = frm.Municipalities;
                        townArea = frm.TownArea;
                    }
                    break;
            }
            if (!string.IsNullOrEmpty(prefectures))
            {
                SetAdressData(prefectures, municipalities, townArea);
            }
        }

        private void SetAdressData(string prefectures, string municipalities, string townArea)
        {
            if (!string.IsNullOrEmpty(TxtPrefectures.Text.Trim()))
            {
                // 確認でNoを選択したらなにもしない
                if (Messages.ShowDialog(Sentence.Messages.ChangeAddress) == DialogResult.No)
                {
                    return;
                }
            }
            TxtPrefectures.Text = $"{municipalities}{townArea}";
            //TxtMunicipalities.Text = municipalities;
            //TxtTownArea.Text = townArea;
        }

        private bool CheckPostCode(string postCode)
        {
            if (string.IsNullOrEmpty(postCode))
            {
                return false;
            }
            if (postCode.Length != 7)
            {
                return false;
            }
            if (!int.TryParse(postCode, out int val))
            {
                return false;
            }
            return true;
        }
    }
}
