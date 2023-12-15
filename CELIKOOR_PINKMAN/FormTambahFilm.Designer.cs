namespace CELIKOOR_PINKMAN
{
    partial class FormTambahFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahFilm));
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.textBoxBahasa = new System.Windows.Forms.TextBox();
            this.labelBahasa = new System.Windows.Forms.Label();
            this.labelTahun = new System.Windows.Forms.Label();
            this.textBoxSinopsis = new System.Windows.Forms.TextBox();
            this.labelSinopsis = new System.Windows.Forms.Label();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.textBoxDurasi = new System.Windows.Forms.TextBox();
            this.labelDurasi = new System.Windows.Forms.Label();
            this.radioButtonSUBINDO = new System.Windows.Forms.RadioButton();
            this.radioButtonLAiN = new System.Windows.Forms.RadioButton();
            this.labelSubs = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelKelompok = new System.Windows.Forms.Label();
            this.comboBoxKelompok = new System.Windows.Forms.ComboBox();
            this.labelCover = new System.Windows.Forms.Label();
            this.textBoxCover = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panelGarisJudul = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTambahFilm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSimpan.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(67, 748);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(116, 46);
            this.buttonSimpan.TabIndex = 87;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonKeluar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(329, 748);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(116, 46);
            this.buttonKeluar.TabIndex = 86;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // textBoxBahasa
            // 
            this.textBoxBahasa.Location = new System.Drawing.Point(167, 423);
            this.textBoxBahasa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBahasa.Name = "textBoxBahasa";
            this.textBoxBahasa.Size = new System.Drawing.Size(239, 22);
            this.textBoxBahasa.TabIndex = 85;
            // 
            // labelBahasa
            // 
            this.labelBahasa.AutoSize = true;
            this.labelBahasa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBahasa.Location = new System.Drawing.Point(41, 423);
            this.labelBahasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBahasa.Name = "labelBahasa";
            this.labelBahasa.Size = new System.Drawing.Size(83, 25);
            this.labelBahasa.TabIndex = 84;
            this.labelBahasa.Text = "Bahasa :";
            // 
            // labelTahun
            // 
            this.labelTahun.AutoSize = true;
            this.labelTahun.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTahun.Location = new System.Drawing.Point(41, 288);
            this.labelTahun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTahun.Name = "labelTahun";
            this.labelTahun.Size = new System.Drawing.Size(74, 25);
            this.labelTahun.TabIndex = 83;
            this.labelTahun.Text = "Tahun :";
            // 
            // textBoxSinopsis
            // 
            this.textBoxSinopsis.Location = new System.Drawing.Point(167, 211);
            this.textBoxSinopsis.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSinopsis.Multiline = true;
            this.textBoxSinopsis.Name = "textBoxSinopsis";
            this.textBoxSinopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSinopsis.Size = new System.Drawing.Size(239, 58);
            this.textBoxSinopsis.TabIndex = 82;
            // 
            // labelSinopsis
            // 
            this.labelSinopsis.AutoSize = true;
            this.labelSinopsis.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinopsis.Location = new System.Drawing.Point(41, 223);
            this.labelSinopsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinopsis.Name = "labelSinopsis";
            this.labelSinopsis.Size = new System.Drawing.Size(91, 25);
            this.labelSinopsis.TabIndex = 81;
            this.labelSinopsis.Text = "Sinopsis :";
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Location = new System.Drawing.Point(167, 170);
            this.textBoxJudul.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(239, 22);
            this.textBoxJudul.TabIndex = 80;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(41, 170);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(68, 25);
            this.labelJudul.TabIndex = 79;
            this.labelJudul.Text = "Judul :";
            // 
            // textBoxDurasi
            // 
            this.textBoxDurasi.Location = new System.Drawing.Point(167, 335);
            this.textBoxDurasi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDurasi.Name = "textBoxDurasi";
            this.textBoxDurasi.Size = new System.Drawing.Size(239, 22);
            this.textBoxDurasi.TabIndex = 92;
            // 
            // labelDurasi
            // 
            this.labelDurasi.AutoSize = true;
            this.labelDurasi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurasi.Location = new System.Drawing.Point(41, 335);
            this.labelDurasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDurasi.Name = "labelDurasi";
            this.labelDurasi.Size = new System.Drawing.Size(76, 25);
            this.labelDurasi.TabIndex = 91;
            this.labelDurasi.Text = "Durasi :";
            // 
            // radioButtonSUBINDO
            // 
            this.radioButtonSUBINDO.AutoSize = true;
            this.radioButtonSUBINDO.Location = new System.Drawing.Point(167, 475);
            this.radioButtonSUBINDO.Name = "radioButtonSUBINDO";
            this.radioButtonSUBINDO.Size = new System.Drawing.Size(137, 20);
            this.radioButtonSUBINDO.TabIndex = 93;
            this.radioButtonSUBINDO.TabStop = true;
            this.radioButtonSUBINDO.Text = "Bahasa Indonesia";
            this.radioButtonSUBINDO.UseVisualStyleBackColor = true;
            // 
            // radioButtonLAiN
            // 
            this.radioButtonLAiN.AutoSize = true;
            this.radioButtonLAiN.Location = new System.Drawing.Point(329, 475);
            this.radioButtonLAiN.Name = "radioButtonLAiN";
            this.radioButtonLAiN.Size = new System.Drawing.Size(75, 20);
            this.radioButtonLAiN.TabIndex = 94;
            this.radioButtonLAiN.TabStop = true;
            this.radioButtonLAiN.Text = "Lainnya";
            this.radioButtonLAiN.UseVisualStyleBackColor = true;
            // 
            // labelSubs
            // 
            this.labelSubs.AutoSize = true;
            this.labelSubs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubs.Location = new System.Drawing.Point(41, 470);
            this.labelSubs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubs.Name = "labelSubs";
            this.labelSubs.Size = new System.Drawing.Size(88, 25);
            this.labelSubs.TabIndex = 95;
            this.labelSubs.Text = "Subtitle :";
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Location = new System.Drawing.Point(167, 568);
            this.textBoxDiskon.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(118, 22);
            this.textBoxDiskon.TabIndex = 97;
            // 
            // labelDiskon
            // 
            this.labelDiskon.AutoSize = true;
            this.labelDiskon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskon.Location = new System.Drawing.Point(41, 565);
            this.labelDiskon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(80, 25);
            this.labelDiskon.TabIndex = 96;
            this.labelDiskon.Text = "Diskon :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(167, 290);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 22);
            this.numericUpDown1.TabIndex = 98;
            this.numericUpDown1.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // labelKelompok
            // 
            this.labelKelompok.AutoSize = true;
            this.labelKelompok.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelompok.Location = new System.Drawing.Point(41, 379);
            this.labelKelompok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKelompok.Name = "labelKelompok";
            this.labelKelompok.Size = new System.Drawing.Size(108, 25);
            this.labelKelompok.TabIndex = 99;
            this.labelKelompok.Text = "Kelompok :";
            // 
            // comboBoxKelompok
            // 
            this.comboBoxKelompok.FormattingEnabled = true;
            this.comboBoxKelompok.Location = new System.Drawing.Point(167, 379);
            this.comboBoxKelompok.Name = "comboBoxKelompok";
            this.comboBoxKelompok.Size = new System.Drawing.Size(151, 24);
            this.comboBoxKelompok.TabIndex = 100;
            // 
            // labelCover
            // 
            this.labelCover.AutoSize = true;
            this.labelCover.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCover.Location = new System.Drawing.Point(41, 520);
            this.labelCover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(71, 25);
            this.labelCover.TabIndex = 101;
            this.labelCover.Text = "Cover :";
            // 
            // textBoxCover
            // 
            this.textBoxCover.Location = new System.Drawing.Point(167, 524);
            this.textBoxCover.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCover.Name = "textBoxCover";
            this.textBoxCover.Size = new System.Drawing.Size(210, 22);
            this.textBoxCover.TabIndex = 102;
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonOpen.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Location = new System.Drawing.Point(384, 518);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(63, 35);
            this.buttonOpen.TabIndex = 103;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            // 
            // panelGarisJudul
            // 
            this.panelGarisJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelGarisJudul.Location = new System.Drawing.Point(192, 46);
            this.panelGarisJudul.Name = "panelGarisJudul";
            this.panelGarisJudul.Size = new System.Drawing.Size(275, 10);
            this.panelGarisJudul.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(167, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 38);
            this.label1.TabIndex = 73;
            this.label1.Text = "CELIKOOR 21 CINEPLEX";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 11);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(127, 114);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 71;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTambahFilm
            // 
            this.labelTambahFilm.AutoSize = true;
            this.labelTambahFilm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahFilm.ForeColor = System.Drawing.Color.White;
            this.labelTambahFilm.Location = new System.Drawing.Point(200, 69);
            this.labelTambahFilm.Name = "labelTambahFilm";
            this.labelTambahFilm.Size = new System.Drawing.Size(246, 45);
            this.labelTambahFilm.TabIndex = 72;
            this.labelTambahFilm.Text = "TAMBAH FILM";
            this.labelTambahFilm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panelGarisJudul);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Controls.Add(this.labelTambahFilm);
            this.panel2.Location = new System.Drawing.Point(-7, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 140);
            this.panel2.TabIndex = 104;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 610);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 610);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 106;
            this.label2.Text = "Genre:";
            // 
            // FormTambahFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 820);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxCover);
            this.Controls.Add(this.labelCover);
            this.Controls.Add(this.comboBoxKelompok);
            this.Controls.Add(this.labelKelompok);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.labelDiskon);
            this.Controls.Add(this.labelSubs);
            this.Controls.Add(this.radioButtonLAiN);
            this.Controls.Add(this.radioButtonSUBINDO);
            this.Controls.Add(this.textBoxDurasi);
            this.Controls.Add(this.labelDurasi);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.textBoxBahasa);
            this.Controls.Add(this.labelBahasa);
            this.Controls.Add(this.labelTahun);
            this.Controls.Add(this.textBoxSinopsis);
            this.Controls.Add(this.labelSinopsis);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormTambahFilm";
            this.Text = "Tambah Film";
            this.Load += new System.EventHandler(this.FormTambahFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.TextBox textBoxBahasa;
        private System.Windows.Forms.Label labelBahasa;
        private System.Windows.Forms.Label labelTahun;
        private System.Windows.Forms.TextBox textBoxSinopsis;
        private System.Windows.Forms.Label labelSinopsis;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox textBoxDurasi;
        private System.Windows.Forms.Label labelDurasi;
        private System.Windows.Forms.RadioButton radioButtonSUBINDO;
        private System.Windows.Forms.RadioButton radioButtonLAiN;
        private System.Windows.Forms.Label labelSubs;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelKelompok;
        private System.Windows.Forms.ComboBox comboBoxKelompok;
        private System.Windows.Forms.Label labelCover;
        private System.Windows.Forms.TextBox textBoxCover;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panelGarisJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTambahFilm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}