using CELIKOOR_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELIKOOR_PINKMAN
{
    public partial class FormLoginNormal : Form
    {
        public FormLoginNormal()
        {
            InitializeComponent();
        }

        private void FormLoginNormal_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRegisterNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrasi frm = new FormRegistrasi();
            frm.Owner = this;
            frm.ShowDialog();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenu frm = (FormMenu)this.Owner;
                if(textBoxUsername.Text == "root" && textBoxPassword.Text == "mysql")
                {
                    if (frm.konsumenLogin == null)
                    {
                        FormLoginPegawai formPegawai = new FormLoginPegawai();
                        formPegawai.Owner = this;

                        if(formPegawai.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("Silahkan Logout Terlebih dahulu!");
                    }
                    



                }
                else
                {
                    if(frm.pegawaiLogin == null)
                    {

                        Koneksi k = new Koneksi();
                        Konsumen konsumen = Konsumen.CheckLogin(textBoxUsername.Text, textBoxPassword.Text);

                        if(!(konsumen is null))
                        {
                            frm.konsumenLogin = konsumen;

                            MessageBox.Show("Welcome " + konsumen.Nama);

                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Username tidak ditemukan atau password salah!", "Error");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Silahkan Logout Terlebih dahulu!");
                    }
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");

            }
        }
    }
}
