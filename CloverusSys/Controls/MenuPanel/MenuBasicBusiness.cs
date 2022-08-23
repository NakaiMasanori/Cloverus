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
using Sql = CloverusCommon.Database.SqlServer.Sql;
using SqlBase = CloverusCommon.Database.SqlServer.SqlBase;

namespace CloverusSys.Controls.MenuPanel
{
    public partial class MenuBasicBusiness : UserControl
    {
        public DataGridView PreviewCustomer
        {
            get { return this.DgvCustomer; }
        }

        public TextBox CustomerSearchKeyword
        {
            get { return this.TxtKeyword; }
        }

        public MenuBasicBusiness()
        {
            InitializeComponent();
            this.TxtKeyword.KeyDown += new KeyEventHandler(this.TxtKeyword_KeyDown);
            this.DgvCustomer.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.DgvCustomer_DataBindingComplete);
            this.DgvCustomer.DoubleClick += new EventHandler(this.DgvCustomer_DoubleClick);
            this.BtnEditCustomer.Click += new EventHandler(this.BtnEditCustomer_Click);
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
            using (var db = new SqlBase(SqlBase.TransactionUse.No, CloverusCommon.Log.ApplicationType.OrderManager))
            {
                DgvCustomer.DataSource = db.Select(Sql.M_CUSTOMER.GetPreviewForMenu(TxtKeyword.Text.Trim()));
            }
        }

        private void DgvCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gv = (DataGridView)sender;
            gv.Columns[0].Width = 120;
            gv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gv.Columns[1].Width = 240;
            gv.Columns[2].Width = 420;
            TxtKeyword.Focus();
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            ShowCustomerEdit();
        }

        private void DgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            ShowCustomerEdit();
        }

        private void ShowCustomerEdit()
        {
            int.TryParse(this.DgvCustomer.SelectedRows[0].Cells[0].Value.ToString(), out int customerCode);
            var frm = new MasterMaintenance.Customers.FrmEdit(customerCode);
            frm.Show();
        }

        private void DgvCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                ShowCustomerEdit();
            }
        }
    }
}
