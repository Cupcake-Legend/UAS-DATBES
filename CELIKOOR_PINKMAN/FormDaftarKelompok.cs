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

        private void FormDaftarKelompok_Load(object sender, EventArgs e)
        {
            try
            {
                listKelompok = Kelompok.SelectDataKelompok("", "");
                if (listKelompok.Count > 0)
                {
                    dataGridView1.DataSource = listKelompok;
                    if(dataGridView1.ColumnCount < 3)
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
    }
}
