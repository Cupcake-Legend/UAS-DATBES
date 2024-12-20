﻿namespace CELIKOOR_PINKMAN
{
    partial class FormMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konsumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelompokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pencatatanKedatanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 8);
            this.panel1.TabIndex = 1;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.labelJudul.Location = new System.Drawing.Point(80, 31);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(387, 50);
            this.labelJudul.TabIndex = 2;
            this.labelJudul.Text = "CELIKOOR 21 CINEPLEX";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJudul.UseCompatibleTextRendering = true;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(106, 71);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(349, 20);
            this.labelDescription.TabIndex = 27;
            this.labelDescription.Text = "\"Your Portal to a World of Cinematic Experiences\"";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescription.Click += new System.EventHandler(this.labelDontHaveAnAccount_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.operatorToolStripMenuItem,
            this.kasirToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(455, 24);
            this.menuStrip2.TabIndex = 31;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.filmToolStripMenuItem1,
            this.historyToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // filmToolStripMenuItem1
            // 
            this.filmToolStripMenuItem1.Name = "filmToolStripMenuItem1";
            this.filmToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.filmToolStripMenuItem1.Text = "Film";
            this.filmToolStripMenuItem1.Click += new System.EventHandler(this.filmToolStripMenuItem1_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencatatanKedatanganToolStripMenuItem});
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operatorToolStripMenuItem.Text = "Operator";
            this.operatorToolStripMenuItem.Visible = false;
            // 
            // kasirToolStripMenuItem
            // 
            this.kasirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem1});
            this.kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            this.kasirToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.kasirToolStripMenuItem.Text = "Kasir";
            this.kasirToolStripMenuItem.Visible = false;
            // 
            // invoiceToolStripMenuItem1
            // 
            this.invoiceToolStripMenuItem1.Name = "invoiceToolStripMenuItem1";
            this.invoiceToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.invoiceToolStripMenuItem1.Text = "Invoice";
            this.invoiceToolStripMenuItem1.Click += new System.EventHandler(this.invoiceToolStripMenuItem1_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konsumenToolStripMenuItem,
            this.cinemaToolStripMenuItem,
            this.pegawaiToolStripMenuItem,
            this.kelompokToolStripMenuItem,
            this.aktorToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.studioToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            this.masterToolStripMenuItem.Visible = false;
            // 
            // konsumenToolStripMenuItem
            // 
            this.konsumenToolStripMenuItem.Name = "konsumenToolStripMenuItem";
            this.konsumenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.konsumenToolStripMenuItem.Text = "Konsumen";
            this.konsumenToolStripMenuItem.Click += new System.EventHandler(this.konsumenToolStripMenuItem_Click);
            // 
            // cinemaToolStripMenuItem
            // 
            this.cinemaToolStripMenuItem.Name = "cinemaToolStripMenuItem";
            this.cinemaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cinemaToolStripMenuItem.Text = "Cinema";
            this.cinemaToolStripMenuItem.Click += new System.EventHandler(this.cinemaToolStripMenuItem_Click);
            // 
            // pegawaiToolStripMenuItem
            // 
            this.pegawaiToolStripMenuItem.Name = "pegawaiToolStripMenuItem";
            this.pegawaiToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pegawaiToolStripMenuItem.Text = "Pegawai";
            this.pegawaiToolStripMenuItem.Click += new System.EventHandler(this.pegawaiToolStripMenuItem_Click);
            // 
            // kelompokToolStripMenuItem
            // 
            this.kelompokToolStripMenuItem.Name = "kelompokToolStripMenuItem";
            this.kelompokToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kelompokToolStripMenuItem.Text = "Kelompok";
            this.kelompokToolStripMenuItem.Click += new System.EventHandler(this.kelompokToolStripMenuItem_Click);
            // 
            // aktorToolStripMenuItem
            // 
            this.aktorToolStripMenuItem.Name = "aktorToolStripMenuItem";
            this.aktorToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aktorToolStripMenuItem.Text = "Aktor";
            this.aktorToolStripMenuItem.Click += new System.EventHandler(this.aktorToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jadwalFilmToolStripMenuItem});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.filmToolStripMenuItem.Text = "Film";
            this.filmToolStripMenuItem.Click += new System.EventHandler(this.filmToolStripMenuItem_Click);
            // 
            // jadwalFilmToolStripMenuItem
            // 
            this.jadwalFilmToolStripMenuItem.Name = "jadwalFilmToolStripMenuItem";
            this.jadwalFilmToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.jadwalFilmToolStripMenuItem.Text = "Jadwal Film";
            this.jadwalFilmToolStripMenuItem.Click += new System.EventHandler(this.jadwalFilmToolStripMenuItem_Click);
            // 
            // studioToolStripMenuItem
            // 
            this.studioToolStripMenuItem.Name = "studioToolStripMenuItem";
            this.studioToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.studioToolStripMenuItem.Text = "Studio";
            this.studioToolStripMenuItem.Click += new System.EventHandler(this.studioToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CELIKOOR_PINKMAN.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pencatatanKedatanganToolStripMenuItem
            // 
            this.pencatatanKedatanganToolStripMenuItem.Name = "pencatatanKedatanganToolStripMenuItem";
            this.pencatatanKedatanganToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pencatatanKedatanganToolStripMenuItem.Text = "Pencatatan Kedatangan";
            this.pencatatanKedatanganToolStripMenuItem.Click += new System.EventHandler(this.pencatatanKedatanganToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 463);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelJudul);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konsumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelompokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jadwalFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencatatanKedatanganToolStripMenuItem;
    }
}

