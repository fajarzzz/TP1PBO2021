
namespace TP1PBO2021
{
    partial class HomePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jenisBarang = new System.Windows.Forms.ComboBox();
            this.Harga = new System.Windows.Forms.ComboBox();
            this.cariButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.containerItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // jenisBarang
            // 
            this.jenisBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisBarang.FormattingEnabled = true;
            this.jenisBarang.Location = new System.Drawing.Point(25, 51);
            this.jenisBarang.Name = "jenisBarang";
            this.jenisBarang.Size = new System.Drawing.Size(106, 23);
            this.jenisBarang.TabIndex = 0;
            this.jenisBarang.Text = "Jenis Barang";
            // 
            // Harga
            // 
            this.Harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.FormattingEnabled = true;
            this.Harga.Location = new System.Drawing.Point(25, 89);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(106, 23);
            this.Harga.TabIndex = 1;
            this.Harga.Text = "Harga";
            // 
            // cariButton
            // 
            this.cariButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cariButton.Location = new System.Drawing.Point(25, 132);
            this.cariButton.Name = "cariButton";
            this.cariButton.Size = new System.Drawing.Size(106, 23);
            this.cariButton.TabIndex = 2;
            this.cariButton.Text = "Cari";
            this.cariButton.UseVisualStyleBackColor = false;
            this.cariButton.Click += new System.EventHandler(this.cariButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semua Barang :";
            // 
            // containerItems
            // 
            this.containerItems.AutoScroll = true;
            this.containerItems.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.containerItems.Location = new System.Drawing.Point(164, 51);
            this.containerItems.Margin = new System.Windows.Forms.Padding(25);
            this.containerItems.Name = "containerItems";
            this.containerItems.Size = new System.Drawing.Size(606, 222);
            this.containerItems.TabIndex = 4;
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.containerItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cariButton);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.jenisBarang);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(798, 437);
            this.Load += new System.EventHandler(this.HomePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox jenisBarang;
        private System.Windows.Forms.ComboBox Harga;
        private System.Windows.Forms.Button cariButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel containerItems;
    }
}
