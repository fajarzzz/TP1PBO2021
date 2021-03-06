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
    public partial class HomePanel : UserControl
    {
        Barang[] brg;
        FlowLayoutPanel[] komponen;
        private bool status = false;
        private bool check = true;

        public HomePanel(Barang[] brg)
        {
            InitializeComponent();
            this.brg = brg;
            this.komponen = new FlowLayoutPanel[brg.Length];
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            showBarang(this.brg,"Jenis Barang","Harga");

            jenisBarang.Items.Add("Elektronik");
            jenisBarang.Items.Add("Makanan");
            jenisBarang.Items.Add("Baju");

            Harga.Items.Add("100rb - 200rb");
            Harga.Items.Add("200rb - 500rb");
            Harga.Items.Add("500rb - 1jt");
        }

        private bool Filtering(string jenis, int harga,string syaratJenis, string syaratHarga)
        {
            bool check = false;
            if (jenis.Equals(syaratJenis) || syaratJenis.Equals("Jenis Barang"))
            {
                check = true;
            }

            if (check)
            {
                if (syaratHarga.Equals("100rb - 200rb"))
                {
                    if (harga >= 100000 && harga < 200000)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                else if (syaratHarga.Equals("200rb - 500rb"))
                {
                    if (harga >= 200000 && harga < 500000)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                else if (syaratHarga.Equals("500rb - 1jt"))
                {
                    if (harga >= 500000 && harga < 1000000)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                } 
            }
            return check;
        }

        private void showBarang(Barang[] arrBarang, string syaratJenis, string syaratHarga)
        {
            Button[] beli = new Button[arrBarang.Length];
            int i = 0;
            foreach(Barang item in arrBarang)
            {
                if (item != null)
                {
                    if (this.status)
                    {
                        check = Filtering(item.jenis, item.harga, syaratJenis, syaratHarga);
                    }

                    if (check)
                    {
                        komponen[i] = new FlowLayoutPanel();
                        komponen[i].Name = "komponen" + i;
                        komponen[i].AutoSize = true;
                        komponen[i].FlowDirection = FlowDirection.TopDown;
                        komponen[i].Margin = new Padding(32);
                        komponen[i].Padding = new Padding(10);
                        komponen[i].BorderStyle = BorderStyle.Fixed3D;

                        // foto barang
                        PictureBox picture = new PictureBox
                        {
                            Name = "pictureBox" + i,
                            Size = new Size(100, 100),
                            Image = item.getGambar(),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Visible = true
                        };
                        komponen[i].Controls.Add(picture);

                        // nama barang
                        Label namaBarang = new Label();
                        namaBarang.Text = item.nama;
                        namaBarang.AutoSize = true;
                        komponen[i].Controls.Add(namaBarang);

                        // harga
                        Label harga = new Label();
                        harga.Text = "Rp." + item.harga;
                        harga.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                        harga.AutoSize = true;
                        komponen[i].Controls.Add(harga);


                        // button Beli
                        beli[i] = item.makeButton();
                        komponen[i].Controls.Add(beli[i]);
                        item.setTemp(this);
                        containerItems.Controls.Add(komponen[i]);
                        containerItems.BorderStyle = BorderStyle.Fixed3D;
                        i++;
                    }
                }
            }
        }

        private void cariButton_Click(object sender, EventArgs e)
        {
            // tampilkan barang

            string jenis = Convert.ToString(jenisBarang.Text);
            string range = Convert.ToString(Harga.Text);
            containerItems.Controls.Clear();
            this.status = true;
            showBarang(this.brg, jenis, range);
        }
    }
}
