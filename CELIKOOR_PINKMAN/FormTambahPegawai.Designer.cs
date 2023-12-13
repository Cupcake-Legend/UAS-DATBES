namespace CELIKOOR_PINKMAN
{
    partial class FormTambahPegawai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahPegawai));
            this.labelJudul = new System.Windows.Forms.Label();
            this.panelGarisRegistration = new System.Windows.Forms.Panel();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.buttonBuatAkun = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelJudul = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.panelGarisJudul = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxNama = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelJudul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelJudul.Location = new System.Drawing.Point(204, 12);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(479, 54);
            this.labelJudul.TabIndex = 66;
            this.labelJudul.Text = "CELIKOOR 21 CINEPLEX";
            // 
            // panelGarisRegistration
            // 
            this.panelGarisRegistration.BackColor = System.Drawing.Color.Black;
            this.panelGarisRegistration.Location = new System.Drawing.Point(17, 64);
            this.panelGarisRegistration.Name = "panelGarisRegistration";
            this.panelGarisRegistration.Size = new System.Drawing.Size(338, 2);
            this.panelGarisRegistration.TabIndex = 45;
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.BackColor = System.Drawing.Color.Transparent;
            this.labelRegistration.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelRegistration.Location = new System.Drawing.Point(16, 19);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(347, 50);
            this.labelRegistration.TabIndex = 28;
            this.labelRegistration.Text = "Registrasi Pegawai";
            // 
            // buttonBuatAkun
            // 
            this.buttonBuatAkun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonBuatAkun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuatAkun.ForeColor = System.Drawing.Color.White;
            this.buttonBuatAkun.Location = new System.Drawing.Point(557, 270);
            this.buttonBuatAkun.Name = "buttonBuatAkun";
            this.buttonBuatAkun.Size = new System.Drawing.Size(217, 45);
            this.buttonBuatAkun.TabIndex = 9;
            this.buttonBuatAkun.Text = "Buat Akun";
            this.buttonBuatAkun.UseVisualStyleBackColor = false;
            this.buttonBuatAkun.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(449, 178);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(91, 25);
            this.labelPassword.TabIndex = 43;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(449, 113);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(95, 25);
            this.labelUsername.TabIndex = 42;
            this.labelUsername.Text = "Username:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(66, 173);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 25);
            this.labelEmail.TabIndex = 38;
            this.labelEmail.Text = "Email:";
            // 
            // panelJudul
            // 
            this.panelJudul.BackColor = System.Drawing.Color.White;
            this.panelJudul.Controls.Add(this.pictureBox1);
            this.panelJudul.Controls.Add(this.comboBox1);
            this.panelJudul.Controls.Add(this.labelRole);
            this.panelJudul.Controls.Add(this.panelGarisRegistration);
            this.panelJudul.Controls.Add(this.labelRegistration);
            this.panelJudul.Controls.Add(this.buttonBuatAkun);
            this.panelJudul.Controls.Add(this.labelPassword);
            this.panelJudul.Controls.Add(this.labelUsername);
            this.panelJudul.Controls.Add(this.labelEmail);
            this.panelJudul.Controls.Add(this.labelNama);
            this.panelJudul.Controls.Add(this.textBoxPassword);
            this.panelJudul.Controls.Add(this.pictureBoxPassword);
            this.panelJudul.Controls.Add(this.textBoxUsername);
            this.panelJudul.Controls.Add(this.pictureBoxUsername);
            this.panelJudul.Controls.Add(this.textBoxEmail);
            this.panelJudul.Controls.Add(this.pictureBoxEmail);
            this.panelJudul.Controls.Add(this.textBoxNama);
            this.panelJudul.Controls.Add(this.pictureBoxNama);
            this.panelJudul.Location = new System.Drawing.Point(25, 110);
            this.panelJudul.Name = "panelJudul";
            this.panelJudul.Size = new System.Drawing.Size(811, 338);
            this.panelJudul.TabIndex = 68;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "OPERATOR",
            "KASIR"});
            this.comboBox1.Location = new System.Drawing.Point(130, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 33);
            this.comboBox1.TabIndex = 48;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.Black;
            this.labelRole.Location = new System.Drawing.Point(66, 232);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(55, 25);
            this.labelRole.TabIndex = 47;
            this.labelRole.Text = "Role :";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.ForeColor = System.Drawing.Color.Black;
            this.labelNama.Location = new System.Drawing.Point(63, 114);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(63, 25);
            this.labelNama.TabIndex = 28;
            this.labelNama.Text = "Nama:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassword.Location = new System.Drawing.Point(557, 172);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(213, 34);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsername.Location = new System.Drawing.Point(557, 107);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(213, 34);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmail.Location = new System.Drawing.Point(130, 167);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(210, 34);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNama.Location = new System.Drawing.Point(130, 109);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(210, 34);
            this.textBoxNama.TabIndex = 0;
            // 
            // panelGarisJudul
            // 
            this.panelGarisJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelGarisJudul.Location = new System.Drawing.Point(213, 69);
            this.panelGarisJudul.Name = "panelGarisJudul";
            this.panelGarisJudul.Size = new System.Drawing.Size(455, 10);
            this.panelGarisJudul.TabIndex = 75;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(50, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(92, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 67;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::CELIKOOR_PINKMAN.Properties.Resources.padlock_no_fil;
            this.pictureBoxPassword.Location = new System.Drawing.Point(406, 174);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(37, 34);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassword.TabIndex = 36;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUsername
            // 
            this.pictureBoxUsername.Image = global::CELIKOOR_PINKMAN.Properties.Resources.id_card_no_fill;
            this.pictureBoxUsername.Location = new System.Drawing.Point(406, 109);
            this.pictureBoxUsername.Name = "pictureBoxUsername";
            this.pictureBoxUsername.Size = new System.Drawing.Size(37, 34);
            this.pictureBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsername.TabIndex = 35;
            this.pictureBoxUsername.TabStop = false;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Image = global::CELIKOOR_PINKMAN.Properties.Resources.mail;
            this.pictureBoxEmail.Location = new System.Drawing.Point(20, 169);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(37, 34);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmail.TabIndex = 31;
            this.pictureBoxEmail.TabStop = false;
            // 
            // pictureBoxNama
            // 
            this.pictureBoxNama.Image = global::CELIKOOR_PINKMAN.Properties.Resources.user_no_fill;
            this.pictureBoxNama.Location = new System.Drawing.Point(20, 109);
            this.pictureBoxNama.Name = "pictureBoxNama";
            this.pictureBoxNama.Size = new System.Drawing.Size(37, 34);
            this.pictureBoxNama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNama.TabIndex = 23;
            this.pictureBoxNama.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CELIKOOR_PINKMAN.Properties.Resources.role;
            this.pictureBox1.Location = new System.Drawing.Point(20, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // FormTambahPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(870, 474);
            this.Controls.Add(this.panelGarisJudul);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelJudul);
            this.Name = "FormTambahPegawai";
            this.Text = "Tambah Pegawai";
            this.panelJudul.ResumeLayout(false);
            this.panelJudul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Panel panelGarisRegistration;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Button buttonBuatAkun;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelJudul;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.PictureBox pictureBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.PictureBox pictureBoxNama;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Panel panelGarisJudul;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}