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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxStudio = new System.Windows.Forms.ComboBox();
            this.labelStudio = new System.Windows.Forms.Label();
            this.comboBoxJam = new System.Windows.Forms.ComboBox();
            this.labelJam = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAktor = new System.Windows.Forms.Label();
            this.labelCariBerdasarkan = new System.Windows.Forms.Label();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDaftarFilm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(486, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(646, 387);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBoxStudio);
            this.panel1.Controls.Add(this.labelStudio);
            this.panel1.Controls.Add(this.comboBoxJam);
            this.panel1.Controls.Add(this.labelJam);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelTanggal);
            this.panel1.Controls.Add(this.comboBoxGenre);
            this.panel1.Controls.Add(this.labelGenre);
            this.panel1.Controls.Add(this.labelAktor);
            this.panel1.Controls.Add(this.labelCariBerdasarkan);
            this.panel1.Location = new System.Drawing.Point(4, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 387);
            this.panel1.TabIndex = 70;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(125, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 25);
            this.textBox1.TabIndex = 21;
            // 
            // comboBoxStudio
            // 
            this.comboBoxStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudio.FormattingEnabled = true;
            this.comboBoxStudio.Items.AddRange(new object[] {
            "ID",
            "Nama",
            "Negara Asal"});
            this.comboBoxStudio.Location = new System.Drawing.Point(125, 209);
            this.comboBoxStudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudio.Name = "comboBoxStudio";
            this.comboBoxStudio.Size = new System.Drawing.Size(160, 24);
            this.comboBoxStudio.TabIndex = 20;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 22);
            this.dateTimePicker1.TabIndex = 15;
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
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonHapus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.Location = new System.Drawing.Point(1025, 551);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(111, 37);
            this.buttonHapus.TabIndex = 87;
            this.buttonHapus.Text = "Keluar";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCari.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.White;
            this.buttonCari.Location = new System.Drawing.Point(4, 551);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(111, 37);
            this.buttonCari.TabIndex = 89;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.labelDaftarFilm);
            this.panel3.Location = new System.Drawing.Point(4, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 140);
            this.panel3.TabIndex = 90;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(439, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 10);
            this.panel4.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(414, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 38);
            this.label1.TabIndex = 73;
            this.label1.Text = "CELIKOOR 21 CINEPLEX";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // labelDaftarFilm
            // 
            this.labelDaftarFilm.AutoSize = true;
            this.labelDaftarFilm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarFilm.ForeColor = System.Drawing.Color.White;
            this.labelDaftarFilm.Location = new System.Drawing.Point(489, 61);
            this.labelDaftarFilm.Name = "labelDaftarFilm";
            this.labelDaftarFilm.Size = new System.Drawing.Size(181, 45);
            this.labelDaftarFilm.TabIndex = 72;
            this.labelDaftarFilm.Text = "CARI FILM";
            this.labelDaftarFilm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormLihatFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormLihatFilm";
            this.Text = "Lihat Film";
            this.Load += new System.EventHandler(this.FormLihatFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAktor;
        private System.Windows.Forms.Label labelCariBerdasarkan;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label labelStudio;
        private System.Windows.Forms.ComboBox comboBoxJam;
        private System.Windows.Forms.Label labelJam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.ComboBox comboBoxStudio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDaftarFilm;
    }
}