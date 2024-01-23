using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace internetKafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=GÖKTUNÇ;Initial Catalog=CafeDB;Integrated Security=True"; // Veritabanı bağlantı bilgilerinizi girin
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "SELECT * FROM login WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@Username", txtKullanici.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtSifre.Text.Trim());
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Form2 form = new Form2();
                    this.Hide();
                    form.Show();
                    MessageBox.Show("Giriş başarılı!");

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
                }
            }
        }

       
    }
}
