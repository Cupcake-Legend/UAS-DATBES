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
    public partial class FormDaftarGenre : Form
    {
        public FormDaftarGenre()
        {
            InitializeComponent();
        }
        List<Genre> listGenre = new List<Genre>();

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahGenre frm = new FormTambahGenre();
            frm.Owner = this;
            frm.ShowDialog();
        }

        public void FormDaftarGenre_Load(object sender, EventArgs e)
        {
            try
            {
                listGenre = Genre.SelectDataList("", "");
                if (listGenre.Count > 0)
                {
                    dataGridView1.DataSource = listGenre;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {

            }
            if (e.ColumnIndex == dataGridView1.Columns["btnDeleteGrid"].Index && e.RowIndex >= 0)
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
}

