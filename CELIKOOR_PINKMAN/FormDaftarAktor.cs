using CELIKOOR_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELIKOOR_PINKMAN
{
    public partial class FormDaftarAktor : Form
    {
        public FormDaftarAktor()
        {
            InitializeComponent();
        }

        public List<Aktor> listAktor = new List<Aktor>();

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahAktor frm = new FormTambahAktor();
            frm.Owner = this;
            frm.ShowDialog();   
        }

        private void FormDaftarAktor_Load(object sender, EventArgs e)
        {
            try
            {
                listAktor = Aktor.SelectDataList("", "");
                if (listAktor.Count > 0)
                {
                    dataGridView1.DataSource = listAktor;
                    if(dataGridView1.ColumnCount < 6)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBox1.Text == "ID")
            {
                kriteria = "aktors.id";
            }

            else if (comboBox1.Text == "Nama")
            {
                kriteria = "aktors.Nama";
            }
            
            else if (comboBox1.Text =="Negara Asal")
            {
                kriteria = "aktors.negara_asal";
            }
            
            listAktor = Aktor.SelectDataList(kriteria, textBox1.Text);

            if (listAktor.Count > 0)
            {
                dataGridView1.DataSource = listAktor;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKodeKategori = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            if (e.ColumnIndex == dataGridView1.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                //ambil kode dari kolom dengan nama kodekategori pada row yang sedang di click
                Aktor k = Aktor.SelectDataSingle(pKodeKategori);
                if (k != null)
                {
                    FormUbahAktor frm = new FormUbahAktor();
                    frm.Owner = this;
                    frm.textBoxId.Text = k.Id.ToString();
                    frm.textBoxNama.Text = k.Nama;
                    frm.textBoxAsal.Text = k.Negara_asal;

                    if(k.Gender == 'L')
                    {
                        frm.radioButtonMale.Checked = true;
                        frm.radioButtonFemale.Checked = false;
                    }
                    else
                    {
                        frm.radioButtonFemale.Checked = true;
                        frm.radioButtonMale.Checked = false;
                    }

                    frm.dateTimePicker1.Value = k.Tgl_Lahir;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan");
                }
            }
        }
    }
}
