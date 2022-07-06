using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloverusSys.Base
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public DateTime NextBusinessDay(DateTime today)
        {
            var nextday = today.AddDays(2);
            switch (nextday.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    nextday = nextday.AddDays(2);
                    break;
                case DayOfWeek.Sunday:
                    nextday = nextday.AddDays(1);
                    break;
            }
            return nextday;
        }
    }
}
