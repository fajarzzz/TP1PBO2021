using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace TP1PBO2021
{
    public class Barang
    {
        public string nama { get; set; }
        public int harga { get; set; }
        public string jenis { get; set; }
        public string gambar { get; set; }

        HomePanel temp;

        public Barang() { }

        public Barang(string nama, int harga, string jenis, string gambar) {
            this.nama = nama;
            this.harga = harga;
            this.jenis = jenis;
            this.gambar = gambar;
        }

        public Button makeButton()
        {
            Button btn = new Button();
            btn.Name = "beliButton";
            btn.Click += new System.EventHandler(this.beliButton_Click);
            btn.Text = "Beli";
            btn.Size = new Size(40, 23);
            btn.BackColor = Color.LightGray;
            return btn;
        }
        public void beliButton_Click(object sender, EventArgs e)
        {
            // masuk ke detail
            DetailPanel detail = new DetailPanel(this);
            detail.Dock = DockStyle.Fill;
           // this.temp = detail
            this.temp.Controls.Add(detail); ;
            detail.BringToFront();
        }

        public void setTemp(HomePanel panel)
        {
            this.temp = panel;
        }
    }
}
