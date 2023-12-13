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
                FormatDataGrid();
                TampilDataGrid();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void FormatDataGrid()
        {
            dataGridView1.Columns.Add("colID", "ID");
            dataGridView1.Columns.Add("colNama", "Nama");
            dataGridView1.Columns.Add("colDeskripsi", "Deskripsi");
        }
        private void TampilDataGrid()
        {
            if(listJenisStudio.Count > 0)
            {
                foreach(JenisStudio j in listJenisStudio)
                {
                    dataGridView1.Rows.Add(j.Id, j.Nama, j.Deskripsi);

                    if (!dataGridView1.Columns.Contains("btnUbahGrid"))
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        //nama header
                        bcol.HeaderText = "Aksi";
                        //nama tombol
                        bcol.Text = "Ubah";
                        bcol.Name = "btnUbahGrid";

                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);


                    }
                    if (!dataGridView1.Columns.Contains("btnDeleteGrid"))
                    {
                        DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                        //nama header
                        bcol1.HeaderText = "Aksi";
                        //nama tombol
                        bcol1.Text = "Delete";
                        bcol1.Name = "btnDeleteGrid";

                        bcol1.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol1);

                    }

                }
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
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    string kodeHapus = dataGridView1.CurrentRow.Cells["colID"].Value.ToString();
                    string namaHapus = dataGridView1.CurrentRow.Cells["colNama"].Value.ToString();

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
