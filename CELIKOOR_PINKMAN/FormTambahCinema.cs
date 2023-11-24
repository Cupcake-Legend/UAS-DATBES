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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CELIKOOR_PINKMAN
{
    public partial class FormTambahCinema : Form
    {
        public FormTambahCinema()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema c = new Cinema(0, textBoxNama.Text, textBoxAlamat.Text,  dateTimePicker1.Value,textBoxKota.Text);

                Boolean success = Cinema.InsertData(c);

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
    }
}
