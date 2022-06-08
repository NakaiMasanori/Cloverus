using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloverusSys.MasterMaintenance.Customers
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
            using (var db = new CloverusCommon.Database.SqlBase(CloverusCommon.Database.SqlBase.DatabaseKind.USER, CloverusCommon.Database.SqlBase.TransactionUse.No))
            {

            }
        }
    }
}
