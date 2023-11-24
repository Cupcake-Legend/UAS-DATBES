using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CELIKOOR_LIB;

namespace CELIKOOR_PINKMAN
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;

        public void AturMenu()
        {
            if(konsumenLogin != null && pegawaiLogin == null)
            {
                menuToolStripMenuItem.Visible = true;
                loginToolStripMenuItem.Visible = false;
                registerToolStripMenuItem.Visible = false;
                operatorToolStripMenuItem.Visible=false;
                kasirToolStripMenuItem.Visible=false;
                masterToolStripMenuItem.Visible=false;


            }
            else if (konsumenLogin == null && pegawaiLogin != null)
            {
                if (pegawaiLogin.Roles == "OPERATOR")
                {
                    menuToolStripMenuItem.Visible = true;
                    loginToolStripMenuItem.Visible = false;
                    registerToolStripMenuItem.Visible=false;
                    operatorToolStripMenuItem.Visible = true;
                    kasirToolStripMenuItem.Visible = false;
                    masterToolStripMenuItem.Visible = false;

                }
                else if (pegawaiLogin.Roles == "KASIR")
                {
                    menuToolStripMenuItem.Visible = true;
                    loginToolStripMenuItem.Visible = false;
                    registerToolStripMenuItem.Visible = false;
                    operatorToolStripMenuItem.Visible = false;
                    kasirToolStripMenuItem.Visible = true;
                    masterToolStripMenuItem.Visible = false;

                }
                else if (pegawaiLogin.Roles == "ADMIN")
                {
                    menuToolStripMenuItem.Visible = true;
                    loginToolStripMenuItem.Visible = false;
                    registerToolStripMenuItem.Visible = false;
                    operatorToolStripMenuItem.Visible = false;
                    kasirToolStripMenuItem.Visible = false;
                    masterToolStripMenuItem.Visible = true;
                }
            }

            else if(konsumenLogin!= null && pegawaiLogin != null)
            {
                konsumenLogin = null;
                pegawaiLogin = null;
                MessageBox.Show("Terjadi kesalahan!, Tolong Login ulang!", "Error");
            }
            else if(konsumenLogin == null && pegawaiLogin == null) 
            {
                menuToolStripMenuItem.Visible = true;
                loginToolStripMenuItem.Visible = true;
                registerToolStripMenuItem.Visible = true;
                operatorToolStripMenuItem.Visible = false;
                kasirToolStripMenuItem.Visible = false;
                masterToolStripMenuItem.Visible = false;
            }

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;
            try
            {
                Koneksi k = new Koneksi();
                MessageBox.Show("Connection success");
                FormLoginNormal frmLogin = new FormLoginNormal();
                frmLogin.Owner = this;
                if(frmLogin.ShowDialog() == DialogResult.OK)
                {
                    AturMenu();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. Error message: " + ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        private void labelDontHaveAnAccount_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            konsumenLogin = null;
            pegawaiLogin = null;
            AturMenu();
           
            MessageBox.Show("Akun sukses logout!");

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginNormal frmLogin = new FormLoginNormal();
            frmLogin.Owner = this;
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                AturMenu();

            }

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrasi frmRegist = new FormRegistrasi();   
            frmRegist.Owner = this;
            frmRegist.ShowDialog();

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfile frm = new FormProfile();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void konsumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarKonsumen frm = new FormDaftarKonsumen();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarCinema frm = new FormDaftarCinema();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarPegawai frm = new FormDaftarPegawai();
            frm.Owner = this;
        }

        private void kelompokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarKelompok frm = new FormDaftarKelompok();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarGenre frm = new FormDaftarGenre();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void aktorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
