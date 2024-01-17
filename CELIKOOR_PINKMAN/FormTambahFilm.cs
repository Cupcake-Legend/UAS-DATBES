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
    public partial class FormTambahFilm : Form
    {
        public FormTambahFilm()
        {
            InitializeComponent();
        }
        List<Kelompok> listKelompok = new List<Kelompok>();
        List<Genre>listGenre = new List<Genre>();
        List<Aktor> listAktor = new List<Aktor>();
        Film f;

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {

                bool subindo;
                if (radioButtonSUBINDO.Checked)
                {
                    subindo = true;
                }
                else
                {
                    subindo = false;
                }

                f = new Film(0, textBoxJudul.Text, textBoxSinopsis.Text,
                    (int)numericUpDown1.Value, int.Parse(textBoxDurasi.Text), (Kelompok)comboBoxKelompok.SelectedItem, comboBoxBahasa.Text, subindo, textBoxCover.Text, double.Parse(textBoxDiskon.Text));


                GenreFilm genreFilm = new GenreFilm(comboBoxGenre.SelectedItem as Genre);
                f.GenreFilmList.Add(genreFilm);


                bool success = Film.InsertData(f);

                if (success)
                {
                    MessageBox.Show("Data film berhasil ditambahkan!", "Information");
                    this.Close();
                    

                }
                else
                {
                    MessageBox.Show("Data film gagal ditambahkan!", "Error");
                }
            

            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. Pesan kesalahan: " + ex.Message, "Error");

            }


        }

        private void FormTambahFilm_Load(object sender, EventArgs e)
        {
            listKelompok = Kelompok.SelectDataKelompok("", "");
            comboBoxKelompok.DataSource = listKelompok;
            comboBoxKelompok.DisplayMember = "nama";

            listGenre = Genre.SelectDataList("", "");
            comboBoxGenre.DataSource = listGenre;
            comboBoxGenre.DisplayMember = "nama";

            listAktor = Aktor.SelectDataList("", "");
            comboBoxAktor.DataSource = listAktor;
            comboBoxAktor.DisplayMember = "nama";


        }

        private void buttonAddAktor_Click(object sender, EventArgs e)
        {
            f = new Film(0, textBoxJudul.Text, textBoxSinopsis.Text,
                   (int)numericUpDown1.Value, int.Parse(textBoxDurasi.Text), (Kelompok)comboBoxKelompok.SelectedItem, comboBoxBahasa.Text, false, textBoxCover.Text, double.Parse(textBoxDiskon.Text));

            

            AktorFilm aktorFilm = new AktorFilm(comboBoxAktor.SelectedItem as Aktor, comboBoxPeran.Text);


            f.AktorFilmList.Add(aktorFilm);

        }
    }
}
