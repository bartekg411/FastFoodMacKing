using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalnia
{
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
        }
        private void Payment_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                //Thread.Sleep(5000);
                this.Hide();
            }
        }
    }
}
