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
        public Aktor aktor;
        public FormUbahAktor()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                char gender;

                if(radioButtonPerempuan.Checked)
                {
                    gender = 'P';
                }
                else
                {
                    gender = 'L';
                }

                Aktor a = new Aktor(aktor.Id, textBoxNama.Text, dateTimePickerTanggalLahir.Value, gender, textBoxAsal.Text);
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

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarAktor frm = (FormDaftarAktor)this.Owner;
            frm.FormDaftarAktor_Load(buttonKeluar, e);
            this.Close();
        }

        private void FormUbahAktor_Load(object sender, EventArgs e)
        {
            textBoxID.Text = aktor.Id.ToString();
            textBoxNama.Text = aktor.Nama;
            textBoxAsal.Text = aktor.Negara_asal;
            if(aktor.Gender == 'L')
            {
                radioButtonLaki.Checked = true;
            }
            else
            {
                radioButtonPerempuan.Checked = true;
            }
            dateTimePickerTanggalLahir.Value = aktor.Tgl_Lahir;
            
        }
    }
}
