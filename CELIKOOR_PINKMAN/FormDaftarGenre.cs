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

        private void FormDaftarGenre_Load(object sender, EventArgs e)
        {
            try
            {
                listGenre = Genre.SelectDataList("", "");
                if (listGenre.Count > 0)
                {
                        dataGridView1.DataSource = listGenre;
                    if(dataGridView1.ColumnCount < 4)
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Delete";
                        bcol.Name = "btnDelete";

                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);
                    }
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
            if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                string namaHapus = dataGridView1.CurrentRow.Cells["nama"].Value.ToString();
                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus?" + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Genre f = Genre.SelectDataSingle(kodeHapus);
                    Boolean hapus = Genre.DeleteData(f);

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

