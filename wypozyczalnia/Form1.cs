using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace wypozyczalnia
{
    public partial class Form1 : Form
    {
        public bool TakeOut;
        private async void PlayBackgroundSoundAsync()
        {
            // Tworzenie obiektu SoundPlayer
            SoundPlayer myPlayer = new SoundPlayer();
            myPlayer.SoundLocation = @"C:\Users\gorcz\Downloads\muz.wav";

            // Odtwarzanie dźwięku w tle w nieskończoność
            while (true)
            {
                myPlayer.PlaySync(); // Synchroniczne odtwarzanie dźwięku

                // Przerwa między odtwarzaniami
                await Task.Delay(500);
            }
        }

        public Form1()
        {
            InitializeComponent();
            welcomePage1.Show();
            welcomePage1.BringToFront();
            PrintCategory();
            UpdatePrice();
            products1.Hide();
            orderSummary1.Hide();
            PanelBottom.Hide();
            payment1.Hide();
            ButtonSummaryEnabled();
            employeeScreen1.Hide();
            adminScreen1.Hide();
            log1.Hide();
            Task.Run(() => PlayBackgroundSoundAsync());
        }
        
        private void showLogo()
        {
            PictureBox logo = new PictureBox();
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Location = new System.Drawing.Point(0, 0);
            logo.Image = Image.FromFile(@"..\..\..\pictures\logo.png");
            logo.Size = new Size(432, 150);
            logo.BackColor = Color.FromArgb(255, 230, 194);
            this.Controls.Add(logo);
            logo.Show();
            logo.BringToFront();
        }
        private void PrintCategory()
        {
            int height = 150;
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
                    string categoryName = dr.GetString(1);
                    CustomButton buttonCategory = new CustomButton();
                    buttonCategory.Size = new System.Drawing.Size(432, 150);
                    buttonCategory.Location = new System.Drawing.Point(0, height); ;
                    buttonCategory.Text = categoryName;
                    buttonCategory.Name = dr.GetInt32(0).ToString();
                    buttonCategory.BackColor = System.Drawing.Color.FromArgb(255, 230, 194);
                    buttonCategory.Font = new Font("Microsoft Sans Serif", 24);
                    buttonCategory.Click += new System.EventHandler(chooseCategory);

                    this.PanelMenu.Controls.Add(buttonCategory);
                    height += 150;
                }
            }
            dr.Close();
            conn.Close();
        }
        private void welcomePage1_VisibleChanged(object sender, EventArgs e)
        {
            if (!welcomePage1.Visible && !welcomePage1.employee)
            {
                takeOut1.Show();
                takeOut1.BringToFront();
            }
            if (!welcomePage1.Visible && welcomePage1.employee)
            {
                log1.Show();
                log1.BringToFront();

            }
        }

        private void employeeScreen1_VisibleChanged(object sender, EventArgs e)
        {
            if (employeeScreen1.Visible && welcomePage1.employee == true)
            {
                welcomePage1.employee = false;
                employeeScreen1.LoadProducts();
                employeeScreen1.LoadOrders();
                employeeScreen1.WriteOrders();
            }
            if (!employeeScreen1.Visible && welcomePage1.employee == false)
            {
                welcomePage1.Show();
                welcomePage1.BringToFront();
            }
        }

        private void takeOut1_VisibleChanged(object sender, EventArgs e)
        {
            if (!takeOut1.Visible)
            {
                TakeOut = takeOut1.TakeOutVar;
                products1.Show();
                products1.writeMenu();
                products1.BringToFront();
                PanelBottom.Show();
                PanelBottom.BringToFront();
                showLogo();
            }
        }
        private void chooseCategory(object sender, EventArgs e)
        {
            products1.currentCategory = Int32.Parse(((CustomButton)sender).Name);
            products1.writeMenu();
            products1.Show();
            products1.BringToFront();
        }
        private void products1_VisibleChanged(object sender, EventArgs e)
        {
            if (!products1.Visible && products1.currentProduct != 0)
            {
                confirmProduct1.Show();
                confirmProduct1.BringToFront();
                confirmProduct1.WriteProductDetails(products1.currentProduct);
                products1.currentProduct = 0;
            }
        }

        private void confirmProduct1_VisibleChanged(object sender, EventArgs e)
        {
            if (!confirmProduct1.Visible && confirmProduct1.price != 0)
            {

                if (!orderSummary1.Order.ContainsKey(confirmProduct1.id))
                {
                    orderSummary1.Order.Add(confirmProduct1.id, new ProductInfo(confirmProduct1.name, confirmProduct1.price, confirmProduct1.count, confirmProduct1.imagePath));
                    orderSummary1.price += confirmProduct1.price * confirmProduct1.count;
                    UpdatePrice();
                }
                else
                {
                    orderSummary1.Order[confirmProduct1.id].count += confirmProduct1.count;
                    orderSummary1.price += confirmProduct1.price * confirmProduct1.count;
                    UpdatePrice();
                }
                confirmProduct1.id = 0;
                confirmProduct1.count = 1;
                products1.Show();
                products1.BringToFront();
            }
            if (!confirmProduct1.Visible)
            {
                products1.Show();
                products1.BringToFront();
            }
            ButtonSummaryEnabled();
        }
        private void ButtonOrderCancel_Click(object sender, EventArgs e)
        {
            orderSummary1.Order.Clear();
            orderSummary1.price = 0;
            UpdatePrice();
            takeOut1.Show();
            welcomePage1.Show();
            welcomePage1.BringToFront();
        }
        void UpdatePrice()
        {
            LabelPrice.Text = "Kwota: " + orderSummary1.price.ToString() + " zł";
        }

        private void ButtonSummary_Click(object sender, EventArgs e)
        {
            orderSummary1.Show();
            orderSummary1.WriteOrderElements();
            orderSummary1.UpdatePrice();
            orderSummary1.BringToFront();

        }

        private void orderSummary1_VisibleChanged(object sender, EventArgs e)
        {
            if (!orderSummary1.Visible && orderSummary1.payment)
            {
                payment1.Show();
                payment1.BringToFront();

            }
            if (!orderSummary1.Visible)
            {
                UpdatePrice();
                ButtonSummaryEnabled();
            }
        }

        private void payment1_VisibleChanged(object sender, EventArgs e)
        {
            if (!payment1.Visible && orderSummary1.payment)
            {
                orderSummary1.payment = false;
                string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                int a;
                if (TakeOut)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                string query = $"INSERT INTO Zamowienia (Data, Godzina, NaWynos, Zrealizowano) OUTPUT INSERTED.ID Values (Convert(Date,GETDATE()), Convert(time,GETDATE()), {a}, 0);";
                SqlCommand sqlCommand = new SqlCommand(query, conn);

                int dr = Int32.Parse(sqlCommand.ExecuteScalar().ToString());
                foreach (int id in orderSummary1.Order.Keys)
                {
                    query = $"Insert into SzczegolyZamowienia (ZamowienieID,ProduktID,Ilosc,Przygotowane) values({dr},{id},{orderSummary1.Order[id].count}, 0)";
                    sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteScalar();
                }

                conn.Close();

                orderSummary1.Order.Clear();
                orderSummary1.price = 0;
                UpdatePrice();
                welcomePage1.Show();
                welcomePage1.BringToFront();
            }
        }

        public void ButtonSummaryEnabled()
        {
            if (orderSummary1.Order.Count() > 0)
            {
                ButtonSummary.Enabled = true;
                ButtonSummary.BackColor = Color.FromArgb(167, 4, 4);
            }
            else
            {
                ButtonSummary.BackColor = Color.Gray;
                ButtonSummary.Enabled = false;
            }
        }

        private void log1_VisibleChanged(object sender, EventArgs e)
        {
            welcomePage1.employee = false;
            if (!log1.log && !log1.Visible && log1.role == 0)
            {
                welcomePage1.Show();
                welcomePage1.BringToFront();
            }
            if (log1.log && !log1.Visible && log1.role == 1)
            {
                log1.log = false;
                adminScreen1.Show();
                adminScreen1.BringToFront();
                log1.role = 0;
            }
            if (log1.log && !log1.Visible && log1.role == 2)
            {
                log1.log = false;
                EmployeeScreen employeeScreen1 = new EmployeeScreen();
                this.Controls.Add(employeeScreen1);
                employeeScreen1.Location = new Point(0, 0);
                employeeScreen1.Show();
                employeeScreen1.BringToFront();
                welcomePage1.employee = false;
                employeeScreen1.LoadProducts();
                employeeScreen1.LoadOrders();
                employeeScreen1.WriteOrders();
                employeeScreen1.VisibleChanged += new System.EventHandler(employeeScreen1_VisibleChanged);
                log1.role = 0;
            }
        }

        private void adminScreen1_VisibleChanged(object sender, EventArgs e)
        {
            if (!adminScreen1.Visible)
            {
                welcomePage1.employee = false;
                welcomePage1.Show();
                welcomePage1.BringToFront();
            }
        }
    }
    public class ProductInfo
    {
        public string name;
        public decimal price;
        public int count;
        public string imagePath;

        public ProductInfo(string n, decimal p, int c, string ip)
        {
            this.name = n;
            this.price = p;
            this.count = c;
            this.imagePath = ip;
        }
    }
}