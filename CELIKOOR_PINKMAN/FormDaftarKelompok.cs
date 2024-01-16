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
    public partial class FormDaftarKelompok : Form
    {
        public FormDaftarKelompok()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKelompok frm = new FormTambahKelompok();
            frm.Owner = this;
            frm.ShowDialog();
        }
        List<Kelompok> listKelompok = new List<Kelompok>();

        public void FormDaftarKelompok_Load(object sender, EventArgs e)
        {
            try
            {
                listKelompok = Kelompok.SelectDataKelompok("", "");
                if (listKelompok.Count > 0)
                {
                    dataGridView1.DataSource = listKelompok;
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
                string kodeHapus = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                Kelompok k = Kelompok.SelectDataSingle(kodeHapus);
                FormUbahKelompok frm = new FormUbahKelompok();
                frm.Owner = this;
                frm.kelompok = k;
                frm.ShowDialog();
                

            }
            if (e.ColumnIndex == dataGridView1.Columns["btnDeleteGrid"].Index && e.RowIndex >= 0)
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

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click_1(object sender, EventArgs e)
        {
            string filter;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            listKelompok.Clear();
            if (comboBox1.SelectedIndex == 0) //ID
            {
                filter = "kelompoks.id";
                listKelompok = Kelompok.SelectDataKelompok(filter, textBox1.Text);
                dataGridView1.DataSource = listKelompok;
                
            }
            else if (comboBox1.SelectedIndex == 1) //Nama
            {
                filter = "kelompoks.nama";
                listKelompok = Kelompok.SelectDataKelompok(filter, textBox1.Text);
                dataGridView1.DataSource = listKelompok;
            }
        }
    }
}
