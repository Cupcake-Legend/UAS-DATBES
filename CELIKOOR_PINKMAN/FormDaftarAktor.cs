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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
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
    }
}
