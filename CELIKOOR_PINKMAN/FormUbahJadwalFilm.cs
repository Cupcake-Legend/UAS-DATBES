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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CELIKOOR_PINKMAN
{
    public partial class FormUbahJadwalFilm : Form
    {
        string jam;
        public FormUbahJadwalFilm()
        {
            InitializeComponent();
        }
        public JadwalFilm jadwalFilm;

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarJadwalFilm frm = (FormDaftarJadwalFilm)this.Owner;
            frm.FormDaftarJadwalFilm_Load(buttonKeluar, e);
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    jam = "I";
                }
                else if (radioButton2.Checked)
                {
                    jam = "II";
                }
                else if (radioButton3.Checked)
                {
                    jam = "III";
                }
                else if (radioButton4.Checked)
                {
                    jam = "IV";
                }
                JadwalFilm j = new JadwalFilm(jadwalFilm.Id, dateTimePicker1.Value, jam);
                JadwalFilm.UpdateData(j);
                MessageBox.Show("Data jadwal film telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void FormUbahJadwalFilm_Load(object sender, EventArgs e)
        {
            textBoxID.Text = jadwalFilm.Id.ToString();
            if (jadwalFilm.JamPemutaran == "I")
            {
                radioButton1.Checked = true;
            }
            else if (jadwalFilm.JamPemutaran == "II")
            {
                radioButton2.Checked = true;
            }
            else if (jadwalFilm.JamPemutaran == "III")
            {
                radioButton3.Checked = true;
            }
            else if (jadwalFilm.JamPemutaran == "IV")
            {
                radioButton4.Checked = true;
            }
            dateTimePicker1.Value = jadwalFilm.Tanggal;

        }
    }
}
