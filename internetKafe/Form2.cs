using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace internetKafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniKullaniciBtn_Click(object sender, EventArgs e)
        {
            YeniKullaniciFrm yeniKullaniciFrm = new YeniKullaniciFrm();
            this.Hide();
            yeniKullaniciFrm.Show();

        }
    }
}
