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
    public partial class FormDaftarJadwalFilm : Form
    {
        public FormDaftarJadwalFilm()
        {
            InitializeComponent();
        }
        List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();

        public void FormDaftarJadwalFilm_Load(object sender, EventArgs e)
        {
            try
            {
                listJadwalFilm = JadwalFilm.SelectDataList("", "");

                FormatDataGrid();
                TampilDataGrid();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatDataGrid()
        {
            dataGridView1.Columns.Add("colID", "ID");
            dataGridView1.Columns.Add("colTanggal", "Tanggal");
            dataGridView1.Columns.Add("colJamPemutaran", "Jam Pemutaran");
        }

        private void TampilDataGrid() 
        { 


            if (listJadwalFilm.Count > 0)
            {
                foreach(JadwalFilm j in listJadwalFilm)
                {
                    dataGridView1.Rows.Add(j.Id, j.Tanggal, j.JamPemutaran);

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

            }
            if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridView1.CurrentRow.Cells["colID"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus +
                   "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(hasil == DialogResult.Yes)
                {
                    JadwalFilm j = JadwalFilm.SelectDataSingle(kodeHapus);

                    bool success = JadwalFilm.DeleteData(j);

                    if (success)
                    {
                        MessageBox.Show("Jadwal film berhasil dihapus", "Information");
                    }
                    else
                    {
                        MessageBox.Show("Jadwal film gagal dihapus", "Error");

                    }


                }



            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string filter;
            dataGridView1.Columns.Clear();
            listJadwalFilm.Clear();

            if (comboBox1.SelectedIndex == 0) //ID
            {
                filter = "jadwal_films.id";
                listJadwalFilm = JadwalFilm.SelectDataList(filter, textBox1.Text);
                TampilDataGrid();
            }
            
        }
    }
}
