using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalnia
{
    public partial class ConfirmProduct : UserControl
    {
        public int id;
        public decimal price = 0;
        public int count=1;
        public string name;
        public string imagePath;
        public ConfirmProduct()
        {
            InitializeComponent();
            this.Hide();
        }
        public void WriteProductDetails(int id)
        {
            Count.Text = 1.ToString();
            count = 1;
            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "SELECT * FROM Menu Where ID="+id;
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
                    try
                    {
                        PictureBoxProduct.Image = Image.FromFile(@"..\..\..\pictures\" + dr.GetString(4));

                    }
                    catch (Exception e)
                    {
                        PictureBoxProduct.Image = Image.FromFile(@"..\..\..\pictures\error.png");
                    }
                    ProductName.Text = dr.GetString(1);
                    Price.Text = dr.GetDecimal(3)+" zł";
                    price = dr.GetDecimal(3);
                    this.id = id;
                    this.name = dr.GetString(1);
                    this.imagePath = dr.GetString(4);//dr.GetString();
                }
            }

            dr.Close();
            conn.Close();
        }

        private void ButtonLess_Click(object sender, EventArgs e)
        {
            if(count==1)
            {
                return;
            }
            count--;
            Count.Text = count.ToString();
            Price.Text = (price*count).ToString() + " zł";
        }

        private void ButtonMore_Click(object sender, EventArgs e)
        {
            if(count==99)
            {
                return;
            }
            count++;
            Count.Text = count.ToString();
            Price.Text = (price * count).ToString() + " zł";
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            price = 0;
            count = 1;
            this.Hide();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ConfirmProduct_Load(object sender, EventArgs e)
        {

        }

        private void PictureBoxProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
