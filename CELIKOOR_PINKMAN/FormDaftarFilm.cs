using CELIKOOR_PINKMAN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELIKOOR_LIB
{
    public partial class FormDaftarFilm : Form
    {
        public FormDaftarFilm()
        {
            InitializeComponent();
        }
        List<Film> listFilm = new List<Film>();

        public void FormDaftarFilm_Load(object sender, EventArgs e)
        {
            listFilm = Film.SelectDataList("", "");

            FormatDataGrid();
            TampilDataGrid();




        }

        private void FormatDataGrid()
        {
            dataGridView1.Columns.Add("colID", "ID");
            dataGridView1.Columns.Add("colJudul", "Judul");
            dataGridView1.Columns.Add("colSinopsis", "Sinopsis");
            dataGridView1.Columns.Add("colTahun", "Tahun    ");
            dataGridView1.Columns.Add("colDurasi", "Durasi");
            dataGridView1.Columns.Add("colKelompok", "Kelompok");
            dataGridView1.Columns.Add("colBahasa", "Bahasa");
            dataGridView1.Columns.Add("colSub", "Sub-Indo");
            dataGridView1.Columns.Add("colCover", "Cover Image  ");
            dataGridView1.Columns.Add("colDiskon", "Diskon");
        }
        
        private void TampilDataGrid()
        {
            if (listFilm.Count > 0)
            {
                foreach (Film f in listFilm)
                {
                    dataGridView1.Rows.Add(f.Id, f.Judul, f.Sinopsis, f.Tahun, f.Durasi, f.KelompokFilm, f.Bahasa, f.IsSubIndo, f.CoverImage, f.DiskonNominal);

                    if (!dataGridView1.Columns.Contains("btnUbahGrid"))
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Ubah";
                        bcol.Name = "btnUbahGrid";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);

                    }
                    if (!dataGridView1.Columns.Contains("btnDelete"))
                    {
                        DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                        bcol1.HeaderText = "Aksi";
                        bcol1.Text = "Delete";
                        bcol1.Name = "btnDelete";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridView1.CurrentRow.Cells["colID"].Value.ToString();
                Film f = Film.SelectDataSingle(kodeHapus);
                FormUbahFilm frm = new FormUbahFilm();
                frm.Owner = this;
                frm.film = f;
                frm.ShowDialog();

            }
            if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridView1.CurrentRow.Cells["colID"].Value.ToString();
                string namaHapus = dataGridView1.CurrentRow.Cells["colJudul"].Value.ToString();
                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus?" + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(hasil == DialogResult.Yes)
                {
                    Film f = Film.SelectDataSingle(kodeHapus);

                    bool success = Film.DeleteData(f);

                    if(success)
                    {
                        MessageBox.Show("Film berhasil dihapus!", "Information");

                    }
                    else
                    {
                        MessageBox.Show("Film gagal dihapus!", "Error");

                    }



                }

            }

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
