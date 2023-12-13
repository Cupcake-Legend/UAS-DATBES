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
    public partial class FormDaftarKonsumen : Form
    {
        public FormDaftarKonsumen()
        {
            InitializeComponent();
        }
        List<Konsumen> listKonsumen = new List<Konsumen>()
;        private void buttonTambah_Click(object sender, EventArgs e)
        {
        }

        private void FormDaftarKonsumen_Load(object sender, EventArgs e)
        {
            try
            {
                listKonsumen = Konsumen.SelectDataList("","");
                if (listKonsumen.Count > 0)
                {
                    dataGridView1.DataSource = listKonsumen;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if(comboBox1.Text == "ID")
            {
                kriteria = "konsumens.id";
            }
            else if(comboBox1.Text == "Nama")
            {
                kriteria = "konsumens.Nama";
            }
            else if (comboBox1.Text == "Email")
            {
                kriteria = "konsumens.Email";
            }
            else if (comboBox1.Text == "Username")
            {
                kriteria = "konsumens.username";
            }

            listKonsumen = Konsumen.SelectDataList(kriteria, textBox1.Text);

            if (listKonsumen.Count > 0)
            {
                dataGridView1.DataSource = listKonsumen;
            }
            else
            {
                dataGridView1.DataSource= null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
