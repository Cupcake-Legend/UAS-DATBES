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
    public partial class FormDaftarPegawai : Form
    {
        public FormDaftarPegawai()
        {
            InitializeComponent();
        }
        List<Pegawai> listPegawai = new List<Pegawai>();

        private void FormDaftarPegawai_Load(object sender, EventArgs e)
        {
            try
            {
                listPegawai = Pegawai.SelectDataList("", "");
                if (listPegawai.Count > 0)
                {
                    dataGridView1.DataSource = listPegawai;
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
            FormTambahPegawai frm = new FormTambahPegawai();
            frm.Owner = this;
            frm.ShowDialog();   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonHapus_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBox1.Text == "ID")
            {
                kriteria = "pegawais.Id";
            }

            else if (comboBox1.Text == "Nama")
            {
                kriteria = "pegawais.Nama";
            }

            else if (comboBox1.Text == "roles")
            {
                kriteria = "pegawais.Roles";
            }

            listPegawai = Pegawai.SelectDataList(kriteria, textBox1.Text);

            if (listPegawai.Count > 0)
            {
                dataGridView1.DataSource = listPegawai;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
