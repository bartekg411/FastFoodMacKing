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
    public partial class Products : UserControl
    {
        public int currentCategory=1;
        public int currentProduct=0;
        Dictionary<int, string> Category = new Dictionary<int, string>();
        
        public Products()
        {
            InitializeComponent();
            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string query = "SELECT * FROM Kategorie";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Category.Add(dr.GetInt32(0), dr.GetString(1));
                }
            }

            dr.Close();
            conn.Close();
        }
        public void writeMenu()
        {
            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string query = "SELECT * FROM Menu Where Kategoria="+currentCategory+" AND Dostepnosc = 1";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            this.Controls.Clear();

            Label LabelCategoryName = new Label();
            LabelCategoryName.Size = new System.Drawing.Size(800, 100);
            LabelCategoryName.Text = Category[currentCategory];
            LabelCategoryName.Font = new Font("Microsoft Sans Serif", 48);
            LabelCategoryName.ForeColor = Color.FromArgb(167, 4, 4);
            LabelCategoryName.Location = new System.Drawing.Point(10, 20);
            this.Controls.Add(LabelCategoryName);

            int height = 120;
            int width = 20;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string categoryName = dr.GetString(1);
                    Button buttonCategory = new Button();
                    buttonCategory.Size = new System.Drawing.Size(340, 380);
                    buttonCategory.Location = new System.Drawing.Point(width, height);
                    buttonCategory.Text = dr.GetString(1)+"\n"+ dr.GetDecimal(3)+" zł";
                    buttonCategory.TextAlign = ContentAlignment.BottomCenter;
                    buttonCategory.Name = dr.GetInt32(0).ToString();
                    buttonCategory.BackColor = Color.FromArgb(255, 230, 194);
                    buttonCategory.Font = new Font("Microsoft Sans Serif", 24);
                    PictureBox picture = new PictureBox();
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Location = new System.Drawing.Point(30, 5);
                    picture.SizeMode=PictureBoxSizeMode.Zoom;
                    try
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\" + dr.GetString(4));

                    }
                    catch (Exception e)
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\error.png");
                    }
                    picture.Size = new Size(280,280);
                    picture.Name = dr.GetInt32(0).ToString();

                    // picture.ImageLocation = "C:\\Users\\damia\\Desktop\\picture\\wypozyczalnia_narzedzi\\pictures\\WelcomePageBackground.jpg"; 
                    buttonCategory.Click += new System.EventHandler(chooseProduct);
                    picture.Click += new System.EventHandler(chooseProduct);

                    buttonCategory.Controls.Add(picture);

                    this.Controls.Add(buttonCategory);

                    if (width>900)
                    {
                        height += 400;
                        width = 20;
                    }
                    else
                    {
                        width += 360;
                    }
                }
            }

            dr.Close();
            conn.Close();
        }
        private void chooseProduct(object sender, EventArgs e)
        {
            if(sender.GetType().ToString() == "System.Windows.Forms.Button")
            {
                currentProduct = Int32.Parse(((Button)sender).Name);
            }
            else
            {
                currentProduct = Int32.Parse(((PictureBox)sender).Name);
            }
            this.Hide();

        }

    }
}
