using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Cinema
    {
        #region data members
        private int id;
        private string nama_cabang;
        private string alamat;
        private DateTime tgl_dibuka;
        private string kota;
        #endregion

        #region constructor
        public Cinema(int id, string nama_cabang, string alamat, DateTime tgl_dibuka, string kota)
        {
            this.Id = id;
            this.Nama_cabang = nama_cabang;
            this.Alamat = alamat;
            this.Tgl_dibuka = tgl_dibuka;
            this.Kota = kota;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string Nama_cabang { get => nama_cabang; set => nama_cabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime Tgl_dibuka { get => tgl_dibuka; set => tgl_dibuka = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion

        #region methods
        public static Cinema SelectDataSingle(string cinemaID)
        {
            string sql = "SELECT * FROM cinemas WHERE id = '" + cinemaID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Cinema cinama;

            if (hasil.Read())
            {
                cinama = new Cinema(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString(),
                   DateTime.Parse(hasil.GetValue(3).ToString()),
                   hasil.GetValue(4).ToString()
                   );

                return cinama;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Cinema> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria.Length > 0)
            {
                sql = "SELECT * FROM cinemas";
            }
            else
            {
                sql = "SELECT * FROM cinemas " +
                    "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Cinema> listCinemas = new List<Cinema>();

            while (hasil.Read())
            {
                Cinema cinema = new Cinema(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString(),
                   DateTime.Parse(hasil.GetValue(3).ToString()),
                   hasil.GetValue(4).ToString()
                   );

                listCinemas.Add(cinema);
            }

            return listCinemas;
        }

        public static bool InsertData(Cinema cinema)
        {;
            string sql =
                "INSERT INTO cinemas(nama_cabang, alamat, tgl_dibuka, kota) " +
                "VALUES ('" +
                cinema.Nama_cabang + "', '" +
                cinema.Alamat + "', '" +
                cinema.Tgl_dibuka.ToString("yyyy-MM-dd") + "', '" +
                cinema.Kota + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(Cinema cinema)
        {
            string sql =
                "UPDATE cinemas SET " +
                "nama_cabang = '" + cinema.Nama_cabang + "', " +
                "alamat = '" + cinema.Alamat + "', " +
                "tgl_dibuka = '" + cinema.Tgl_dibuka.ToString("yyyy-MM-dd") + "' " +
                "WHERE id = '" + cinema.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Cinema cinema)
        {
            string sql = "DELETE FROM cinemas WHERE id = '" + cinema.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
