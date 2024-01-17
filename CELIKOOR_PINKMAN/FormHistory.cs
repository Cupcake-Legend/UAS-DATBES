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
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        List<Invoice> invoices = new List<Invoice>();


        private void FormatDataGrid()
        {
            dataGridViewInfo.Columns.Add("colID", "ID");
            dataGridViewInfo.Columns.Add("colTanggal", "Tanggal");
            dataGridViewInfo.Columns.Add("colStatus", "Status");
            dataGridViewInfo.Columns.Add("colFilm", "Film");
            dataGridViewInfo.Columns.Add("colTiket", "Tiket");
            dataGridViewInfo.AllowUserToAddRows = false;
        }
        private void TampilDataGrid()
        {
            if (invoices.Count > 0)
            {
                foreach (Invoice i in invoices)
                {
                    List<Ticket> ticketList = Ticket.SelectDataList("invoices_id", i.Id.ToString());

                    //string nokursi = "";

                    //foreach (Ticket ticket in ticketList)
                    //{
                    //    nokursi += string.Join(",", ticket.NomorKursi);
                    //}
                    
                    string nokursi = string.Join(",", ticketList);

                    dataGridViewInfo.Rows.Add(i.Id, i.Tanggal, i.Status,
                        ticketList[0].SesiFilm.FilmStudio.Film.Judul, nokursi
                        );

                    if (!dataGridViewInfo.Columns.Contains("btnPrint"))
                    {

                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Print";
                        bcol.Name = "btnPrint";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridViewInfo.Columns.Add(bcol);
                    }
                }
            }
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            FormMenu formMenu = this.MdiParent as FormMenu;
            Konsumen konsumen = formMenu.konsumenLogin;

            FormatDataGrid();

            invoices = Invoice.SelectPurchaseHistory(konsumen.Id.ToString());

            TampilDataGrid();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
