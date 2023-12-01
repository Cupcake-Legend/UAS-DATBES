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
    public partial class FormDaftarJenisStudio : Form
    {
        public FormDaftarJenisStudio()
        {
            InitializeComponent();
        }

        public List<JenisStudio> listJenisStudio = new List<JenisStudio>();

        private void FormDaftarJenisStudio_Load(object sender, EventArgs e)
        {
            try
            {
                listJenisStudio = JenisStudio.SelectDataList("", "");
                if (listJenisStudio.Count > 0)
                {
                    dataGridView1.DataSource = listJenisStudio;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJenisStudio frm = new FormTambahJenisStudio();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string kodeHapus = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                string namaHapus = dataGridView1.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus?" + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Aktor f = Aktor.SelectDataSingle(kodeHapus);
                    Boolean hapus = Aktor.DeleteData(f);

                    if (hapus)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }
    }
}
