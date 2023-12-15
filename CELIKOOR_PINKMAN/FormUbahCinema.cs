using CELIKOOR_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELIKOOR_PINKMAN
{
    public partial class FormUbahCinema : Form
    {
        public FormUbahCinema()
        {
            InitializeComponent();
        }
        public Cinema cinema;

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema c = new Cinema(cinema.Id, textBoxNama.Text, textBoxAlamat.Text, dateTimePickerTanggal.Value, textBoxKota.Text);
                Cinema.UpdateData(c);
                MessageBox.Show("Data cinema telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarCinema frm = (FormDaftarCinema)this.Owner;
            frm.FormDaftarCinema_Load(buttonKeluar, e);
            this.Close();
        }

        private void FormUbahCinema_Load(object sender, EventArgs e)
        {
            textBoxID.Text = cinema.Id.ToString();
            textBoxNama.Text = cinema.Nama_cabang;
            textBoxKota.Text = cinema.Kota;
            textBoxAlamat.Text = cinema.Alamat;
            dateTimePickerTanggal.Value = cinema.Tgl_dibuka;
        }
    }
}
