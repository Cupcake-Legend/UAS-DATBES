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
    public partial class FormUbahJenisStudio : Form
    {
        public FormUbahJenisStudio()
        {
            InitializeComponent();
        }
        public JenisStudio jenisStudio;

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarJenisStudio frm = (FormDaftarJenisStudio)this.Owner;
            frm.FormDaftarJenisStudio_Load(buttonKeluar, e);
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                JenisStudio j = new JenisStudio(jenisStudio.Id, textBoxNama.Text, textBoxDeskripsi.Text);
                JenisStudio.EditData(j);
                MessageBox.Show("Data jenis studio telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void FormUbahJenisStudio_Load(object sender, EventArgs e)
        {
            textBoxID.Text = jenisStudio.Id.ToString();
            textBoxNama.Text = jenisStudio.Nama;
            textBoxDeskripsi.Text = jenisStudio.Deskripsi;

        }
    }
}
