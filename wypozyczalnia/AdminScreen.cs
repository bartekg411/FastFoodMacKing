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
    public partial class AdminScreen : UserControl
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if(this.panelContent.Controls.Find("addProduct", true).Count() == 0)
            {
                this.panelContent.Controls.Clear();
                AddProduct addProduct = new AddProduct();
                addProduct.Name = "addProduct";
                addProduct.Location = new Point(0,0);
                this.panelContent.Controls.Add(addProduct);
            }
        }
        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {
            if(this.panelContent.Controls.Find("modifyProduct", true).Count() == 0)
            {
                this.panelContent.Controls.Clear();
                ModifyProduct modifyProduct = new ModifyProduct();
                modifyProduct.Name = "modifyProduct";
                modifyProduct.Location = new Point(0, 0);
                this.panelContent.Controls.Add(modifyProduct);
            }
        }
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void buttonDelProduct_Click(object sender, EventArgs e)
        {
            if (this.panelContent.Controls.Find("delProduct", true).Count() == 0)
            {
                this.panelContent.Controls.Clear();
                DelProduct delProduct = new DelProduct();
                delProduct.Name = "delProduct";
                delProduct.Location = new Point(0, 0);
                this.panelContent.Controls.Add(delProduct);
            }
        }
    }
}
