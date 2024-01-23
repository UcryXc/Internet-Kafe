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
    public partial class YeniKullaniciFrm : Form
    {
        public YeniKullaniciFrm()
        {
            InitializeComponent();
        }
        void VerileriGoster()
        {
            using (SqlConnection con = new SqlConnection("Data Source=GÖKTUNÇ;Initial Catalog=CafeDB;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select *from login", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void verileriGosterBtn_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=GÖKTUNÇ;Initial Catalog=CafeDB;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO login (username, password) VALUES (@username, @password)", con);
                cmd.Parameters.AddWithValue("@username", kullaniciTxtBox.Text);
                cmd.Parameters.AddWithValue("@password", sifreTxtBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            VerileriGoster();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=GÖKTUNÇ;Initial Catalog=CafeDB;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM login WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@username", kullaniciTxtBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            VerileriGoster();
        }
    }

}
