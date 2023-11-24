using CELIKOOR_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELIKOOR_PINKMAN
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                buttonSave.Visible = false;
                char Gender;

                if(radioButtonMale.Checked)
                {
                    Gender = 'L';

                }
                else
                {
                    Gender = 'P';
                }

                FormMenu frm = (FormMenu)this.Owner;

                Konsumen k = new Konsumen(frm.konsumenLogin.Id, textBoxName.Text, textBoxEmail.Text,
                    textBoxPhone.Text, Gender, dateTimePickerBirthDate.Value, frm.konsumenLogin.Saldo, textBoxUsername.Text, frm.konsumenLogin.Password);

                Boolean success = Konsumen.UpdateData(k);

                if(success)
                {

                    MessageBox.Show("Data berhasil di update!");
                    textBoxName.Enabled = false;
                    textBoxEmail.Enabled = false;
                    textBoxPhone.Enabled = false;
                    dateTimePickerBirthDate.Enabled = false;
                    radioButtonFemale.Enabled = false;
                    radioButtonMale.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Terjadi error! Tolong melakukan update ulang");
                    textBoxName.Enabled = false;
                    textBoxEmail.Enabled = false;
                    textBoxPhone.Enabled = false;
                    dateTimePickerBirthDate.Enabled = false;
                    radioButtonFemale.Enabled = false;
                    radioButtonMale.Enabled = false;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonSave.Visible = true;
            textBoxName.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPhone.Enabled = true;
            textBoxUsername.Enabled = true;
            dateTimePickerBirthDate.Enabled = true;
            radioButtonFemale.Enabled = true;
            radioButtonMale.Enabled = true; 
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            FormMenu frm = (FormMenu)this.Owner;

            


            if(frm.konsumenLogin != null)
            {
                textBoxName.Text = frm.konsumenLogin.Nama;
                textBoxUsername.Text = frm.konsumenLogin.Username;
                textBoxEmail.Text = frm.konsumenLogin.Email;
                textBoxPhone.Text = frm.konsumenLogin.No_hp;
                dateTimePickerBirthDate.Value = frm.konsumenLogin.Tgl_Lahir;
                if (frm.konsumenLogin.Gender == 'L')
                {
                    radioButtonMale.Checked = true;
                    radioButtonFemale.Checked = false;
                }
                else
                {
                    radioButtonMale.Checked = false;
                    radioButtonFemale.Checked = true;
                }

            }
            
            

        }
    }
}
