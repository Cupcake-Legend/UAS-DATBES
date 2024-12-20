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
    public partial class FormUbahGenre : Form
    {
        public FormUbahGenre()
        {
            InitializeComponent();
        }
        public Genre genre;
        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarGenre frm = (FormDaftarGenre)this.Owner;
            frm.FormDaftarGenre_Load(buttonKeluar, e);
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            { 
                Genre g = new Genre(genre.Id, textBoxGenre.Text, textBoxDeskripsi.Text);
                Genre.EditData(g);
                MessageBox.Show("Data genre telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void FormUbahGenre_Load(object sender, EventArgs e)
        {
            textBoxID.Text = genre.Id.ToString();
            textBoxGenre.Text = genre.Nama;
            textBoxDeskripsi.Text = genre.Deskripsi;
        }
    }
}
