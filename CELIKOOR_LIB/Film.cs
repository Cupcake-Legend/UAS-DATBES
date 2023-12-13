using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Film
    {
        #region data members
        private int id;
        private string judul;
        private string sinopsis;
        private int tahun;
        private int durasi;
        private Kelompok kelompokFilm;
        private string bahasa;
        private bool isSubIndo;
        private string coverImage;
        private double diskonNominal;
        #endregion

        #region constructors
        public Film(int id, string judul, string sinopsis, int tahun, int durasi, Kelompok kelompokFilm, string bahasa, bool isSubIndo, string coverImage, double diskonNominal)
        {
            this.Id = id;
            this.Judul = judul;
            this.Sinopsis = sinopsis;
            this.Tahun = tahun;
            this.Durasi = durasi;
            this.KelompokFilm = kelompokFilm;
            this.Bahasa = bahasa;
            this.IsSubIndo = isSubIndo;
            this.CoverImage = coverImage;
            this.DiskonNominal = diskonNominal;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok KelompokFilm { get => kelompokFilm; set => kelompokFilm = value; }
        public string Bahasa 
        { 
            get => bahasa; 
            set
            {
                if (value == "EN" || value == "ID" || value == "CHN" || value == "KOR" || value == "JPN" || value == "OTH") bahasa = value;
                else throw new Exception("Bahasa hanya bisa bernilai EN / ID / CHN / KOR / JPN / OTH");
            }
        }
        public bool IsSubIndo { get => isSubIndo; set => isSubIndo = value; }
        public string CoverImage { get => coverImage;
            set
            {
                if(value != null)
                {
                    coverImage = value;
                }
                else
                {
                    coverImage = string.Empty;
                }
            }
                
                
        
        
        }
        public double DiskonNominal { get => diskonNominal;
            set
            {
                if (value > 0)
                {
                    diskonNominal = value; 

                }
                else
                {
                    value = 0;
                }
            }
        
        
        }
        #endregion

        #region methods
        public static Film SelectDataSingle(string filmID)
        {
            string sql = "SELECT * FROM films as f " +
                "INNER JOIN kelompoks AS k ON k.id = f.kelompoks_id " +
                "WHERE id = '" + filmID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Film film;

            if (hasil.Read())
            {
                Kelompok kelompok = new Kelompok(
                    (int)hasil.GetValue(10),
                    hasil.GetValue(11).ToString()
                    );

                film = new Film(
                    (int)hasil.GetValue(0),
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(),
                    (int)hasil.GetValue(3),
                    (int)hasil.GetValue(4),
                    kelompok,
                    hasil.GetValue(6).ToString(),
                    (int)hasil.GetValue(7) != 0,
                    hasil.GetValue(8).ToString(),
                    (double)hasil.GetValue(9)
                    );

                return film;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Film> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT * FROM films";
            }
            else
            {
                sql = "SELECT * FROM films as f " +
                "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Film> listFilms = new List<Film>();

            while (hasil.Read())
            {
                
                Kelompok kelompok = Kelompok.SelectDataSingle(hasil.GetValue(5).ToString());

                

                
                Film film = new Film(
                    int.Parse(hasil.GetValue(0).ToString()),
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(),
                    int.Parse(hasil.GetValue(3).ToString()),
                    int.Parse(hasil.GetValue(4).ToString()),
                    kelompok,
                    hasil.GetValue(6).ToString(),
                    int.Parse(hasil.GetValue(7).ToString()) != 0,
                    hasil.GetValue(8).ToString(),
                    double.Parse((hasil.GetValue(9).ToString())));

                listFilms.Add(film);
            }

            return listFilms;
        }

        public static bool InsertData(Film film)
        {
            string sql = "INSERT INTO " +
                "films(judul, sinopsis, tahun, durasi, kelompoks_id, bahasa, is_sub_indo, cover_image, diskon_nominal) " +
                "VALUES ('" +
                film.Judul + "', '" +
                film.Sinopsis + "', '" +
                film.tahun + "', '" +
                film.KelompokFilm.Id + "', '" +
                film.Bahasa + "', '" +
                Convert.ToInt32(film.IsSubIndo) + "', '" +
                film.CoverImage + "', '" +
                film.DiskonNominal + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(Film film)
        {
            string sql = "UPDATE films SET " +
                "judul = '" + film.Judul + "', " +
                "sinopsis = '" + film.Sinopsis + "', " +
                "tahun = '" + film.Tahun + "', " +
                "durasi = '" + film.Durasi + "', " +
                "kelompoks_id = '" + film.KelompokFilm.Id + "', " +
                "bahasa = '" + film.Bahasa + "', " +
                "is_sub_indo = '" + Convert.ToInt32(film.IsSubIndo) + "', " +
                "cover_image = '" + film.CoverImage + "', " +
                "diskon_nominal = '" + film.DiskonNominal + "' " +
                "WHERE id = '" + film.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Film films)
        {
            string sql = "DELETE FROM films WHERE id = '" + films.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
