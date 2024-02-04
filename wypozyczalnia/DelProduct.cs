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
    public partial class DelProduct : UserControl
    {
        Dictionary<int, string> category = new Dictionary<int, string>();
        int currentCategory = 0;
        int currentProduct = 0;
        public DelProduct()
        {
            InitializeComponent();
            pullCategory();
            labelNameCategory.Text = category.ElementAt(currentCategory).Value.ToString();
            writeMenu();
        }
        void pullCategory()
        {
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
                    category.Add(dr.GetInt32(0), dr.GetString(1));
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

            string query = "SELECT * FROM Menu Where Kategoria=" + category.ElementAt(currentCategory).Key;
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            this.panelProducts.Controls.Clear();

            int height = 20;
            int width = 20;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string categoryName = dr.GetString(1);
                    Button buttonCategory = new Button();
                    buttonCategory.Size = new System.Drawing.Size(340, 380);
                    buttonCategory.Location = new System.Drawing.Point(width, height);
                    buttonCategory.Text = dr.GetString(1) + "\n" + dr.GetDecimal(3) + " zł";
                    buttonCategory.TextAlign = ContentAlignment.BottomCenter;
                    buttonCategory.Name = dr.GetInt32(0).ToString();
                    buttonCategory.BackColor = Color.FromArgb(255, 230, 194);
                    buttonCategory.Font = new Font("Microsoft Sans Serif", 24);
                    PictureBox picture = new PictureBox();
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Location = new System.Drawing.Point(30, 5);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    try
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\" + dr.GetString(4));

                    }
                    catch (Exception e)
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\error.png");
                    }
                    picture.Size = new Size(280, 280);
                    picture.Name = dr.GetInt32(0).ToString();

                    buttonCategory.Click += new System.EventHandler(chooseProduct);
                    picture.Click += new System.EventHandler(chooseProduct);

                    buttonCategory.Controls.Add(picture);

                    this.panelProducts.Controls.Add(buttonCategory);

                    if (width > 900)
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
            if (sender.GetType().ToString() == "System.Windows.Forms.Button")
            {
                currentProduct = Int32.Parse(((Button)sender).Name);
            }
            else
            {
                currentProduct = Int32.Parse(((PictureBox)sender).Name);
            }

            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "SELECT * FROM Menu Where ID=" + currentProduct;
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            Panel panelcurrentProduct = new Panel();
            panelcurrentProduct.Name = "panelcurrentProduct";
            panelcurrentProduct.Location = new Point(0, 0);
            panelcurrentProduct.Size = new Size(1470, 1080);
            panelcurrentProduct.BackColor = Color.FromArgb(255, 242, 223);
            this.Controls.Add(panelcurrentProduct);
            panelcurrentProduct.BringToFront();

            PictureBox picture = new PictureBox();
            picture.Location = new System.Drawing.Point(548, 50);
            picture.Size = new Size(376, 376);
            panelcurrentProduct.Controls.Add(picture);

            Label name = new Label();
            name.Name = "name";
            name.Size = new Size(400, 50);
            name.Location = new System.Drawing.Point(530, 450);
            name.Font = new Font("Microsoft Sans Serif", 32);
            name.TextAlign = ContentAlignment.MiddleCenter;
            panelcurrentProduct.Controls.Add(name);

            

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    try
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\" + dr.GetString(4));

                    }
                    catch (Exception e2)
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\error.png");
                    }
                    panelcurrentProduct.Name = dr.GetInt32(0).ToString();
                    name.Text = dr.GetString(1);
                }
            }

            CustomButton modify = new CustomButton();
            modify.Text = "Usuń";
            modify.ForeColor = Color.White;
            modify.Size = new Size(400, 100);
            modify.Font = new Font(modify.Font.FontFamily, 28);
            modify.Location = new Point(530, 810);
            modify.Click += new System.EventHandler(delProduct);
            modify.BackColor = Color.FromArgb(167, 4, 4);
            panelcurrentProduct.Controls.Add(modify);

            CustomButton cancel = new CustomButton();
            cancel.Text = "Cofnij";
            cancel.ForeColor = Color.White;
            cancel.Font=new Font(cancel.Font.FontFamily,28);
            cancel.Size = new Size(400, 100);
            cancel.Location = new Point(530, 930);
            cancel.BackColor = Color.FromArgb(167, 4, 4);
            cancel.Click += new System.EventHandler(closePanel);
            panelcurrentProduct.Controls.Add(cancel);

            dr.Close();
            conn.Close();

        }
        void delProduct(object sender, EventArgs e)
        {
            int id = Int32.Parse(((CustomButton)sender).Parent.Name);
            Label name = (Label)((CustomButton)sender).Parent.Controls.Find("name", false)[0];

            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            List<int> zamowienia = new List<int>();

            string query = $"SELECT ZamowienieID FROM SzczegolyZamowienia WHERE ProduktID={id}";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    zamowienia.Add(dr.GetInt32(0));
                }
            }
            dr.Close();

            foreach (int a in zamowienia)
            {
                string query2 = $"SELECT COUNT(ProduktID) FROM SzczegolyZamowienia WHERE ZamowienieID={a}";
                SqlCommand sqlCommand2 = new SqlCommand(query2, conn);
                SqlDataReader dr2 = sqlCommand2.ExecuteReader();
                if (dr2.GetInt32(0) == 1)
                {
                    string query3 = $"DELETE FROM SzczegolyZamowienia WHERE ZamowienieID={a}";
                    SqlCommand sqlCommand3 = new SqlCommand(query3, conn);
                    sqlCommand3.ExecuteScalar();
                    query3 = $"DELETE FROM Zamowienia WHERE ID={dr.GetInt32(0)}";
                    SqlCommand sqlCommand4 = new SqlCommand(query3, conn);
                    sqlCommand4.ExecuteScalar();
                }
                else
                {
                    string query3 = $"DELETE FROM SzczegolyZamowienia WHERE ProduktID={id} AND ZamowienieID={a}";
                    SqlCommand sqlCommand3 = new SqlCommand(query3, conn);
                    sqlCommand3.ExecuteScalar();
                }
                dr2.Close();
            }


            query = $"DELETE FROM Menu WHERE ID={id}";
            SqlCommand sqlCommand5 = new SqlCommand(query, conn);
            sqlCommand5.ExecuteScalar();

            MessageBox.Show("Usunięto pomyślnie");

            conn.Close();

            closePanel(sender, e);

            //string query = $"SELECT ZamowienieID FROM SzczegolyZamowienia WHERE ProduktID={id}";
            //SqlCommand sqlCommand = new SqlCommand(query, conn);
            //SqlDataReader dr = sqlCommand.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {
            //        string query2 = $"SELECT COUNT(ProduktID) FROM SzczegolyZamowienia WHERE ZamowienieID={dr.GetInt32(0)}";
            //        SqlCommand sqlCommand2 = new SqlCommand(query2, conn);
            //        SqlDataReader dr2 = sqlCommand2.ExecuteReader();
            //        if(dr2.GetInt32(2)==1)
            //        {
            //            string query3 = $"DELETE FROM SzczegolyZamowienia WHERE ZamowienieID={dr.GetInt32(0)}";
            //            SqlCommand sqlCommand3 = new SqlCommand(query3, conn);
            //            sqlCommand3.ExecuteScalar();
            //            query3 = $"DELETE FROM Zamowienia WHERE ID={dr.GetInt32(0)}";
            //            SqlCommand sqlCommand4 = new SqlCommand(query3, conn);
            //            sqlCommand4.ExecuteScalar();
            //        }
            //        else
            //        {
            //            string query3 = $"DELETE FROM SzczegolyZamowienia WHERE ProduktID={id} AND ZamowienieID={dr.GetInt32(0)}";
            //            SqlCommand sqlCommand3 = new SqlCommand(query3, conn);
            //            sqlCommand3.ExecuteScalar();
            //        }
            //    }
            //}
            //dr.Close();

        }
        void closePanel(object sender, EventArgs e)
        {
            ((CustomButton)sender).Parent.Parent.Controls.Remove(((CustomButton)sender).Parent);
            writeMenu();
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentCategory - 1 >= 0)
            {
                currentCategory--;
                labelNameCategory.Text = category.ElementAt(currentCategory).Value.ToString();
                writeMenu();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentCategory + 1 <= category.Count() - 1)
            {
                currentCategory++;
                labelNameCategory.Text = category.ElementAt(currentCategory).Value.ToString();
                writeMenu();
            }
        }
    }
}
