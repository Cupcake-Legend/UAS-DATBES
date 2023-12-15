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

                Film f = new Film(0, textBoxJudul.Text, textBoxSinopsis.Text,
                    (int)numericUpDown1.Value, int.Parse(textBoxDurasi.Text), (Kelompok)comboBoxKelompok.SelectedItem, textBoxBahasa.Text, subindo, textBoxCover.Text, double.Parse(textBoxDiskon.Text));
            
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
        }
    }
}
