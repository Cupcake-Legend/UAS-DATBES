using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class JadwalFilm
    {
        #region data members
        private int id;
        private DateTime tanggal;
        private string jamPemutaran;
        #endregion

        #region constructors
        public JadwalFilm(int id, DateTime tanggal, string jamPemutaran)
        {
            this.Id = id;
            this.Tanggal = tanggal;
            this.JamPemutaran = jamPemutaran;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string JamPemutaran 
        { 
            get => jamPemutaran; 
            set
            {
                if (value == "I" || value == "II" || value == "III" || value == "IV") jamPemutaran = value;
                else throw new Exception("Jam_Pemutaran hanya bisa bernilai I / II / III / IV");
            }
        }
        #endregion

        #region methods
        public static JadwalFilm SelectDataSingle(string jadwalFilmID)
        {
            string sql = "SELECT * FROM jadwal_films WHERE id = '" + jadwalFilmID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            JadwalFilm jadwalFilm;

            if (hasil.Read())
            {
                jadwalFilm = new JadwalFilm(
                    (int)hasil.GetValue(0),
                    DateTime.Parse(hasil.GetValue(1).ToString()),
                    hasil.GetValue(2).ToString()
                    );

                return jadwalFilm;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<JadwalFilm> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT * FROM jadwal_films";
            }
            else
            {
                sql = "SELECT * FROM jadwal_films " +
                    "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JadwalFilm> listJadwalFilms = new List<JadwalFilm>();

            while (hasil.Read())
            {
                JadwalFilm jadwalFilm = new JadwalFilm(
                    (int)hasil.GetValue(0),
                    DateTime.Parse(hasil.GetValue(1).ToString()),
                    hasil.GetValue(2).ToString()
                    );

                listJadwalFilms.Add(jadwalFilm);
            }

            return listJadwalFilms;
        }

        public static bool InsertData(JadwalFilm jadwalFilm)
        {
            string sql = "INSERT INTO jadwal_films(tanggal, jam_pemutaran) " +
                "VALUES ('" +
                jadwalFilm.Tanggal.ToString("yyyy-MM-dd") + "', '" +
                jadwalFilm.JamPemutaran + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(JadwalFilm jadwalFilm)
        {
            string sql = "UPDATE jadwal_films SET " +
                "tanggal = '" + jadwalFilm.Tanggal.ToString("yyyy-MM-dd") + "', " +
                "jam_pemutaran = '" + jadwalFilm.JamPemutaran + "' " +
                "WHERE id = '" + jadwalFilm.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(JadwalFilm jadwalFilm) 
        {
            string sql = "DELETE FROM jadwal_films WHERE id = '" + jadwalFilm.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
