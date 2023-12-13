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
    public partial class FormRegistrasi : Form
    {
        public FormRegistrasi()
        {
            InitializeComponent();
        }

        private void panelJudul_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormRegistrasi_Load(object sender, EventArgs e)
        {

        }

        private void textBoxControl1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLoginNormal frm = new FormLoginNormal();
            frm.Owner = this;
          
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxPassword.Text == textBoxUlangiPassword.Text)
                {
                    char gender;
                    if (radioButtonLaki.Checked)
                    {
                        gender = 'L';
                    }
                    else
                    {
                        gender = 'P';
                    }

                    Konsumen konsumen = new Konsumen(0, textBoxNama.Text, textBoxEmail.Text, textBoxHP.Text,
                        gender, dateTimePickerBirthDate.Value,0, textBoxUsername.Text, textBoxPassword.Text);

                    Konsumen.InsertData(konsumen);

                    MessageBox.Show("Account has been created successfully!");

                    this.Close();

                        

                }
                else
                {
                    MessageBox.Show("Password salah!", "Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan! Pesan Kesalahan: " + ex.Message, "Error");

            }
        }
    }
}
