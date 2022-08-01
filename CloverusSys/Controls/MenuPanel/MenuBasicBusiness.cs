using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloverusCommon.Database;
using CloverusCommon.Database.SqlServer;
using CloverusCommon.Database.SqlServer.Sql;

namespace CloverusSys.Controls.MenuPanel
{
    public partial class MenuBasicBusiness : UserControl
    {
        public DataGridView PreviewCustomer
        {
            get { return this.DgvCustomer; }
        }
        public MenuBasicBusiness()
        {
            InitializeComponent();
            this.TxtKeyword.KeyDown += new KeyEventHandler(this.TxtKeyword_KeyDown);
            this.DgvCustomer.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.DgvCustomer_DataBindingComplete);
        }

        public void Preview()
        {
            PreviewKokyaku();
        }

        private void TxtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtKeyword.Text.Trim()) && e.KeyCode == Keys.Enter)
            {
                PreviewKokyaku();
            }
        }

        private void PreviewKokyaku()
        {
            using (var db = new CloverusCommon.Database.SqlServer.SqlBase(CloverusCommon.Database.SqlServer.SqlBase.TransactionUse.No, CloverusCommon.Log.ApplicationType.OrderManager))
            {
                DgvCustomer.DataSource = db.Select(CUS98MA01KOKYAKUM.GetPreviewForMenu(TxtKeyword.Text.Trim()));
            }
        }

        private void DgvCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gv = (DataGridView)sender;
            gv.Columns[0].Width = 120;
            gv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gv.Columns[1].Width = 240;
            gv.Columns[2].Width = 420;
        }
    }
}
