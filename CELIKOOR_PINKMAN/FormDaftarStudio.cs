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
    public partial class FormDaftarStudio : Form
    {
        public List<Studio> listStudio = new List<Studio>();
        public FormDaftarStudio()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahStudio form = new FormTambahStudio();
            form.Owner = this;
            form.ShowDialog();
        }

        public void FormDaftarStudio_Load(object sender, EventArgs e)
        {
            try
            {
                listStudio = Studio.SelectDataList("", "");
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
            dataGridView1.Columns.Add("colKapasitas", "Kapasitas");
            dataGridView1.Columns.Add("colJenisStudio", "Jenis Studio");
            dataGridView1.Columns.Add("colCinemaStudio", "Cinema Studio");
            dataGridView1.Columns.Add("colHargaWeekday", "Harga Weekday");
            dataGridView1.Columns.Add("colHargaWeekend", "Harga Weekend");
        }
        private void TampilDataGrid()
        {
            if(listStudio.Count > 0)
            {
                foreach(Studio s in listStudio)
                {
                    dataGridView1.Rows.Add(s.Id, s.Nama, s.Kapasitas, s.JenisStudio, s.CinemaStudio, s.HargaWeekday, s.HargaWeekend);

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
                    if (!dataGridView1.Columns.Contains("btnDeleleGrid"))
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
            else
            {
                dataGridView1.DataSource = null;
            }

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
