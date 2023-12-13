namespace CELIKOOR_PINKMAN
{
    partial class FormLihatFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLihatFilm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGarisJudul = new System.Windows.Forms.Panel();
            this.labelJudul = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLihatFilm = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAktor = new System.Windows.Forms.Label();
            this.comboBoxAktor = new System.Windows.Forms.ComboBox();
            this.labelCariBerdasarkan = new System.Windows.Forms.Label();
            this.buttonCari = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelJam = new System.Windows.Forms.Label();
            this.comboBoxJam = new System.Windows.Forms.ComboBox();
            this.labelStudio = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 393);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(468, 194);
            this.dataGridView1.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.labelStudio);
            this.panel1.Controls.Add(this.comboBoxJam);
            this.panel1.Controls.Add(this.labelJam);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelTanggal);
            this.panel1.Controls.Add(this.comboBoxGenre);
            this.panel1.Controls.Add(this.labelGenre);
            this.panel1.Controls.Add(this.labelAktor);
            this.panel1.Controls.Add(this.comboBoxAktor);
            this.panel1.Controls.Add(this.labelCariBerdasarkan);
            this.panel1.Location = new System.Drawing.Point(4, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 242);
            this.panel1.TabIndex = 70;
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonHapus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.Location = new System.Drawing.Point(374, 605);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(111, 37);
            this.buttonHapus.TabIndex = 87;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panelGarisJudul);
            this.panel2.Controls.Add(this.labelJudul);
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Controls.Add(this.labelLihatFilm);
            this.panel2.Location = new System.Drawing.Point(-23, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 140);
            this.panel2.TabIndex = 88;
            // 
            // panelGarisJudul
            // 
            this.panelGarisJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelGarisJudul.Location = new System.Drawing.Point(208, 49);
            this.panelGarisJudul.Name = "panelGarisJudul";
            this.panelGarisJudul.Size = new System.Drawing.Size(275, 10);
            this.panelGarisJudul.TabIndex = 74;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelJudul.Location = new System.Drawing.Point(183, 8);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(325, 38);
            this.labelJudul.TabIndex = 73;
            this.labelJudul.Text = "CELIKOOR 21 CINEPLEX";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(29, 14);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(127, 114);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 71;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelLihatFilm
            // 
            this.labelLihatFilm.AutoSize = true;
            this.labelLihatFilm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLihatFilm.ForeColor = System.Drawing.Color.White;
            this.labelLihatFilm.Location = new System.Drawing.Point(245, 73);
            this.labelLihatFilm.Name = "labelLihatFilm";
            this.labelLihatFilm.Size = new System.Drawing.Size(197, 45);
            this.labelLihatFilm.TabIndex = 72;
            this.labelLihatFilm.Text = "LIHAT FILM";
            this.labelLihatFilm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(20, 88);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(73, 25);
            this.labelGenre.TabIndex = 12;
            this.labelGenre.Text = "Genre :";
            // 
            // labelAktor
            // 
            this.labelAktor.AutoSize = true;
            this.labelAktor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAktor.Location = new System.Drawing.Point(20, 51);
            this.labelAktor.Name = "labelAktor";
            this.labelAktor.Size = new System.Drawing.Size(70, 25);
            this.labelAktor.TabIndex = 11;
            this.labelAktor.Text = "Aktor :";
            // 
            // comboBoxAktor
            // 
            this.comboBoxAktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAktor.FormattingEnabled = true;
            this.comboBoxAktor.Items.AddRange(new object[] {
            "ID",
            "Nama",
            "Negara Asal"});
            this.comboBoxAktor.Location = new System.Drawing.Point(125, 52);
            this.comboBoxAktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAktor.Name = "comboBoxAktor";
            this.comboBoxAktor.Size = new System.Drawing.Size(227, 24);
            this.comboBoxAktor.TabIndex = 9;
            // 
            // labelCariBerdasarkan
            // 
            this.labelCariBerdasarkan.AutoSize = true;
            this.labelCariBerdasarkan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariBerdasarkan.Location = new System.Drawing.Point(20, 16);
            this.labelCariBerdasarkan.Name = "labelCariBerdasarkan";
            this.labelCariBerdasarkan.Size = new System.Drawing.Size(171, 25);
            this.labelCariBerdasarkan.TabIndex = 8;
            this.labelCariBerdasarkan.Text = "Cari Berdasarkan : ";
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCari.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.White;
            this.buttonCari.Location = new System.Drawing.Point(13, 605);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(111, 37);
            this.buttonCari.TabIndex = 89;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "ID",
            "Nama",
            "Negara Asal"});
            this.comboBoxGenre.Location = new System.Drawing.Point(125, 89);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(227, 24);
            this.comboBoxGenre.TabIndex = 13;
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(20, 128);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(89, 25);
            this.labelTanggal.TabIndex = 14;
            this.labelTanggal.Text = "Tanggal :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // labelJam
            // 
            this.labelJam.AutoSize = true;
            this.labelJam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJam.Location = new System.Drawing.Point(20, 167);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(56, 25);
            this.labelJam.TabIndex = 17;
            this.labelJam.Text = "Jam :";
            // 
            // comboBoxJam
            // 
            this.comboBoxJam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJam.FormattingEnabled = true;
            this.comboBoxJam.Items.AddRange(new object[] {
            "ID",
            "Nama",
            "Negara Asal"});
            this.comboBoxJam.Location = new System.Drawing.Point(125, 171);
            this.comboBoxJam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJam.Name = "comboBoxJam";
            this.comboBoxJam.Size = new System.Drawing.Size(160, 24);
            this.comboBoxJam.TabIndex = 18;
            // 
            // labelStudio
            // 
            this.labelStudio.AutoSize = true;
            this.labelStudio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudio.Location = new System.Drawing.Point(20, 205);
            this.labelStudio.Name = "labelStudio";
            this.labelStudio.Size = new System.Drawing.Size(77, 25);
            this.labelStudio.TabIndex = 19;
            this.labelStudio.Text = "Studio :";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID",
            "Nama",
            "Negara Asal"});
            this.comboBox2.Location = new System.Drawing.Point(125, 209);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 20;
            // 
            // FormLihatFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 647);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormLihatFilm";
            this.Text = "Lihat Film";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelGarisJudul;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLihatFilm;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAktor;
        private System.Windows.Forms.ComboBox comboBoxAktor;
        private System.Windows.Forms.Label labelCariBerdasarkan;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label labelStudio;
        private System.Windows.Forms.ComboBox comboBoxJam;
        private System.Windows.Forms.Label labelJam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}