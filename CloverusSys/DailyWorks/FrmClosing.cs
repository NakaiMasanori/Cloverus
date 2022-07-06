using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloverusSys.DailyWorks
{
    public partial class FrmClosing : Base.BaseForm
    {
        public FrmClosing()
        {
            InitializeComponent();
            DtpFromDate.Value = DateTime.Now;
            SetNextBusinessDay();
        }

        #region イベント
        private void DtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SetNextBusinessDay();
            }
            catch (Exception ex)
            {
                var a = ex.Message;
            }
        }
        #endregion

        #region private functions
        /// <summary>
        /// 
        /// </summary>
        private void SetNextBusinessDay()
        {
            this.DtpFromDate.ValueChanged -= new EventHandler(this.DtpFromDate_ValueChanged);
            DtpTillDate.Value = NextBusinessDay(DtpFromDate.Value);
            if ((int)(DtpTillDate.Value - DtpFromDate.Value).TotalDays > 3)
            {
                LblArert.Text = "日付の範囲が3日を超えている為、実行時にパスワード入力が必要となります。";
            }
            else
            {
                LblArert.Text = "";
            }
            this.DtpFromDate.ValueChanged += new EventHandler(this.DtpFromDate_ValueChanged);
        }
        #endregion
    }
}
