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
        public MenuBasicBusiness()
        {
            InitializeComponent();
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
            using (var db = new SqlBase(CloverusCommon.Database.SqlServer.SqlBase.TransactionUse.No, CloverusCommon.Log.ApplicationType.OrderManager))
            {
                var sql = CUS98MA01KOKYAKUM.GetPreviewForMenu(TxtKeyword.Text.Trim());
                var data = db.Select(sql);
                DgvCustomer.DataSource = data;
            }
        }
    }
}
