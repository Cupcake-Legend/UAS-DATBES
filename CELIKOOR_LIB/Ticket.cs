using iText.IO.Source;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Ticket
    {
        #region data members
        private string nomorKursi;
        private bool statusHadir;
        private Pegawai pegawaiOperator;
        private double harga;
        private SesiFilm sesiFilm;
        #endregion

        #region constructors
        public Ticket(string nomorKursi, bool statusHadir, Pegawai pegawaiOperator, double harga, SesiFilm sesiFilm)
        {
            this.NomorKursi = nomorKursi;
            this.StatusHadir = statusHadir;
            this.PegawaiOperator = pegawaiOperator;
            this.Harga = harga;
            this.SesiFilm = sesiFilm;
        }
        #endregion

        #region properties
        public string NomorKursi { get => nomorKursi; set => nomorKursi = value; }
        public bool StatusHadir { get => statusHadir; set => statusHadir = value; }
        public Pegawai PegawaiOperator { get => pegawaiOperator; set => pegawaiOperator = value; }
        public double Harga { get => harga; set => harga = value; }
        public SesiFilm SesiFilm { get => sesiFilm; set => sesiFilm = value; }
        #endregion

        #region methods
        public static Ticket SelectDataSingle(string invoiceID, string nomorKursi)
        {
            string sql = "SELECT * FROM tikets WHERE invoices_id = '" + invoiceID + "' AND nomor_kursi = '" + nomorKursi + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                Pegawai pegawai = Pegawai.SelectDataSingle(hasil.GetValue(3).ToString());

                SesiFilm sesiFilm = SesiFilm.SelectDataSingle(hasil.GetValue(5).ToString(), hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString());

                Ticket ticket = new Ticket(
                    hasil.GetValue(1).ToString(),
                    (int)hasil.GetValue(2) != 0,
                    pegawai,
                    (double)hasil.GetValue(4),
                    sesiFilm
                    );

                return ticket;
            }
            else return null;
        }

        public static List<Ticket> SelectDataList(string kriteria, string nilaiKriteria) 
        {
            string sql;
            
            if (kriteria == "")
            {
                sql = "SELECT * FROM tikets";
            }
            else
            {
                sql = "SELECT * FROM tikets WHERE " + kriteria + " = '" + nilaiKriteria + "'";
            }
            
            List<Ticket> listTIckets = new List<Ticket>();

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                Pegawai pegawai = Pegawai.SelectDataSingle(hasil.GetValue(3).ToString());

                SesiFilm sesiFilm = SesiFilm.SelectDataSingle(hasil.GetValue(5).ToString(), hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString());

                Ticket ticket = new Ticket(
                    hasil.GetValue(1).ToString(),
                    int.Parse(hasil.GetValue(2).ToString()) != 0,
                    pegawai,
                    double.Parse(hasil.GetValue(4).ToString()),
                    sesiFilm
                    );

                listTIckets.Add(ticket);
            }

            return listTIckets;
        }

        public static bool InsertData(Ticket ticket)
        {
            string sqlInvoice = "SELECT Max(invoices.id) FROM invoices";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sqlInvoice);
            int invoicesID =0;

            if (hasil.Read())
            {
                invoicesID = int.Parse(hasil.GetValue(0).ToString());
            }

            string sql = "INSERT INTO tikets(invoices_id, nomor_kursi, status_hadir, operator_id, harga, jadwal_film_id, studios_id, films_id) " +
                        "VALUES('" +
                        invoicesID + "', '" +
                        ticket.NomorKursi + "', '" +
                        Convert.ToInt32(ticket.StatusHadir) + "', '" +
                        ticket.PegawaiOperator.Id + "', '" +
                        ticket.Harga + "', '" +
                        ticket.SesiFilm.JadwalFilm.Id + "', '" +
                        ticket.SesiFilm.FilmStudio.Studio.Id + "', '" +
                        ticket.SesiFilm.FilmStudio.Film.Id + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(string invoicesID, Ticket ticket)
        {
            string sql = "UPDATE tikets SET " +
                "status_hadir = '1'" +
                "WHERE invoices_id = '" + invoicesID + "' AND nomor_kursi = '" + ticket.NomorKursi + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(string invoicesID, Ticket ticket)
        {
            string sql = "DELETE FROM tikets WHERE invoices_id = '" + invoicesID + "' AND nomor_kursi = '" + ticket.NomorKursi + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static List<string> GetNomorKursi(Studio studios, Film films)
        {
            string sql = "SELECT tikets.nomor_kursi , studios.id, films.judul " +
                "FROM tikets " +
                "INNER JOIN sesi_films on sesi_films.films_id = tikets.films_id and sesi_films.jadwal_film_id = tikets.jadwal_film_id and sesi_films.studios_id = tikets.studios_id " +
                "INNER JOIN film_studio on film_studio.films_id = sesi_films.films_id and film_studio.studios_id = sesi_films.studios_id " +
                "INNER JOIN films on films.id = film_studio.films_id " +
                "INNER JOIN studios on film_studio.studios_id = studios.id " +
                "WHERE films.id = '" + films.Id.ToString() + "' and studios.id = '" + studios.Id.ToString() + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<string>listKursi =  new List<string>();

            while (hasil.Read())
            {
                listKursi.Add(hasil.GetValue(0).ToString());
            }
            return listKursi;





        }

        public static int UpdateStatusHadir(string barcode)
        {
            if(barcode.Length == 6)
            {
                string invoice = barcode.Substring(0, 3);
                string seat = barcode.Substring(3, 3);


            string sql = "UPDATE tikets " +
                "SET status_hadir = '1' " +
                "WHERE tikets.invoices_id = '"+invoice+"' and tikets.nomor_kursi = '"+seat+"'";

                int rows = Koneksi.JalankanPerintahDML(sql);
                return rows;
            

            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            return this.NomorKursi;
        }

        #endregion
    }
}
