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
    public partial class FormDaftarCinema : Form
    {
        public FormDaftarCinema()
        {
            InitializeComponent();
        }
        List<Cinema>listCinema = new List<Cinema>();

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahCinema frm = new FormTambahCinema();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }

        private void FormDaftarCinema_Load(object sender, EventArgs e)
        {
            try
            {
                listCinema = Cinema.SelectDataList("", "");
                if (listCinema.Count > 0)
                {
                        dataGridView1.DataSource = listCinema;
                    if(dataGridView1.ColumnCount < 6)
                    {
                        DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                        bcol2.HeaderText = "Aksi";
                        bcol2.Text = "Delete";
                        bcol2.UseColumnTextForButtonValue = true;
                        bcol2.Name = "btnDelete";
                        dataGridView1.Columns.Add(bcol2);
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
                string namaHapus = dataGridView1.CurrentRow.Cells["nama_cabang"].Value.ToString();
                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus?" + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Cinema f = Cinema.SelectDataSingle(kodeHapus);
                    Boolean hapus = Cinema.DeleteData(f);

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

