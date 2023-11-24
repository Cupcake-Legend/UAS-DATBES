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
    public partial class FormUbahAktor : Form
    {
        public FormUbahAktor()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                char gender;

                if(radioButtonFemale.Checked)
                {
                    gender = 'P';
                }
                else
                {
                    gender = 'L';
                }

                Aktor a = new Aktor(0, textBoxNama.Text, dateTimePicker1.Value, gender, textBoxAsal.Text);
                Boolean success = Aktor.UpdateData(a);

                if (success)
                {
                    MessageBox.Show("Data sukses di update!");
                }
                else
                {
                    MessageBox.Show("Data gagal di update!");
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");

            }
        }
    }
}
