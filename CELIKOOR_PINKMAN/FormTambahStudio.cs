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

namespace CELIKOOR_PINKMAN
{
    public partial class FormTambahStudio : Form
    {
        public FormTambahStudio()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                JenisStudio pilihanJenis = (JenisStudio)comboBoxJenisStudio.SelectedItem;
                Cinema pilihanCinema = (Cinema)comboBoxCinema.SelectedItem;

                Studio s = new Studio(0, textBoxNama.Text, (int)numUpDownKapasitas.Value, pilihanJenis,
                                        pilihanCinema, int.Parse(textBoxHargaWeekday.Text), int.Parse(textBoxHargaWeekend.Text));

                Boolean success = Studio.InsertData(s);

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