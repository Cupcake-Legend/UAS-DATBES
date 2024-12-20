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
    public partial class FormDaftarCinema : Form
    {
        public FormDaftarCinema()
        {
            InitializeComponent();
        }
        List<Cinema> listCinema = new List<Cinema>();

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahCinema frm = new FormTambahCinema();
            frm.Owner = this;
            frm.ShowDialog();
        }


        public void FormDaftarCinema_Load(object sender, EventArgs e)
        {
            try
            {
                listCinema = Cinema.SelectDataList("", "");
                if (listCinema.Count > 0)
                {
                    dataGridView1.DataSource = listCinema;

                    if(dataGridView1.ColumnCount< 6)
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        //nama header
                        bcol.HeaderText = "Aksi";
                        //nama tombol
                        bcol.Text = "Ubah";
                        bcol.Name = "btnUbahGrid";

                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);

                        DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                        //nama header
                        bcol1.HeaderText = "Aksi";
                        //nama tombol
                        bcol1.Text = "Delete";
                        bcol1.Name = "btnDeleteGrid";

                        bcol1.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol1);
                    }


                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnDeleteGrid"].Index && e.RowIndex >= 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string kodeHapus = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    string namaHapus = dataGridView1.CurrentRow.Cells["nama_cabang"].Value.ToString();

                    DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus?" + kodeHapus + "-" +
                        namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hasil == DialogResult.Yes)
                    {
                        Aktor f = Aktor.SelectDataSingle(kodeHapus);
                        Boolean hapus = Aktor.DeleteData(f);

                        if (hapus)
                        {
                            MessageBox.Show("Penghapusan data berhasil");

                        }
                        else
                        {
                            MessageBox.Show("Penghapusan data gagal");
                        }
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                Cinema c = Cinema.SelectDataSingle(kodeHapus); 

                FormUbahCinema frm = new FormUbahCinema();
                frm.Owner = this;
                frm.cinema = c;
                frm.ShowDialog();

            }

                if (e.ColumnIndex == dataGridView1.Columns["btnDeleteGrid"].Index && e.RowIndex >= 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string kodeHapus = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    string namaHapus = dataGridView1.CurrentRow.Cells["nama_cabang"].Value.ToString();

                    DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus?" + kodeHapus + "-" +
                        namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hasil == DialogResult.Yes)
                    {
                        Aktor f = Aktor.SelectDataSingle(kodeHapus);
                        Boolean hapus = Aktor.DeleteData(f);

                        if (hapus)
                        {
                            MessageBox.Show("Penghapusan data berhasil");

                        }
                        else
                        {
                            MessageBox.Show("Penghapusan data gagal");
                        }
                    }
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter;
            dataGridView1.Columns.Clear();
            listCinema.Clear();

            if (comboBox1.SelectedIndex == 0) //ID
            {
                filter = "cinemas.id";
                listCinema = Cinema.SelectDataList(filter, textBox1.Text);
                dataGridView1.DataSource = listCinema;
            }
            else if (comboBox1.SelectedIndex == 1) //Nama cabang
            {
                filter = "cinemas.nama_cabang";
                listCinema = Cinema.SelectDataList(filter, textBox1.Text);
                dataGridView1.DataSource = listCinema;
            }
            else if (comboBox1.SelectedIndex == 2) //alamat
            {
                filter = "cinemas.alamat";
                listCinema = Cinema.SelectDataList(filter, textBox1.Text);
                dataGridView1.DataSource = listCinema;
            }
            else if (comboBox1.SelectedIndex == 3) //Kota
            {
                filter = "cinemas.kota";
                listCinema = Cinema.SelectDataList(filter, textBox1.Text);
                dataGridView1.DataSource = listCinema;
            }
        }
    }
}

