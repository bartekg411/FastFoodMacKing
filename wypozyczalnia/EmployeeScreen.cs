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
    public partial class EmployeeScreen : UserControl
    {
        Dictionary<int, string> Products = new Dictionary<int, string>();
        List<Order> Orders = new List<Order>();
        public EmployeeScreen()
        {
            InitializeComponent();
        }
        public void LoadOrders()
        {
            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "select * from Zamowienia where Zrealizowano = 0 Order  by Data, Godzina";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Orders.Add(new Order(dr.GetInt32(0), dr.GetDateTime(1).ToString(), dr.GetTimeSpan(2).ToString(), dr.GetBoolean(3), dr.GetBoolean(4) ));
                }
            }
            dr.Close();

            query = "select sz.ZamowienieID, sz.ProduktID, sz.Ilosc, sz.Przygotowane from SzczegolyZamowienia sz, Zamowienia z Where z.Zrealizowano = 0 AND z.ID=sz.ZamowienieID";
            sqlCommand = new SqlCommand(query, conn);

            dr = sqlCommand.ExecuteReader();

            List<OrderDetails> tmp = new List<OrderDetails>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    tmp.Add(new OrderDetails(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetBoolean(3) ));
                }
            }

            dr.Close();
            conn.Close();

            foreach(Order a in Orders)
            {
                foreach(OrderDetails b in tmp)
                {
                    if(a.id == b.zamowienieId)
                    {
                        a.details.Add(b);
                    }
                }
            }
            tmp.Clear();
        }
        public void WriteOrders()
        {
            int width = 20;
            int height = 20;

            CustomButton close = new CustomButton();
            close.BackColor = Color.FromArgb(167, 4, 4);
            close.BorderRadius = 25;
            close.Location = new Point(1850, 5);
            close.Size = new Size(50, 50);
            close.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
            close.ForeColor = Color.White;
            close.Text = "X";
            close.Click += new System.EventHandler(closePanel);
            this.Controls.Add(close);
            close.BringToFront();

            foreach (Order a in Orders) 
            {
                Panel order = new Panel();
                //order.AutoScroll = true;
                order.Size = new System.Drawing.Size(600, 700);
                order.Location = new System.Drawing.Point(width, height);
                order.Name = a.id.ToString();
                order.BackColor = System.Drawing.Color.FromArgb(167,4,4);
                order.BorderStyle = BorderStyle.FixedSingle;

                Label name = new Label();
                name.Text = "Nr.zamówienia: " + a.id.ToString();
                name.Location = new System.Drawing.Point(10, 10);
                name.Size = new System.Drawing.Size(580, 50);
                name.TextAlign = ContentAlignment.MiddleLeft;
                name.Font = new Font("Microsoft Sans Serif", 24);
                name.ForeColor=Color.White;
                order.Controls.Add(name);


                Panel orderdetails = new Panel();
                orderdetails.AutoScroll = true;
                orderdetails.Size = new System.Drawing.Size(580, 550);
                orderdetails.Location = new System.Drawing.Point(10, 70);
                orderdetails.BackColor = System.Drawing.Color.FromArgb(167, 4, 4);

                int widthOD = 10;
                int hightOD = 10;

                foreach(OrderDetails b in a.details)
                {
                    
                       CustomButton orderdetailsitem = new CustomButton();

                        orderdetailsitem.Size = new System.Drawing.Size(550, 60);
                        orderdetailsitem.Location = new System.Drawing.Point(widthOD, hightOD);
                        orderdetailsitem.Name = b.productId.ToString();
                        orderdetailsitem.Click += new System.EventHandler(CompleteProduct);
                   
                    
                        orderdetailsitem.Text = Products[b.productId] + " x " + b.count.ToString();             
                                  
                        if(b.completed)
                        {
                            orderdetailsitem.Font = new Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Strikeout);
                            orderdetailsitem.ForeColor = Color.Gray;
                            orderdetailsitem.BackColor = Color.LightGray;
                        }
                        else
                        {
                            orderdetailsitem.Font = new Font("Microsoft Sans Serif", 14);
                            orderdetailsitem.ForeColor = Color.Black;
                            orderdetailsitem.BackColor = Color.FromArgb(255, 242, 223);
                        }

                        orderdetails.Controls.Add(orderdetailsitem);

                        hightOD += 70;
                }
                order.Controls.Add(orderdetails);

                CustomButton orderReady = new CustomButton();
                orderReady.Text = "Zamówienie gotowe";
                orderReady.Size = new System.Drawing.Size(300, 60);
                orderReady.Location = new System.Drawing.Point(290, 630);
                orderReady.Name = "ButtonOrderReady";
                orderReady.Click += new System.EventHandler(ConfirmCompleteOrder);
                orderReady.Font = new Font("Microsoft Sans Serif", 18);

                int i = 0;
                foreach (CustomButton b in orderdetails.Controls)
                {
                    if (b.ForeColor == Color.Gray)
                    {
                        i++;
                    }
                }
                if (orderdetails.Controls.Count == i)
                {
                    orderReady.Enabled = true;
                    orderReady.BackColor = System.Drawing.Color.Green;
                    orderReady.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    orderReady.Enabled = false;
                    orderReady.BackColor = System.Drawing.Color.Gray;
                    orderReady.ForeColor = System.Drawing.Color.Black;
                }

                order.Controls.Add(orderReady);

                panel1.Controls.Add(order);
                
                if (width > 1240)
                {
                    width -= 1240;
                    height += 720;
                }
                else
                {
                    width += 620;
                }
            }
        }
        void CompleteProduct(object sender, EventArgs e)
        {
            if(!(((CustomButton)sender).ForeColor == Color.Gray))
            {
                ((CustomButton)sender).Font = new Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Strikeout);
                ((CustomButton)sender).ForeColor = Color.Gray;
                ((CustomButton)sender).BackColor = Color.LightGray;

                string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                string query = $"UPDATE SzczegolyZamowienia Set przygotowane = 1 Where ZamowienieID = {Int32.Parse(((CustomButton)sender).Parent.Parent.Name)} AND ProduktID = {Int32.Parse(((CustomButton)sender).Name)}";
                SqlCommand sqlCommand = new SqlCommand(query, conn);

                sqlCommand.ExecuteScalar();

                conn.Close();
            }
            else
            {
                ((CustomButton)sender).Font = new Font("Microsoft Sans Serif", 14);
                ((CustomButton)sender).ForeColor = Color.Black;
                ((CustomButton)sender).BackColor = Color.FromArgb(255,242,223);

                string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";//DESKTOP-UC6HTH1
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                string query = $"UPDATE SzczegolyZamowienia Set przygotowane = 0 Where ZamowienieID = {Int32.Parse(((CustomButton)sender).Parent.Parent.Name)} AND ProduktID = {Int32.Parse(((CustomButton)sender).Name)}";
                SqlCommand sqlCommand = new SqlCommand(query, conn);

                sqlCommand.ExecuteScalar();

                conn.Close();

            }
            int i = 0;
            foreach(CustomButton a in ((CustomButton)sender).Parent.Controls)
            {
                if(a.ForeColor == Color.Gray)
                {
                    i++;
                }
            }
            if(((CustomButton)sender).Parent.Controls.Count == i)
            {
                ((CustomButton)sender).Parent.Parent.Controls.Find("ButtonOrderReady", true)[0].Enabled=true;
                ((CustomButton)sender).Parent.Parent.Controls.Find("ButtonOrderReady", true)[0].BackColor = System.Drawing.Color.Green;
                ((CustomButton)sender).Parent.Parent.Controls.Find("ButtonOrderReady", true)[0].ForeColor = System.Drawing.Color.White;
            }
            else
            {
                ((CustomButton)sender).Parent.Parent.Controls.Find("ButtonOrderReady", true)[0].Enabled = false;
                ((CustomButton)sender).Parent.Parent.Controls.Find("ButtonOrderReady", true)[0].BackColor = System.Drawing.Color.Gray;
                ((CustomButton)sender).Parent.Parent.Controls.Find("ButtonOrderReady", true)[0].ForeColor = System.Drawing.Color.Black;
            }
        }
        void ConfirmCompleteOrder(object sender, EventArgs e)
        {

            Panel message = new Panel();
            //order.AutoScroll = true;
            message.Size = new System.Drawing.Size(700, 500);
            message.Location = new System.Drawing.Point(610, 150);
            message.Name = "ConfirmPage";
            message.BackColor = System.Drawing.Color.FromArgb(255, 242, 223);
            message.BorderStyle = BorderStyle.FixedSingle;

            Label tile = new Label();
            tile.Text = "Czy jesteś pewny?";
            tile.Location = new System.Drawing.Point(200, 100);
            tile.Size = new System.Drawing.Size(300, 50);
            tile.TextAlign = ContentAlignment.MiddleCenter;
            tile.Font = new Font("Microsoft Sans Serif", 24);
            tile.AutoSize = false;
            tile.ForeColor = Color.Black;
            message.Controls.Add(tile);

            CustomButton cancle = new CustomButton();
            cancle.Text = "Anuluj";
            cancle.Size = new System.Drawing.Size(200, 60);
            cancle.Location = new System.Drawing.Point(100, 420);
            cancle.Name = ((CustomButton)sender).Parent.Name;
            cancle.BackColor = System.Drawing.Color.Red;
            cancle.Click += new System.EventHandler(CancelConfirmCompleteOrder);
            cancle.Font = new Font("Microsoft Sans Serif", 18);
            cancle.ForeColor = Color.Black;
            message.Controls.Add(cancle);

            CustomButton confirm = new CustomButton();
            confirm.Text = "Potwierdz";
            confirm.Size = new System.Drawing.Size(200, 60);
            confirm.Location = new System.Drawing.Point(400, 420);
            confirm.Name = ((CustomButton)sender).Parent.Name;
            confirm.BackColor = System.Drawing.Color.Green;
            confirm.Click += new System.EventHandler(CompleteOrder);
            confirm.Font = new Font("Microsoft Sans Serif", 18);
            confirm.ForeColor = Color.Black;
            message.Controls.Add(confirm);

            this.Controls.Add(message);
            message.BringToFront();
        }
        void CancelConfirmCompleteOrder(object sender, EventArgs e)
        {
            this.Controls.Remove(((CustomButton)sender).Parent);
        }
        void CompleteOrder(object sender, EventArgs e)
        {
            CancelConfirmCompleteOrder(sender, e);

            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";//DESKTOP-UC6HTH1 // DESKTOP-UC6HTH1
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = $"UPDATE Zamowienia SET Zrealizowano = 1 WHERE Zamowienia.ID={Int32.Parse(((CustomButton)sender).Name)}";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            sqlCommand.ExecuteScalar();

            conn.Close();
            this.panel1.Controls.Clear();
            Orders.Clear();
            LoadOrders();
            WriteOrders();
        }
        public void LoadProducts()
        {
            Products.Clear();
            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "select ID, Nazwa from Menu";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Products.Add(dr.GetInt32(0), dr.GetString(1));
                }
            }
            dr.Close();
            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            
        }
        void closePanel(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Remove(this);
        }
    }
    class OrderDetails
    {
        public int zamowienieId;
        public int productId;
        public int count;
        public bool completed;
        public OrderDetails(int z, int p, int c, bool cp)
        {
            this.zamowienieId = z;
            this.productId = p;
            this.count = c;
            this.completed = cp;
        }
    }
    class Order
    {
        public int id;
        string date;
        string hour;
        bool takeOut;
        bool completed;
        public List<OrderDetails> details = new List<OrderDetails>();
        public Order(int i, string d, string h, bool t, bool c) 
        {
            this.id = i;
            this.date = d;
            this.hour = h;
            this.takeOut = t;
            this.completed = c;
        }
    }

}
