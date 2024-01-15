using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Studio
    {
        #region data members
        private int id;
        private string nama;
        private int kapasitas;
        private JenisStudio jenisStudio;
        private Cinema cinemaStudio;
        private int hargaWeekday;
        private int hargaWeekend;
        #endregion

        #region constructors
        public Studio(int id, string nama, int kapasitas, JenisStudio jenisStudio, Cinema cinemaStudio, int hargaWeekday, int hargaWeekend)
        {
            this.Id = id;
            this.Nama = nama;
            this.Kapasitas = kapasitas;
            this.JenisStudio = jenisStudio;
            this.CinemaStudio = cinemaStudio;
            this.HargaWeekday = hargaWeekday;
            this.HargaWeekend = hargaWeekend;
        }
        #endregion

        #region properies
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public JenisStudio JenisStudio { get => jenisStudio; set => jenisStudio = value; }
        public Cinema CinemaStudio { get => cinemaStudio; set => cinemaStudio = value; }
        public int HargaWeekday { get => hargaWeekday; set => hargaWeekday = value; }
        public int HargaWeekend { get => hargaWeekend; set => hargaWeekend= value; }
        #endregion

        #region methods
        public static Studio SelectDataSingle(string studioID)
        {
            string sql = "SELECT s.*, js.*, c.* FROM studios AS s " +
                "INNER JOIN jenis_studios AS js ON js.id = s.jenis_studios_id " +
                "INNER JOIN cinemas AS c ON c.id = s.cinemas_id " +
                "WHERE s.id = '" + studioID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Studio studio;

            if (hasil.Read())
            {
                JenisStudio jenisStudio = new JenisStudio(
                    (int)hasil.GetValue(7),
                    hasil.GetValue(8).ToString(),
                    hasil.GetValue(9).ToString()
                    );

                Cinema cinema = new Cinema(
                    (int)hasil.GetValue(10),
                    hasil.GetValue(11).ToString(),
                    hasil.GetValue(12).ToString(),
                    DateTime.Parse(hasil.GetValue(13).ToString()),
                    hasil.GetValue(14).ToString()
                    );

                studio = new Studio(
                    (int)hasil.GetValue(0),
                    hasil.GetValue(1).ToString(),
                    (int)hasil.GetValue(2),
                    jenisStudio,
                    cinema,
                    (int)hasil.GetValue(5),
                    (int)hasil.GetValue(6)
                    );

                return studio;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Studio> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT s.*, js.*, c.* FROM studios AS s " +
                "INNER JOIN jenis_studios AS js ON js.id = s.jenis_studios_id " +
                "INNER JOIN cinemas AS c ON c.id = s.cinemas_id";
            }
            else
            {
                sql = "SELECT s.*, js.*, c.* FROM studios AS s " +
                "INNER JOIN jenis_studios AS js ON js.id = s.jenis_studios_id " +
                "INNER JOIN cinemas AS c ON c.id = s.cinemas_id " +
                "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Studio> listStudios = new List<Studio>();

            while (hasil.Read())
            {
                JenisStudio jenisStudio = new JenisStudio(
                    (int)hasil.GetValue(7),
                    hasil.GetValue(8).ToString(),
                    hasil.GetValue(9).ToString()
                    );

                Cinema cinema = new Cinema(
                    (int)hasil.GetValue(10),
                    hasil.GetValue(11).ToString(),
                    hasil.GetValue(12).ToString(),
                    DateTime.Parse(hasil.GetValue(13).ToString()),
                    hasil.GetValue(14).ToString()
                    );

                Studio studio = new Studio(
                    (int)hasil.GetValue(0),
                    hasil.GetValue(1).ToString(),
                    (int)hasil.GetValue(2),
                    jenisStudio,
                    cinema,
                    (int)hasil.GetValue(5),
                    (int)hasil.GetValue(6)
                    );

                listStudios.Add(studio);
            }
            
            return listStudios;
        }

        public static bool InsertData(Studio studio)
        {
            string sql = "INSERT INTO studios" +
                "(nama, kapasitas, jenis_studios_id, cinema_id, harga_weekday, harga_weekend) " +
                "VALUES ('" +
                studio.Nama + "', '" +
                studio.Kapasitas + "', '" +
                studio.JenisStudio.Id + "', '" +
                studio.CinemaStudio.Id + "', '" +
                studio.HargaWeekday + "', '" +
                studio.HargaWeekend + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(Studio studio)
        {
            string sql = "UPDATE studios SET " +
                "nama = '" + studio.Nama + "', " +
                "kapasitas = '" + studio.Kapasitas + "', " +
                "jenis_studios_id = '" + studio.JenisStudio.Id + "', " +
                "cinema_id = '" + studio.CinemaStudio.Id + "', " +
                "harga_weekday = '" + studio.HargaWeekday + "', " +
                "harga_weekend = '" + studio.HargaWeekend + "' " +
                "WHERE id = '" + studio.Id;

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Studio studio)
        {
            string sql = "DELETE FROM studios WHERE id = '" + studio.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public override string ToString()
        {
            return this.Nama;
        }

        public static int GetSisaKursi(SesiFilm sesiFilm)
        {
            string sql = "SELECT cinemas.nama_cabang as 'Nama Cabang', studios.id as 'Studio ID', films.judul, jadwal_films.id, " +
                "(SELECT SUM(studios.kapasitas) FROM studios WHERE studios.id ='" + sesiFilm.FilmStudio.Studio.Id.ToString() + "') - COUNT(tikets.status_hadir) as Jumlah " +
                "FROM invoices " +
                "INNER JOIN tikets on tikets.invoices_id= invoices.id " +
                "INNER JOIN sesi_films on sesi_films.films_id = tikets.films_id and sesi_films.jadwal_film_id = tikets.jadwal_film_id and sesi_films.studios_id = tikets.studios_id " +
                "INNER JOIN film_studio on film_studio.films_id = sesi_films.films_id and film_studio.studios_id = sesi_films.studios_id " +
                "INNER JOIN films on films.id = film_studio.films_id " +
                "INNER JOIN studios on film_studio.studios_id = studios.id " +
                "INNER JOIN cinemas on cinemas.id = studios.cinemas_id " +
                "INNER JOIN jadwal_films on jadwal_films.id = sesi_films.jadwal_film_id " +
                "WHERE tikets.status_hadir = '0' and studios.id = '" + sesiFilm.FilmStudio.Studio.Id.ToString() + "' and films.id ='" + sesiFilm.FilmStudio.Film.Id.ToString() + "' AND " +
                "jadwal_films.id ='" + sesiFilm.JadwalFilm.Id.ToString() + "' " +
                "GROUP BY cinemas.nama_cabang, studios.id, films.judul";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            int sisa = sesiFilm.FilmStudio.Studio.Kapasitas;

            try
            {

                if (hasil.Read())
                {
                    if (hasil.GetValue(4) != DBNull.Value)
                    {
                        sisa = int.Parse(hasil.GetValue(4).ToString());
                    }
                    else
                    {
                        sisa = sesiFilm.FilmStudio.Studio.Kapasitas;
                    }
                }
            }
            catch
            {

                return sisa;
            }
            return sisa;



        }

        #endregion
    }
}
