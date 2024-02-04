using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalnia
{
    public partial class Log : UserControl
    {
        public bool log = false;
        public int role = 0;
        public Log()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            if(Login.Text == "" || Password.Text == "")
            {
                return;
            }

            Console.WriteLine($"Login = '{Login.Text}' AND Haslo = '{Password.Text}'");

            string connection = "Data Source=DESKTOP-UC6HTH1\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = $"SELECT Rola FROM Uzytkownicy Where Login = '{Login.Text}' AND Haslo = '{Password.Text}'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    role = dr.GetInt32(0);
                    log = true;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Nie prawidłowe dane!");
            }

            Login.Text = "";
            Password.Text = "";

            dr.Close();
            conn.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Login.Text = "Admin";
            Password.Text = "Admin";
            ButtonLog_Click(sender, e);
        }
    }
}
