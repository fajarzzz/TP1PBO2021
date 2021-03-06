
namespace TP1PBO2021
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navbar = new System.Windows.Forms.Panel();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.catalogIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbNIM = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.webCatalog = new System.Windows.Forms.Label();
            this.lbHome = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelFill = new System.Windows.Forms.Panel();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.navbar.Controls.Add(this.LogoutIcon);
            this.navbar.Controls.Add(this.catalogIcon);
            this.navbar.Controls.Add(this.homeIcon);
            this.navbar.Controls.Add(this.lbNama);
            this.navbar.Controls.Add(this.lbNIM);
            this.navbar.Controls.Add(this.Logout);
            this.navbar.Controls.Add(this.webCatalog);
            this.navbar.Controls.Add(this.lbHome);
            this.navbar.Controls.Add(this.Logo);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(798, 100);
            this.navbar.TabIndex = 0;
            // 
            // LogoutIcon
            // 
            this.LogoutIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoutIcon.Image = global::TP1PBO2021.Properties.Resources.logout;
            this.LogoutIcon.Location = new System.Drawing.Point(414, 47);
            this.LogoutIcon.Name = "LogoutIcon";
            this.LogoutIcon.Size = new System.Drawing.Size(23, 20);
            this.LogoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoutIcon.TabIndex = 13;
            this.LogoutIcon.TabStop = false;
            this.LogoutIcon.Click += new System.EventHandler(this.LogoutIcon_Click);
            // 
            // catalogIcon
            // 
            this.catalogIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.catalogIcon.Image = global::TP1PBO2021.Properties.Resources.catalog;
            this.catalogIcon.Location = new System.Drawing.Point(256, 46);
            this.catalogIcon.Name = "catalogIcon";
            this.catalogIcon.Size = new System.Drawing.Size(23, 20);
            this.catalogIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catalogIcon.TabIndex = 12;
            this.catalogIcon.TabStop = false;
            this.catalogIcon.Click += new System.EventHandler(this.catalogIcon_Click);
            // 
            // homeIcon
            // 
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeIcon.Image = global::TP1PBO2021.Properties.Resources.home;
            this.homeIcon.Location = new System.Drawing.Point(125, 44);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(33, 25);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeIcon.TabIndex = 11;
            this.homeIcon.TabStop = false;
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNama.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(599, 55);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(45, 16);
            this.lbNama.TabIndex = 10;
            this.lbNama.Text = "Nama";
            // 
            // lbNIM
            // 
            this.lbNIM.AutoSize = true;
            this.lbNIM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNIM.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNIM.Location = new System.Drawing.Point(599, 30);
            this.lbNIM.Name = "lbNIM";
            this.lbNIM.Size = new System.Drawing.Size(35, 16);
            this.lbNIM.TabIndex = 9;
            this.lbNIM.Text = "NIM";
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(439, 48);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(52, 17);
            this.Logout.TabIndex = 8;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // webCatalog
            // 
            this.webCatalog.AutoSize = true;
            this.webCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webCatalog.Location = new System.Drawing.Point(285, 47);
            this.webCatalog.Name = "webCatalog";
            this.webCatalog.Size = new System.Drawing.Size(89, 17);
            this.webCatalog.TabIndex = 7;
            this.webCatalog.Text = "Web Catalog";
            this.webCatalog.Click += new System.EventHandler(this.webCatalog_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHome.Location = new System.Drawing.Point(154, 48);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(45, 17);
            this.lbHome.TabIndex = 6;
            this.lbHome.Text = "Home";
            // 
            // Logo
            // 
            this.Logo.Image = global::TP1PBO2021.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(97, 76);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 100);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(798, 341);
            this.panelFill.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 441);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.navbar);
            this.Name = "MainForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbNIM;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label webCatalog;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.PictureBox catalogIcon;
    }
}