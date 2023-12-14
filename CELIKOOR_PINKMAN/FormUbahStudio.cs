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
    public partial class FormUbahStudio : Form
    {
        public FormUbahStudio()
        {
            InitializeComponent();
        }

        private void LabelRp1_Click(object sender, EventArgs e)
        {

        }

        private void labelRp2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxHargaWeekend_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHargaWeekday_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxJenisStudio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numUpDownKapasitas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                JenisStudio j = (JenisStudio)comboBoxJenisStudio.SelectedItem;
                Cinema c = (Cinema)comboBoxCinema.SelectedItem;
                Studio s = new Studio(int.Parse(textBoxId.Text), textBoxNama.Text, (int)numUpDownKapasitas.Value, 
                    j, c, int.Parse(textBoxHargaWeekday.Text), int.Parse(textBoxHargaWeekend.Text));
                Studio.UpdateData(s);
                MessageBox.Show("Data studio telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarStudio frm = (FormDaftarStudio)this.Owner;
            frm.FormDaftarStudio_Load(buttonKeluar, e);
            this.Close();
        }
    }
}
