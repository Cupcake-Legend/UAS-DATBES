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
            this.Visible = false;
            frm.ShowDialog();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenu frm = (FormMenu)this.Owner;
               
                
                    
                Koneksi k = new Koneksi();
                Konsumen konsumen = Konsumen.CheckLogin(textBoxUsername.Text, textBoxPassword.Text);

                if (!(konsumen is null))
                {
                   frm.konsumenLogin = konsumen;

                   MessageBox.Show("Welcome " + konsumen.Nama);

                   this.DialogResult = DialogResult.OK;
                   this.Close();

                }
                        
                    
                    else if (frm.konsumenLogin == null)
                    {
                        
                        Pegawai pegawai = Pegawai.CheckLogin(textBoxUsername.Text, textBoxPassword.Text);

                        if(pegawai != null)
                        {
                            frm.pegawaiLogin = pegawai; 

                            if (!string.IsNullOrEmpty(pegawai.Roles))
                            {
                                MessageBox.Show("Welcome back " + pegawai.Nama + " - " + pegawai.Roles);
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Role belum diatur untuk pengguna ini.", "Error");
                            }
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
