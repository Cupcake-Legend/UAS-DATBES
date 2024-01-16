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
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }
        List<Invoice> listInvoice = new List<Invoice>();
        private void FormKasir_Load(object sender, EventArgs e)
        {
            try
            {
                listInvoice = Invoice.SelectDataValidasi();
                FormatDataGrid();
                TampilDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        }
        private void TampilDataGrid()
        {
            if (listInvoice.Count > 0)
            {
                foreach (Invoice i in listInvoice)
                {
                    dataGridView1.Rows.Add(i.Id, i.Tanggal, i.GrandTotal, i.DiskonNominal, i.KonsumenInvoice, i.DiskonNominal, i.Kasir, i.Status, i.TicketList);

                    if (!dataGridView1.Columns.Contains("btnInvoice"))
                    {

                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Invoice";
                        bcol.Name = "btnInvoice";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);
                    }
                }
            }
        }
    }
}
