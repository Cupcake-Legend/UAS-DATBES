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
    public partial class FormLoginPegawai : Form
    {
        public FormLoginPegawai()
        {
            InitializeComponent();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenu frm = (FormMenu)this.Owner.Owner;
                Pegawai pegawai = Pegawai.CheckLogin(textBoxUsername.Text, textBoxPassword.Text);

                if(!(pegawai is null))
                {
                    frm.pegawaiLogin = pegawai;
                    frm.AturMenu();
                    MessageBox.Show("Welcome back " + pegawai.Nama + " - " + pegawai.Roles);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                    
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");
            }
        }
    }
}
