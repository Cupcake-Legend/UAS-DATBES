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

        public void FormDaftarPegawai_Load(object sender, EventArgs e)
        {
            try
            {
                listPegawai = Pegawai.SelectDataList("", "");
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
            dataGridView1.Columns.Add("colEmail", "Email");
            dataGridView1.Columns.Add("colUsername", "Username");
            dataGridView1.Columns.Add("colPassword", "Password");
            dataGridView1.Columns.Add("colRoles", "Roles");

        }
        private void TampilDataGrid()
        {
            if(listPegawai.Count > 0)
            {
                foreach(Pegawai p in listPegawai)
                {
                    dataGridView1.Rows.Add(p.Id, p.Nama, p.Email, p.Username, p.Password, p.Roles);

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
                        bcol1.Name = "btnDelete";

                        bcol1.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol1);
                    }
                }
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
            if (e.ColumnIndex == dataGridView1.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridView1.CurrentRow.Cells["colID"].Value.ToString();
                Pegawai p = Pegawai.SelectDataSingle(kodeHapus);
                FormUbahPegawai frm = new FormUbahPegawai();
                frm.Owner = this;
                
                frm.ShowDialog();


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

        private void buttonHapus_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click_1(object sender, EventArgs e)
        {
            string filter;
            dataGridView1.Columns.Clear();
            FormatDataGrid();
            listPegawai.Clear();

            if(comboBox1.SelectedIndex == 0) //ID
            {
                filter = "pegawais.id";
                listPegawai = Pegawai.SelectDataList(filter, textBox1.Text);
                TampilDataGrid();
            }
            else if(comboBox1.SelectedIndex == 1) //Nama
            {
                filter = "pegawais.nama";
                listPegawai = Pegawai.SelectDataList(filter, textBox1.Text);
                TampilDataGrid();
            }
           

        }
    }
}
