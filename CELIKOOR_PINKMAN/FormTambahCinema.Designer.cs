namespace CELIKOOR_PINKMAN
{
    partial class FormTambahCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahCinema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxKota = new System.Windows.Forms.TextBox();
            this.labelKota = new System.Windows.Forms.Label();
            this.labelTglDibuka = new System.Windows.Forms.Label();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelNamaCabang = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 137);
            this.panel1.TabIndex = 77;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(319, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 90);
            this.label.TabIndex = 51;
            this.label.Text = "Tambah\r\nCinema";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(71, 429);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 46);
            this.buttonSave.TabIndex = 76;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(328, 429);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(116, 46);
            this.buttonExit.TabIndex = 75;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // textBoxKota
            // 
            this.textBoxKota.Location = new System.Drawing.Point(204, 371);
            this.textBoxKota.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKota.Name = "textBoxKota";
            this.textBoxKota.Size = new System.Drawing.Size(239, 22);
            this.textBoxKota.TabIndex = 74;
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKota.Location = new System.Drawing.Point(134, 368);
            this.labelKota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(62, 25);
            this.labelKota.TabIndex = 73;
            this.labelKota.Text = "Kota :";
            // 
            // labelTglDibuka
            // 
            this.labelTglDibuka.AutoSize = true;
            this.labelTglDibuka.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglDibuka.Location = new System.Drawing.Point(86, 325);
            this.labelTglDibuka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTglDibuka.Name = "labelTglDibuka";
            this.labelTglDibuka.Size = new System.Drawing.Size(110, 25);
            this.labelTglDibuka.TabIndex = 71;
            this.labelTglDibuka.Text = "Tgl dibuka :";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(204, 250);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamat.Size = new System.Drawing.Size(239, 58);
            this.textBoxAlamat.TabIndex = 70;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(113, 250);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(83, 25);
            this.labelAlamat.TabIndex = 69;
            this.labelAlamat.Text = "Alamat :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(204, 206);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(239, 22);
            this.textBoxNama.TabIndex = 68;
            // 
            // labelNamaCabang
            // 
            this.labelNamaCabang.AutoSize = true;
            this.labelNamaCabang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaCabang.Location = new System.Drawing.Point(55, 202);
            this.labelNamaCabang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaCabang.Name = "labelNamaCabang";
            this.labelNamaCabang.Size = new System.Drawing.Size(141, 25);
            this.labelNamaCabang.TabIndex = 67;
            this.labelNamaCabang.Text = "Nama Cabang :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 327);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(127, 114);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 50;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormTambahCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 496);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxKota);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.labelTglDibuka);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelNamaCabang);
            this.Name = "FormTambahCinema";
            this.Text = "FormTambahCinema";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxKota;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.Label labelTglDibuka;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelNamaCabang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}