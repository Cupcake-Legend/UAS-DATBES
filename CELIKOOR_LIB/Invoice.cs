using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Invoice
    {
        #region data members
        private int id;
        private DateTime tanggal;
        private double grandTotal;
        private double diskonNominal;
        private Konsumen konsumenInvoice;
        private Pegawai kasir;
        private string status;
        #endregion

        #region constructors
        public Invoice(int id, DateTime tanggal, double grandTotal, double diskonNominal, Konsumen konsumenInvoice, Pegawai kasir, string status)
        {
            this.Id = id;
            this.Tanggal = tanggal;
            this.GrandTotal = grandTotal;
            this.DiskonNominal = diskonNominal;
            this.KonsumenInvoice = konsumenInvoice;
            this.Kasir = kasir;
            this.Status = status;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public double GrandTotal { get => grandTotal; set => grandTotal = value; }
        public double DiskonNominal { get => diskonNominal; set => diskonNominal = value; }
        public Konsumen KonsumenInvoice { get => konsumenInvoice; set => konsumenInvoice = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status 
        { 
            get => status; 
            set
            {
                if (value == "PENDING" || value == "VALIDASI" || value == "TERBAYAR") status = value;
                else throw new Exception("Status hanya dapat bernilai PENDING / VALIDASI / TERBAYAR");
            }
        }
        #endregion

        #region methods
        public static Invoice SelectDataSingle(string invoicesID)
        {
            string sql = "SELECT i.*, k.*, p.* FROM invoices AS I " +
                "INNER JOIN konsumens AS k ON k.id = i.konsumens_id " +
                "INNER JOIN pegawais AS p ON p.id = i.kasir_id " +
                "WHERE id = '" + invoicesID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Invoice invoice;

            if (hasil.Read())
            {
                Konsumen konsumen = new Konsumen(
                    (int)hasil.GetValue(7),
                    hasil.GetValue(8).ToString(),
                    hasil.GetValue(9).ToString(),
                    hasil.GetValue(10).ToString(),
                    char.Parse(hasil.GetValue(11).ToString()),
                    DateTime.Parse(hasil.GetValue(12).ToString()),
                    (double)hasil.GetValue(13),
                    hasil.GetValue(14).ToString(),
                    ""
                    );

                Pegawai kasir = new Pegawai(
                    (int)hasil.GetValue(16),
                    hasil.GetValue(17).ToString(),
                    hasil.GetValue(18).ToString(),
                    hasil.GetValue(19).ToString(),
                    "",
                    hasil.GetValue(21).ToString()
                    );

                invoice = new Invoice(
                    (int)hasil.GetValue(0),
                    DateTime.Parse(hasil.GetValue(1).ToString()),
                    (double)hasil.GetValue(2),
                    (double)hasil.GetValue(3),
                    konsumen,
                    kasir,
                    hasil.GetValue(6).ToString()
                    );

                return invoice;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Invoice> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT i.*, k.*, p.* FROM invoices AS I " +
                "INNER JOIN konsumens AS k ON k.id = i.konsumens_id " +
                "INNER JOIN pegawais AS p ON p.id = i.kasir_id";
            }
            else
            {
                sql = sql = "SELECT i.*, k.*, p.* FROM invoices AS I " +
                "INNER JOIN konsumens AS k ON k.id = i.konsumens_id " +
                "INNER JOIN pegawais AS p ON p.id = i.kasir_id " +
                "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Invoice> listInvoices = new List<Invoice>();

            while (hasil.Read())
            {
                Konsumen konsumen = new Konsumen(
                    (int)hasil.GetValue(7),
                    hasil.GetValue(8).ToString(),
                    hasil.GetValue(9).ToString(),
                    hasil.GetValue(10).ToString(),
                    char.Parse(hasil.GetValue(11).ToString()),
                    DateTime.Parse(hasil.GetValue(12).ToString()),
                    (double)hasil.GetValue(13),
                    hasil.GetValue(14).ToString(),
                    ""
                    );

                Pegawai kasir = new Pegawai(
                    (int)hasil.GetValue(16),
                    hasil.GetValue(17).ToString(),
                    hasil.GetValue(18).ToString(),
                    hasil.GetValue(19).ToString(),
                    "",
                    hasil.GetValue(21).ToString()
                    );

                Invoice invoice = new Invoice(
                    (int)hasil.GetValue(0),
                    DateTime.Parse(hasil.GetValue(1).ToString()),
                    (double)hasil.GetValue(2),
                    (double)hasil.GetValue(3),
                    konsumen,
                    kasir,
                    hasil.GetValue(6).ToString()
                    );

                listInvoices.Add(invoice);
            }

            return listInvoices;
        }

        public static bool InsertData(Invoice invoice)
        {
            string sql = "INSERT INTO " +
                "invoice(tanggal, grand_total, diskon_nominal, konsumens_id, kasir_id, status) " +
                "VALUES ('" +
                invoice.Tanggal.ToString("yyyy-MM-dd") + "', '" +
                invoice.GrandTotal + "', '" +
                invoice.DiskonNominal + "', '" +
                invoice.KonsumenInvoice.Id + "', '" +
                invoice.Kasir.Id + "', '" +
                invoice.Status + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(Invoice invoice)
        {
            string sql = "UPDATE invoices SET " +
                "tanggal = '" + invoice.Tanggal.ToString("yyyy-MM-dd") + "', " +
                "grand_total = '" + invoice.GrandTotal + "', " +
                "diskon_nominal = '" + invoice.DiskonNominal + "', " +
                "konsumens_id = '" + invoice.KonsumenInvoice.Id + "', " +
                "kasir_id = '" + invoice.Status + "' " +
                "WHERE id = '" + invoice.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Invoice invoice)
        {
            string sql = "DELETE FROM invoices WHERE id = '" + invoice.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
