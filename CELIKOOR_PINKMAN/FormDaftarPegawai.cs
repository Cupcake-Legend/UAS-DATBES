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
                    if(dataGridView1.Columns.Count < 7)
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Ubah";
                        bcol.Name = "btnUbahGrid";

                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);

                        DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                        bcol1.HeaderText = "Aksi";
                        bcol1.Text = "Delete";
                        bcol1.Name = "btnDeleteGrid";
                        bcol1.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol1);

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

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai frm = new FormTambahPegawai();
            frm.Owner = this;
            frm.ShowDialog();   
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
                    Pegawai f = Pegawai.SelectDataSingle(kodeHapus);
                    Boolean hapus = Pegawai.DeleteData(f);

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
