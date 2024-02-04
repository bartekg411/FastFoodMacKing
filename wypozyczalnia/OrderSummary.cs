using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace wypozyczalnia
{
    public partial class OrderSummary : UserControl
    {
        public Dictionary<int, ProductInfo> Order = new Dictionary<int, ProductInfo>();
        public decimal price = (decimal)0.00;
        public bool payment = false;
        public OrderSummary()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.Hide();
        }
        public void UpdatePrice()
        {
            LabelPrice.Text = "Kwota: " + price.ToString() + " zł";
        }
        public void WriteOrderElements()
        {
            panel1.Controls.Clear();
            Label title = new Label();
            title.Text = "Podsumowanie:";
            title.Location = new System.Drawing.Point(20, 20);
            title.Size = new System.Drawing.Size(400, 50);
            title.TextAlign = ContentAlignment.MiddleLeft;
            title.Font = new Font("Microsoft Sans Serif", 28);
            int height = 90;
            int width = 20;
            panel1.Controls.Add(title);

            foreach (int i in Order.Keys)
            {
                Panel product = new Panel();
                product.Size = new System.Drawing.Size(920, 280);
                product.Location = new System.Drawing.Point(width, height);
                product.Name = Order[i].name;
                product.BackColor = System.Drawing.Color.FromArgb(255, 230, 194);
                product.BorderStyle = BorderStyle.FixedSingle;

                PictureBox picture = new PictureBox();
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Size = new Size(280, 280);
                picture.Location = new System.Drawing.Point(0, 0);
                try
                {
                    picture.Image = Image.FromFile(@"..\..\..\pictures\" + Order[i].imagePath);

                }
                catch (Exception e)
                {
                    picture.Image = Image.FromFile(@"..\..\..\pictures\error.png");
                }
                picture.MaximumSize = new Size(280,280);
                product.Controls.Add(picture);

                Label name = new Label();
                name.Text = Order[i].name;
                name.Location = new System.Drawing.Point(300, 20);
                name.Size = new System.Drawing.Size(400, 50);
                name.TextAlign = ContentAlignment.MiddleLeft;
                name.Font = new Font("Microsoft Sans Serif", 24);
                product.Controls.Add(name);

                Label price = new Label();
                price.Text = Order[i].price + " zł x " + Order[i].count.ToString() + " = " +(Order[i].price * Order[i].count).ToString() + " zł";
                price.Location = new System.Drawing.Point(300, 100);
                price.Size = new System.Drawing.Size(400, 50);
                price.TextAlign = ContentAlignment.MiddleLeft;
                price.Font = new Font("Microsoft Sans Serif", 24);
                product.Controls.Add(price);

                CustomButton delete = new CustomButton();
                delete.Text = "Usuń";
                delete.Name = i.ToString();
                delete.Location = new System.Drawing.Point(710, 200);
                delete.Size = new System.Drawing.Size(200, 70);
                delete.TextAlign = ContentAlignment.MiddleCenter;
                delete.Font = new Font("Microsoft Sans Serif", 24);
                delete.Click += new System.EventHandler(ButtonDelProduct);
                delete.BackColor=Color.FromArgb(167,4,4);
                delete.ForeColor = Color.White;
                product.Controls.Add(delete);


                //height += 220;
                panel1.Controls.Add(product);
                if (width > 920)
                {
                    width -= 940;
                    height += 300;
                }
                else
                {
                    width += 940;
                }
            }
        }
        private void ButtonDelProduct(object sender, EventArgs e)
        {
            DeleteProduct(Int32.Parse(((CustomButton)sender).Name));
        }

        public void DeleteProduct(int id)
        {
            price -= Order[id].price * Order[id].count;
            UpdatePrice();
            Order.Remove(id);
            ButtonPayEnabled();
            WriteOrderElements();
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            payment = true;
            this.Hide();
        }

        private void OrderSummary_VisibleChanged(object sender, EventArgs e)
        {
            ButtonPayEnabled();
        }
        public void ButtonPayEnabled()
        {
            if (Order.Count() > 0)
            {
                ButtonPay.Enabled = true;
                ButtonPay.BackColor = Color.FromArgb(167, 4, 4);
            }
            else
            {
                ButtonPay.BackColor = Color.Gray;
                ButtonPay.Enabled = false;
            }
        }
    }
}
