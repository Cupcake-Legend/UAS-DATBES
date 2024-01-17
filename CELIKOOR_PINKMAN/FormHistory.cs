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
using iText.Layout;
using iText.Layout.Element;
using ZXing;
using iText.Kernel.Pdf;
using System.IO;
using DrawingImage = System.Drawing.Image;
using PdfImage = iText.Layout.Element.Image;
using iText.IO.Image;

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

        private void dataGridViewInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewInfo.Columns["btnPrint"].Index && e.RowIndex >= 0)
            {
                if (dataGridViewInfo.CurrentRow.Cells["colStatus"].Value.ToString() == "TERBAYAR")
                {
                    string invoiceID = dataGridViewInfo.CurrentRow.Cells["colID"].Value.ToString();

                    List<Ticket> ticketList = Ticket.SelectDataList("invoices_id", invoiceID);

                    string outputPath = "cinema_ticket.pdf";

                    using (var writer = new PdfWriter(outputPath))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {
                            var document = new Document(pdf);

                            document.Add(new Paragraph("===================================================="));

                            foreach (var ticket in ticketList)
                            {
                                document.Add(new Paragraph("Celikoor Ticket"));
                                document.Add(new Paragraph("Movie: " + ticket.SesiFilm.FilmStudio.Film.Judul));
                                document.Add(new Paragraph("Date: " + Invoice.SelectDataSingle(invoiceID).Tanggal.ToString("dd MMMM yyyy")));
                                document.Add(new Paragraph("Seat: " + ticket.NomorKursi));

                                string barcode = invoiceID.PadLeft(3, '0') + ticket.NomorKursi;

                                BarcodeWriter barcodeWriter = new BarcodeWriter();
                                barcodeWriter.Format = BarcodeFormat.CODE_128;
                                var barcodeBitmap = barcodeWriter.Write(barcode);

                                // Convert barcode to iText Image
                                using (var stream = new MemoryStream())
                                {
                                    barcodeBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                    var pdfImage = new PdfImage(ImageDataFactory.Create(stream.ToArray()));
                                    document.Add(pdfImage);
                                }
                                document.Add(new Paragraph("===================================================="));
                            }
                        }
                    }
                    MessageBox.Show("Tiket berhasil di print");
                }
                else
                {
                    MessageBox.Show("Invoice masih belum dibayar");
                }
            }
        }
    }
}
