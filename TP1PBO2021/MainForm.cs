using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class MainForm : Form
    {
        User pengguna;
        Barang[] arrBarang = new Barang[6];

        public MainForm(User org)
        {
            InitializeComponent();
            this.pengguna = org;
        }   

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbNIM.Text = Convert.ToString(this.pengguna.nim);
            lbNama.Text = Convert.ToString(this.pengguna.nama);

            this.arrBarang[0] = new Barang("Speaker", 250000, "Elektronik", "");
            this.arrBarang[1] = new Barang("T-shirt Deus", 100000, "Baju", "");
            this.arrBarang[2] = new Barang("Nasi Goreng", 300000, "Makanan", "");
            this.arrBarang[3] = new Barang("Kemeja Ganteng", 150000, "Baju", "");
            this.arrBarang[4] = new Barang("Keyboard", 450000, "Elektronik","");
            this.arrBarang[5] = new Barang("Airpods Pro", 900000, "Elektronik","");

            HomePanel hp = new HomePanel(this.arrBarang);
            hp.Dock = DockStyle.Fill;
            panelFill.Controls.Add(hp);
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start("http://www.tokopedia.com");
        }

        private void catalogIcon_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void webCatalog_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }
    }
}
