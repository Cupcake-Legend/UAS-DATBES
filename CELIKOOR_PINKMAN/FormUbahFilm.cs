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
    public partial class FormUbahFilm : Form
    {
        bool subs;
        public FormUbahFilm()
        {
            InitializeComponent();
        }
        public Film film;
        List<Kelompok>listKelompok = new List<Kelompok>();

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonSUBINDO.Checked)
                {
                    subs = true;
                }
                else if (radioButtonLAiN.Checked)
                {
                    subs = false;
                }
                Kelompok k = (Kelompok)comboBoxKelompok.SelectedItem;
                Film f = new Film(film.Id, textBoxJudul.Text, textBoxSinopsis.Text,
                    (int)numericUpDown1.Value, int.Parse(textBoxDurasi.Text), k, textBoxBahasa.Text, subs,
                    textBoxCover.Text, double.Parse(textBoxDiskon.Text));
                Film.UpdateData(f);
                MessageBox.Show("Data film telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarJadwalFilm frm = (FormDaftarJadwalFilm)this.Owner;
            frm.FormDaftarJadwalFilm_Load(buttonKeluar, e);
            this.Close();
        }

        private void FormUbahFilm_Load(object sender, EventArgs e)
        {
           listKelompok = Kelompok.SelectDataKelompok("", "");
            comboBoxKelompok.DataSource = listKelompok;
            comboBoxKelompok.DisplayMember = "nama";

            textBoxID.Text = film.Id.ToString();
            textBoxJudul.Text = film.Judul;
            textBoxCover.Text = film.CoverImage;
            textBoxBahasa.Text = film.Bahasa;
            textBoxDiskon.Text = film.DiskonNominal.ToString();
            textBoxDurasi.Text = film.Durasi.ToString();
            textBoxSinopsis.Text = film.Sinopsis.ToString();
            numericUpDown1.Value = film.Tahun;

            if(film.IsSubIndo == true)
            {
                radioButtonSUBINDO.Checked = true;
                radioButtonLAiN.Checked = false;
            }
            else
            {
                radioButtonSUBINDO.Checked = false;
                radioButtonLAiN.Checked = true;
            }


        }
    }
}
