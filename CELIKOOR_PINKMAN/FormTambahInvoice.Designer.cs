namespace CELIKOOR_PINKMAN
{
    partial class FormTambahInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahInvoice));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGarisJudul = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTambahInvoice = new System.Windows.Forms.Label();
            this.comboBoxKonsumen = new System.Windows.Forms.ComboBox();
            this.labelKonsumen = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.textBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.comboBoxKasir = new System.Windows.Forms.ComboBox();
            this.labelKasir = new System.Windows.Forms.Label();
            this.comboBox1Status = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panelGarisJudul);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Controls.Add(this.labelTambahInvoice);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 140);
            this.panel2.TabIndex = 127;
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
            // labelTambahInvoice
            // 
            this.labelTambahInvoice.AutoSize = true;
            this.labelTambahInvoice.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahInvoice.ForeColor = System.Drawing.Color.White;
            this.labelTambahInvoice.Location = new System.Drawing.Point(184, 70);
            this.labelTambahInvoice.Name = "labelTambahInvoice";
            this.labelTambahInvoice.Size = new System.Drawing.Size(302, 45);
            this.labelTambahInvoice.TabIndex = 72;
            this.labelTambahInvoice.Text = "TAMBAH INVOICE";
            this.labelTambahInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxKonsumen
            // 
            this.comboBoxKonsumen.FormattingEnabled = true;
            this.comboBoxKonsumen.Location = new System.Drawing.Point(172, 321);
            this.comboBoxKonsumen.Name = "comboBoxKonsumen";
            this.comboBoxKonsumen.Size = new System.Drawing.Size(118, 24);
            this.comboBoxKonsumen.TabIndex = 123;
            // 
            // labelKonsumen
            // 
            this.labelKonsumen.AutoSize = true;
            this.labelKonsumen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKonsumen.Location = new System.Drawing.Point(46, 321);
            this.labelKonsumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKonsumen.Name = "labelKonsumen";
            this.labelKonsumen.Size = new System.Drawing.Size(112, 25);
            this.labelKonsumen.TabIndex = 122;
            this.labelKonsumen.Text = "Konsumen :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 273);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 120;
            // 
            // labelDiskon
            // 
            this.labelDiskon.AutoSize = true;
            this.labelDiskon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskon.Location = new System.Drawing.Point(46, 270);
            this.labelDiskon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(80, 25);
            this.labelDiskon.TabIndex = 119;
            this.labelDiskon.Text = "Diskon :";
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.Location = new System.Drawing.Point(172, 222);
            this.textBoxGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.Size = new System.Drawing.Size(239, 22);
            this.textBoxGrandTotal.TabIndex = 115;
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(46, 222);
            this.labelGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(121, 25);
            this.labelGrandTotal.TabIndex = 114;
            this.labelGrandTotal.Text = "Grand Total :";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSimpan.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(94, 475);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(116, 46);
            this.buttonSimpan.TabIndex = 113;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonKeluar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(295, 475);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(116, 46);
            this.buttonKeluar.TabIndex = 112;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(46, 169);
            this.labelTanggal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(89, 25);
            this.labelTanggal.TabIndex = 105;
            this.labelTanggal.Text = "Tanggal :";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(172, 169);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(219, 22);
            this.dateTimePickerTanggal.TabIndex = 128;
            // 
            // comboBoxKasir
            // 
            this.comboBoxKasir.FormattingEnabled = true;
            this.comboBoxKasir.Location = new System.Drawing.Point(172, 366);
            this.comboBoxKasir.Name = "comboBoxKasir";
            this.comboBoxKasir.Size = new System.Drawing.Size(118, 24);
            this.comboBoxKasir.TabIndex = 130;
            // 
            // labelKasir
            // 
            this.labelKasir.AutoSize = true;
            this.labelKasir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKasir.Location = new System.Drawing.Point(46, 366);
            this.labelKasir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKasir.Name = "labelKasir";
            this.labelKasir.Size = new System.Drawing.Size(64, 25);
            this.labelKasir.TabIndex = 129;
            this.labelKasir.Text = "Kasir :";
            // 
            // comboBox1Status
            // 
            this.comboBox1Status.FormattingEnabled = true;
            this.comboBox1Status.Items.AddRange(new object[] {
            "PENDING",
            "VALIDASI",
            "TERBAYAR"});
            this.comboBox1Status.Location = new System.Drawing.Point(172, 411);
            this.comboBox1Status.Name = "comboBox1Status";
            this.comboBox1Status.Size = new System.Drawing.Size(118, 24);
            this.comboBox1Status.TabIndex = 132;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(46, 411);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(75, 25);
            this.labelStatus.TabIndex = 131;
            this.labelStatus.Text = "Status :";
            // 
            // FormTambahInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 530);
            this.Controls.Add(this.comboBox1Status);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxKasir);
            this.Controls.Add(this.labelKasir);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxKonsumen);
            this.Controls.Add(this.labelKonsumen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelDiskon);
            this.Controls.Add(this.textBoxGrandTotal);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.labelTanggal);
            this.Name = "FormTambahInvoice";
            this.Text = "Tambah Invoice";
            this.Load += new System.EventHandler(this.FormTambahInvoice_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelGarisJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTambahInvoice;
        private System.Windows.Forms.ComboBox comboBoxKonsumen;
        private System.Windows.Forms.Label labelKonsumen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.TextBox textBoxGrandTotal;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.ComboBox comboBoxKasir;
        private System.Windows.Forms.Label labelKasir;
        private System.Windows.Forms.ComboBox comboBox1Status;
        private System.Windows.Forms.Label labelStatus;
    }
}