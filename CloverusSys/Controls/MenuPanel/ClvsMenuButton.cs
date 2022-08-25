using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloverusSys.Controls.MenuPanel
{
    public partial class ClvsMenuButton : UserControl
    {
        public MenuControl.MenuItems MenuItem { get; set; }
        public string ButtonText
        {
            get
            {
                return BtnItem.Text;
            }
            set
            {
                BtnItem.Text = value;
            }
        }

        public event EventHandler Clicked;

        public ClvsMenuButton()
        {
            InitializeComponent();
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            if (Clicked == null)
            {
                return;
            }
            Clicked(this, e);
        }
    }
}
