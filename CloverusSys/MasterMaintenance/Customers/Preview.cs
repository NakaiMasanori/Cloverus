using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SprCommon.Database.SqlServer;

namespace CloverusSys.MasterMaintenance.Customers
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
            using (var db = new SqlBase(SqlBase.DatabaseKind.USER, SqlBase.TransactionUse.No))
            {

            }
        }
    }
}
