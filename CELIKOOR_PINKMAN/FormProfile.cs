﻿using CELIKOOR_LIB;
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
                buttonSimpan.Visible = false;
                char Gender;

                if(radioButtonLaki.Checked)
                {
                    Gender = 'L';

                }
                else
                {
                    Gender = 'P';
                }

                FormMenu frm = (FormMenu)this.Owner;

                if (frm.konsumenLogin != null)
                {
                    Konsumen k = new Konsumen(frm.konsumenLogin.Id, textBoxName.Text, textBoxEmail.Text,
                        textBoxPhone.Text, Gender, dateTimePickerBirthDate.Value, frm.konsumenLogin.Saldo, textBoxUsername.Text, frm.konsumenLogin.Password);
                    Boolean success = Konsumen.UpdateData(k);

                    if (success)
                    {

                        MessageBox.Show("Data berhasil di update!");
                        textBoxName.Enabled = false;
                        textBoxEmail.Enabled = false;
                        textBoxPhone.Enabled = false;
                        dateTimePickerBirthDate.Enabled = false;
                        radioButtonPerempuan.Enabled = false;
                        radioButtonLaki.Enabled = false;
                        textBoxUsername.Enabled = false;

                        frm.konsumenLogin = k;
                    }
                    else
                    {
                        MessageBox.Show("Terjadi error! Tolong melakukan update ulang");
                        textBoxName.Enabled = false;
                        textBoxEmail.Enabled = false;
                        textBoxPhone.Enabled = false;
                        dateTimePickerBirthDate.Enabled = false;
                        radioButtonPerempuan.Enabled = false;
                        radioButtonLaki.Enabled = false;
                        textBoxUsername.Enabled = false;


                    }
                }
                else if (frm.pegawaiLogin != null) 
                {
                    Pegawai p = new Pegawai(frm.pegawaiLogin.Id, textBoxName.Text, textBoxEmail.Text, textBoxUsername.Text, frm.pegawaiLogin.Password
                                , frm.pegawaiLogin.Roles);
                    Boolean success = Pegawai.UpdateData(p);

                    if (success)
                    {

                        MessageBox.Show("Data berhasil di update!");
                        textBoxName.Enabled = false;
                        textBoxEmail.Enabled = false;
                        textBoxPhone.Enabled = false;
                        dateTimePickerBirthDate.Enabled = false;
                        radioButtonPerempuan.Enabled = false;
                        radioButtonLaki.Enabled = false;
                        textBoxUsername.Enabled = false;

                        frm.pegawaiLogin = p;
                    }
                    else
                    {
                        MessageBox.Show("Terjadi error! Tolong melakukan update ulang");
                        textBoxName.Enabled = false;
                        textBoxEmail.Enabled = false;
                        textBoxPhone.Enabled = false;
                        dateTimePickerBirthDate.Enabled = false;
                        radioButtonPerempuan.Enabled = false;
                        radioButtonLaki.Enabled = false;
                        textBoxUsername.Enabled = false;
                    }
                }
                this.FormProfile_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonSimpan.Visible = true;
            textBoxName.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPhone.Enabled = false;
            textBoxUsername.Enabled = false;
            dateTimePickerBirthDate.Enabled = false;
            radioButtonPerempuan.Enabled = false;
            radioButtonLaki.Enabled = false; 
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
                    radioButtonLaki.Checked = true;
                    radioButtonPerempuan.Checked = false;
                }
                else
                {
                    radioButtonLaki.Checked = false;
                    radioButtonPerempuan.Checked = true;
                }

            }

            else if (frm.pegawaiLogin != null)
            {
                textBoxName.Text = frm.pegawaiLogin.Nama;
                textBoxUsername.Text = frm.pegawaiLogin.Username;
                textBoxEmail.Text = frm.pegawaiLogin.Email;
                textBoxPhone.Text = "";
            }
            
            

        }
    }
}
