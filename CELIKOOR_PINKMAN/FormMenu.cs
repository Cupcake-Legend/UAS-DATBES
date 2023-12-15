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
            Form frm = Application.OpenForms["FormDaftarKonsumen"];
            if (frm == null)
            {
                FormDaftarKonsumen frmKonsumen = new FormDaftarKonsumen();
                frmKonsumen.MdiParent = this;
                frmKonsumen.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormDaftarCinema"];
            if (frm == null)
            {
                FormDaftarCinema frmdaftar = new FormDaftarCinema();
                frmdaftar.MdiParent = this;
                frmdaftar.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormDaftarPegawai"];
            if (frm == null)
            {
                FormDaftarPegawai frmDaftar = new FormDaftarPegawai();
                frmDaftar.MdiParent = this;
                frmDaftar.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void kelompokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormDaftarKelompok"];
            if (frm == null)
            {
                FormDaftarKelompok frmDaftar = new FormDaftarKelompok();
                frmDaftar.MdiParent = this;
                frmDaftar.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormDaftarGenre"];
            if (frm == null)
            {
                FormDaftarGenre frmDaftar = new FormDaftarGenre();
                frmDaftar.MdiParent = this;
                frmDaftar.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void aktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormDaftarAktor"];
            if (frm == null)
            {
                FormDaftarAktor frmDaftar = new FormDaftarAktor();
                frmDaftar.MdiParent = this;
                frmDaftar.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }

        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormDaftarFilm"];
            if (frm == null)
            {
                FormDaftarFilm frmDaftarFilm = new FormDaftarFilm();
                frmDaftarFilm.MdiParent = this;
                frmDaftarFilm.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormLaporan"];
            if (frm == null)
            {
                FormLaporan frmDaftarFilm = new FormLaporan();
                frmDaftarFilm.MdiParent = this;
                frmDaftarFilm.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }

        }

        private void jadwalFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormDaftarJadwalFilm"];
            if (frm == null)
            {
                FormDaftarJadwalFilm frmDaftarFilm = new FormDaftarJadwalFilm();
                frmDaftarFilm.MdiParent = this;
                frmDaftarFilm.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }

        }
    }
}
