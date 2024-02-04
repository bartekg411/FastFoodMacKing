using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalnia
{
    public partial class TakeOut : UserControl
    {
        public bool TakeOutVar;
        public TakeOut()
        {
            InitializeComponent();
        }

        private void buttonTakeOut_Click(object sender, EventArgs e)
        {
            TakeOutVar = true;
            this.Hide();
        }

        private void buttonEatIn_Click(object sender, EventArgs e)
        {
            TakeOutVar = false;
            this.Hide();
        }
    }
}
