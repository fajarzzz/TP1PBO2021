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
    public partial class LoginForm : Form
    {
        User pengguna;
        public LoginForm()
        {
            InitializeComponent();
            this.pengguna = new User();
            // The password character is an asterisk.
            tbPassword.PasswordChar = '*';

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            pengguna.username = Convert.ToString(tbUser.Text);
            pengguna.password = Convert.ToString(tbPassword.Text);
            pengguna.nama = "Fajar Zuliansyah Trihutama";
            pengguna.nim = "1905394";
            
            if(!String.Equals(this.pengguna.password, "pbo123"))
            {
                MessageBox.Show("Incorrect Password, Please try again", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                MainForm NextForm = new MainForm(this.pengguna);
                this.Hide();
                NextForm.ShowDialog();
                this.Close();
            }


        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if(tbPassword.PasswordChar == '*')
            {
                tbPassword.PasswordChar = '\0';
            } else
            {
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
