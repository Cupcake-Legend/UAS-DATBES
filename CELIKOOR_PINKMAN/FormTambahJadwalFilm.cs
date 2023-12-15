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
    public partial class FormTambahJadwalFilm : Form
    {
        public FormTambahJadwalFilm()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string jam = "";

                if (radioButton1.Checked)
                {
                    jam = "I";
                }
                if (radioButton2.Checked)
                {
                    jam = "II";
                }
                if (radioButton3.Checked)
                {
                    jam = "III";
                }
                if (radioButton4.Checked)
                {
                    jam = "IV";
                }

                JadwalFilm j = new JadwalFilm(0, dateTimePicker1.Value, jam);
                bool success = JadwalFilm.InsertData(j);
                if (success)
                {
                    MessageBox.Show("Data berhasil ditambahkan!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");
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
