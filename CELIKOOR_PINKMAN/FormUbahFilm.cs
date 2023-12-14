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
                Film f = new Film(int.Parse(textBoxId.Text), textBoxJudul.Text, textBoxSinopsis.Text,
                    (int)numericUpDown1.Value, int.Parse(textBoxDurasi.Text), k, textBoxBahasa.Text, subs,
                    textBoxCover.Text, double.Parse(textBoxDiskon.Text));
                Film.UpdateData(f);
                MessageBox.Show("Data film telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarJadwalFilm frm = (FormDaftarJadwalFilm)this.Owner;
            frm.FormDaftarJadwalFilm_Load(buttonKeluar, e);
            this.Close();
        }
    }
}
