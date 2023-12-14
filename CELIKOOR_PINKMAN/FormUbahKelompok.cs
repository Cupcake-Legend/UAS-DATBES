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
    public partial class FormUbahKelompok : Form
    {
        public FormUbahKelompok()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kelompok k = new Kelompok(int.Parse(textBoxId.Text), textBoxNama.Text);
                Kelompok.UpdateData(k);
                MessageBox.Show("Data kelompok telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarKelompok frm = (FormDaftarKelompok)this.Owner;
            frm.FormDaftarKelompok_Load(buttonKeluar, e);
            this.Close();
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }
    }
}
