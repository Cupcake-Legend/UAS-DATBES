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
            dataGridView1.Columns.Add("colDN", "Diskon Nominal");
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

                    string nokursi = "";

                    foreach (Ticket ticket in ticketList)
                    {
                        nokursi += ticket.NomorKursi + ", ";
                    }

                    dataGridView1.Rows.Add(i.Id, i.Tanggal, i.GrandTotal, i.DiskonNominal, i.KonsumenInvoice, i.DiskonNominal, i.Kasir, i.Status, nokursi);

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
            if (e.ColumnIndex == dataGridView1.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {

            }
            if (e.ColumnIndex == dataGridView1.Columns["btnDeleteGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridView1.CurrentRow.Cells["colID"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus INVOICE " + kodeHapus +
                   "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if(hasil == DialogResult.Yes)
                {
                    Invoice i = Invoice.SelectDataSingle(kodeHapus);

                    bool success = Invoice.DeleteData(i);

                    if (success)
                    {
                        MessageBox.Show("Invoice berhasil dihapus!", "Infomration");

                    }
                    else
                    {
                        MessageBox.Show("Invoice gagal dihapus!", "Error");
                    }



                }



            }
        }
    }
}
