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
    public partial class FormDaftarInvoice : Form
    {
        public FormDaftarInvoice()
        {
            InitializeComponent();
        }
        List<Invoice> listInvoice = new List<Invoice>();

        public void FormDaftarInvoice_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            listInvoice = Invoice.SelectDataValidasi();

            FormatDataGrid();
            TampilDataGrid();


        }
        private void FormatDataGrid()
        {
            dataGridView1.Columns.Add("colID", "ID");
            dataGridView1.Columns.Add("colTanggal", "Tanggal");
            dataGridView1.Columns.Add("colGT", "Grand Total");
            dataGridView1.Columns.Add("colDN", "Diskon Nominal");
            dataGridView1.Columns.Add("colKonsumenInv", "Konsumen Invoice");
            dataGridView1.Columns.Add("colKasir", "Kasir");
            dataGridView1.Columns.Add("colStatus", "Status");
            dataGridView1.Columns.Add("colTiket", "Tiket");
            dataGridView1.AllowUserToAddRows= false;
        }
        private void TampilDataGrid()
        {
            if(listInvoice.Count > 0)
            {
                foreach(Invoice i in listInvoice)
                {
                    List<Ticket> ticketList = Ticket.SelectDataList("invoices_id", i.Id.ToString());

                    //string nokursi = "";

                    //foreach (Ticket ticket in ticketList)
                    //{
                    //    nokursi += string.Join(",", ticket.NomorKursi);
                    //}

                    string nokursi = string.Join(",", ticketList);



                    dataGridView1.Rows.Add(i.Id, i.Tanggal, i.GrandTotal, i.DiskonNominal, i.KonsumenInvoice, i.Kasir, i.Status, nokursi);

                    if (!dataGridView1.Columns.Contains("btnValidasi"))
                    {

                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Validasi";
                        bcol.Name = "btnValidasi";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);
                    }
                  
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnValidasi"].Index && e.RowIndex >= 0)
            {
                string validasi = dataGridView1.CurrentRow.Cells["colID"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan memvalidasi INVOICE " + validasi +
                   "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if(hasil == DialogResult.Yes)
                {
                    FormMenu frm = (FormMenu)this.MdiParent;

                    Invoice invoice = Invoice.SelectDataSingle(validasi);

                    bool success = Invoice.UpdateStatusData(invoice, frm.pegawaiLogin);

                    if (success)
                    {
                        MessageBox.Show("Invoice berhasil divalidasikan!", "Information");
                        this.FormDaftarInvoice_Load(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Invoice gagal divalidasikan!", "Error");
                    }



                }



            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string filter;
            dataGridView1.Columns.Clear();
            listInvoice.Clear();

            if (comboBox1.SelectedIndex == 0) //ID
            {
                filter = "invoice.id";
                listInvoice = Invoice.SelectDataList(filter, textBox1.Text);
                TampilDataGrid();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGarisJudul_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        private void labelDaftarInvoice_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCariBerdasarkan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
