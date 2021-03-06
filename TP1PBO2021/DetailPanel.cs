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
    public partial class DetailPanel : UserControl
    {
        Barang brg;
        public DetailPanel(Barang barang)
        {
            InitializeComponent();
            this.brg = barang;
        }  

        private void DetailPanel_Load(object sender, EventArgs e)
        {
            // foto barang
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(100, 100),
                Image = this.brg.getGambar(),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(388, 87),
                Visible = true
            };
            this.Controls.Add(picture);

            // nama barang
            Label namaBarang = new Label();
            namaBarang.Text = this.brg.nama;
            namaBarang.Location = new Point(400, 189);
            namaBarang.AutoSize = true;
            this.Controls.Add(namaBarang);

            // harga
            Label harga = new Label();
            harga.Text = "Rp." + this.brg.harga;
            harga.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            harga.Location = new Point(399, 209);
            harga.AutoSize = true;
            this.Controls.Add(harga);


            // button Beli
            Button btn = this.brg.makeButton();
            btn.Location = new Point(416, 234);
            this.Controls.Add(btn);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
