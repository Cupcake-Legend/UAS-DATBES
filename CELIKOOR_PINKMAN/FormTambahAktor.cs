﻿using CELIKOOR_LIB;
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
    public partial class FormTambahAktor : Form
    {
        public FormTambahAktor()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                char gender;
                if (radioButtonMale.Checked)
                {
                    gender = 'L';
                }
                else
                {
                    gender = 'P';
                }

                Aktor a = new Aktor(0, textBoxNama.Text, dateTimePickerTanggalLahir.Value, gender, textBoxAsal.Text);
                

                Boolean success = Aktor.InsertData(a);

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

        private void dateTimePickerTanggalLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarAktor frm = (FormDaftarAktor)this.Owner;
            frm.FormDaftarAktor_Load(buttonKeluar, e);
            this.Close();
        }
    }
}
