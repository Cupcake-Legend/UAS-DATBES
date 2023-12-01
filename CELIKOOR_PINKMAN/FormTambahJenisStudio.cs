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
    public partial class FormTambahJenisStudio : Form
    {
        public FormTambahJenisStudio()
        {
            InitializeComponent();
        }

        private void FormTambahJenisStudio_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                JenisStudio jS = new JenisStudio(0, textBoxNama.Text, textBoxDeskripsi.Text);

                Boolean success = JenisStudio.InsertData(jS);

                if (success)
                {
                    MessageBox.Show("Data berhasil ditambahkan!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
