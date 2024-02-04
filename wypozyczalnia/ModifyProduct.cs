using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace wypozyczalnia
{
    public partial class ModifyProduct : UserControl
    {
        Dictionary<int,string> category = new Dictionary<int,string>();
        int currentCategory = 0;
        int currentProduct = 0;
        public ModifyProduct()
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
                    catch(Exception e)
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
            picture.Location = new System.Drawing.Point(598, 10);
            picture.Size = new Size(276, 276);
            panelcurrentProduct.Controls.Add(picture);

            Label labelName = new Label();
            labelName.Font = new Font("Microsoft Sans Serif", 28);
            labelName.Text = "Nazwa";
            labelName.Size = new Size(200,50) ;
            labelName.BackColor = Color.Transparent;
            labelName.Location= new System.Drawing.Point(400, 300);
            panelcurrentProduct.Controls.Add(labelName);


            TextBox name = new TextBox();
            name.Name = "name";
            name.Size = new Size(400, 50);
            name.Location = new System.Drawing.Point(670, 300);
            name.Font = new Font("Microsoft Sans Serif", 28);
            panelcurrentProduct.Controls.Add(name);

            Label labelPrice = new Label();
            labelPrice.Font = new Font("Microsoft Sans Serif", 28);
            labelPrice.Text = "Cena";
            labelPrice.Size = new Size(200, 50);
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Location = new System.Drawing.Point(400, 375);
            panelcurrentProduct.Controls.Add(labelPrice);

            TextBox price = new TextBox();
            price.Name = "price";
            price.Size = new Size(400, 50);
            price.Location = new System.Drawing.Point(670, 375);
            price.Font = new Font("Microsoft Sans Serif",28);
            panelcurrentProduct.Controls.Add(price);

            Label labelImagePath = new Label();
            labelImagePath.Font = new Font("Microsoft Sans Serif", 28);
            labelImagePath.Text = "Zdjęcie";
            labelImagePath.Size = new Size(200, 50);
            labelImagePath.BackColor = Color.Transparent;
            labelImagePath.Location = new System.Drawing.Point(400, 450);
            panelcurrentProduct.Controls.Add(labelImagePath);

            TextBox imagePath = new TextBox();
            imagePath.Name = "imagePath";
            imagePath.Size = new Size(400, 50);
            imagePath.Location = new System.Drawing.Point(670, 450);
            imagePath.Font = new Font("Microsoft Sans Serif", 28);
            panelcurrentProduct.Controls.Add(imagePath);

            Label labelAvailable = new Label();
            labelAvailable.Font = new Font("Microsoft Sans Serif", 28);
            labelAvailable.Text = "Dostępność";
            labelAvailable.Size = new Size(225, 50);
            labelAvailable.BackColor = Color.Transparent;
            labelAvailable.Location = new System.Drawing.Point(400, 525);
            panelcurrentProduct.Controls.Add(labelAvailable);

            ListBox available = new ListBox();
            available.Name = "available";
            available.Size = new Size(400, 88);
            available.Location = new System.Drawing.Point(670, 525);
            available.Font = new Font("Microsoft Sans Serif", 28);
            available.Items.Add("Niedostępny");
            available.Items.Add("Dostępny");
            panelcurrentProduct.Controls.Add(available);

            Label labelCategory = new Label();
            labelCategory.Font = new Font("Microsoft Sans Serif", 28);
            labelCategory.Text = "Kategoria";
            labelCategory.Size = new Size(200, 50);
            labelCategory.BackColor = Color.Transparent;
            labelCategory.Location = new System.Drawing.Point(400, 638);
            panelcurrentProduct.Controls.Add(labelCategory);

            ListBox listcategory = new ListBox();
            listcategory.Name = "listcategory";
            listcategory.Size = new Size(400, 308);
            listcategory.Location = new System.Drawing.Point(670, 638);
            listcategory.Font = new Font("Microsoft Sans Serif", 28);
            foreach(int a in category.Keys)
            {
                listcategory.Items.Add(category[a]);
            }
            panelcurrentProduct.Controls.Add(listcategory);

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
                    price.Text = dr.GetDecimal(3).ToString();
                    imagePath.Text = dr.GetString(4);
                    
                    available.SelectedIndex = Convert.ToInt32(dr.GetBoolean(5));
                    listcategory.SelectedItem = category[dr.GetInt32(2)];
                }
            }

            CustomButton modify = new CustomButton();
            modify.Text = "Modyfikuj";
            modify.Size = new Size(350, 80);
            modify.Location = new Point(760, 975);
            modify.Font = new Font(modify.Font.FontFamily, 28);
            modify.Click += new System.EventHandler(modifyProduct);
            modify.BackColor = Color.FromArgb(167, 4, 4);
            panelcurrentProduct.Controls.Add(modify);
            modify.ForeColor = Color.White;

            CustomButton cancel = new CustomButton();
            cancel.Text = "Cofnij";
            cancel.Size = new Size(350, 80);
            cancel.ForeColor = Color.White;
            cancel.Location = new Point(360, 975);
            cancel.Click += new System.EventHandler(closePanel);
            panelcurrentProduct.Controls.Add(cancel);
            cancel.Font = new Font(cancel.Font.FontFamily, 28);
            cancel.BackColor = Color.FromArgb(167, 4, 4);

            dr.Close();
            conn.Close();

        }
        void modifyProduct(object sender, EventArgs e)
        {
            int id = Int32.Parse(((CustomButton)sender).Parent.Name);
            TextBox name = (TextBox)((CustomButton)sender).Parent.Controls.Find("name", false)[0];
            TextBox price = (TextBox)((CustomButton)sender).Parent.Controls.Find("price", false)[0];
            TextBox imagePath = (TextBox)((CustomButton)sender).Parent.Controls.Find("imagePath", false)[0];
            ListBox availabe = (ListBox)((CustomButton)sender).Parent.Controls.Find("available", false)[0];
            ListBox listcategory = (ListBox)((CustomButton)sender).Parent.Controls.Find("listcategory", false)[0];
            int categoryID = category.FirstOrDefault(x => x.Value == listcategory.SelectedItem.ToString()).Key;
                

            if (listcategory.SelectedItem == null || availabe.SelectedItem == null || name.Text == "" || imagePath.Text == "")
            {
                MessageBox.Show("Brakuje danych!");
                return;
            }

            double a;
            string query;

            if (double.TryParse(price.Text, out a) || (double.TryParse(price.Text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out a)))
            {
                query = $"update Menu set Nazwa='{name.Text}', Kategoria={categoryID}, cena=convert(decimal(5,2), replace('{price.Text}',',','.')), Zdjecie='{imagePath.Text}', Dostepnosc={availabe.SelectedIndex} where ID={id}";
            }
            else
            {
                MessageBox.Show("Błedny format ceny!");
                return;
            }

            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteScalar();

            MessageBox.Show("Dane produktu zostały zmodyfikowane pomyślnie");

            conn.Close();

            closePanel(sender, e);
        }
        void closePanel(object sender, EventArgs e)
        {
            ((CustomButton)sender).Parent.Parent.Controls.Remove(((CustomButton)sender).Parent);
            writeMenu();
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(currentCategory-1>=0)
            {
                currentCategory--;
                labelNameCategory.Text = category.ElementAt(currentCategory).Value.ToString();
                writeMenu();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(currentCategory+1<=category.Count()-1)
            {
                currentCategory++;
                labelNameCategory.Text = category.ElementAt(currentCategory).Value.ToString();
                writeMenu();
            }
        }
    }
}
