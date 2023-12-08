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
        private JadwalFilm jadwalFilm;
        private Studio studio;
        private Film film;
        #endregion

        #region constructors
        public Ticket(string nomorKursi, bool statusHadir, Pegawai pegawaiOperator, double harga, JadwalFilm jadwalFilm, Studio studio, Film film)
        {
            this.NomorKursi = nomorKursi;
            this.StatusHadir = statusHadir;
            this.PegawaiOperator = pegawaiOperator;
            this.Harga = harga;
            this.JadwalFilm = jadwalFilm;
            this.Studio = studio;
            this.Film = film;
        }
        #endregion

        #region properties
        public string NomorKursi { get => nomorKursi; set => nomorKursi = value; }
        public bool StatusHadir { get => statusHadir; set => statusHadir = value; }
        public Pegawai PegawaiOperator { get => pegawaiOperator; set => pegawaiOperator = value; }
        public double Harga { get => harga; set => harga = value; }
        public JadwalFilm JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        #endregion

        #region methods
        public static Ticket SelectDataSingle(string ticketID)
        {
            string sql = "SELECT * FROM tikets WHERE id = '" + ticketID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                Pegawai pegawai = Pegawai.SelectDataSingle(hasil.GetValue(3).ToString());

                JadwalFilm jadwalFilm = JadwalFilm.SelectDataSingle(hasil.GetValue(5).ToString());

                Studio studio = Studio.SelectDataSingle(hasil.GetValue(6).ToString());

                Film film = Film.SelectDataSingle(hasil.GetValue(7).ToString());

                Ticket ticket = new Ticket(
                    hasil.GetValue(1).ToString(),
                    (int)hasil.GetValue(2) != 0,
                    pegawai,
                    (double)hasil.GetValue(4),
                    jadwalFilm,
                    studio,
                    film
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
                sql = "SELECT * FROM tikets WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }
            
            List<Ticket> listTIckets = new List<Ticket>();

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                Pegawai pegawai = Pegawai.SelectDataSingle(hasil.GetValue(3).ToString());

                JadwalFilm jadwalFilm = JadwalFilm.SelectDataSingle(hasil.GetValue(5).ToString());

                Studio studio = Studio.SelectDataSingle(hasil.GetValue(6).ToString());

                Film film = Film.SelectDataSingle(hasil.GetValue(7).ToString());

                Ticket ticket = new Ticket(
                    hasil.GetValue(1).ToString(),
                    (int)hasil.GetValue(2) != 0,
                    pegawai,
                    (double)hasil.GetValue(4),
                    jadwalFilm,
                    studio,
                    film
                    );

                listTIckets.Add(ticket);
            }

            return listTIckets;
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
        #endregion
    }
}
