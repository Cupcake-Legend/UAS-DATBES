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
        private List<GenreFilm> genreFilmList;
        private List<AktorFilm> aktorFilmList;
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
            this.GenreFilmList = new List<GenreFilm>();
            this.AktorFilmList = new List<AktorFilm>();
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

        public List<GenreFilm> GenreFilmList { get => genreFilmList; set => genreFilmList = value; }
        public List<AktorFilm> AktorFilmList { get => aktorFilmList; set => aktorFilmList = value; }
        #endregion

        #region methods
        public static Film SelectDataSingle(string filmID)
        {
            string sql = "SELECT * FROM films as f " +
                "INNER JOIN kelompoks AS k ON k.id = f.kelompoks_id " +
                "WHERE f.id = '" + filmID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Film film;

            if (hasil.Read())
            {
                Kelompok kelompok = Kelompok.SelectDataSingle(hasil.GetValue(5).ToString());


                film = new Film(
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
                "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
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

        public static List<Film>SelectDataListFilter(string aktor, string genre, DateTime tanggal, string jam, string studios)
        {
            string sql = "SELECT films.* " +
                "FROM films " +
                "INNER JOIN aktor_film on aktor_film.films_id = films.id " +
                "INNER JOIN aktors on aktors.id = aktor_film.aktors_id " +
                "INNER JOIN genre_film on genre_film.films_id = films.id " +
                "INNER JOIN genres on genres.id = genre_film.genres_id " +
                "INNER JOIN film_studio on film_studio.films_id = films.id " +
                "INNER JOIN studios on studios.id = film_studio.studios_id " +
                "INNER JOIN cinemas on cinemas.id = studios.cinemas_id " +
                "INNER JOIN sesi_films on sesi_films.films_id and sesi_films.studios_id = film_studio.films_id and film_studio.studios_id " +
                "INNER JOIN jadwal_films on jadwal_films.id = sesi_films.jadwal_film_id " +
                "WHERE aktors.nama LIKE '%"+aktor+"%' and genres.nama LIKE '%"+genre+"%' and jadwal_films.tanggal LIKE '%"+tanggal+"%' and " +
                "jadwal_films.jam_pemutaran LIKE '%"+jam+"%' and studios.nama LIKE '%"+studios+"%'";

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


        public void AddGenreFilm(Genre genre)
        {
            GenreFilm genreFilm = new GenreFilm(genre);

            this.GenreFilmList.Add(genreFilm);
        }

        public void AddAktorFilm(Aktor aktor, string peran)
        {
            AktorFilm aktorFilm = new AktorFilm(aktor, peran);

            this.AktorFilmList.Add(aktorFilm);
        }

        public static bool InsertData(Film film)
        {
            bool boolFilm = false;
            bool boolGenreFilm = false;
            bool boolAktorFilm = false;

            string sql = "INSERT INTO " +
                "films(judul, sinopsis, tahun, durasi, kelompoks_id, bahasa, is_sub_indo, cover_image, diskon_nominal) " +
                "VALUES ('" +
                film.Judul + "', '" +
                film.Sinopsis + "', '" +
                film.tahun + "', '" +
                film.Durasi + "' , '" +
                film.KelompokFilm.Id + "', '" +
                film.Bahasa + "', '" +
                Convert.ToInt32(film.IsSubIndo) + "', '" +
                film.CoverImage + "', '" +
                film.DiskonNominal + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) boolFilm = false;
            else boolFilm = true;

            string sqlID = "SELECT Max(films.id) FROM films";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sqlID);

            string filmID = "";

            if (hasil.Read())
            {
                filmID = hasil.GetValue(0).ToString();
            }

            if (boolFilm)
            {
                foreach (var genrefilm in film.GenreFilmList)
                {
                    bool tmp = GenreFilm.InsertData(filmID, genrefilm);

                    if (!tmp)
                    {
                        boolGenreFilm = false;
                        break;
                    }
                    else boolGenreFilm = true;
                }
            }

            if (boolFilm)
            {
                foreach (var aktorFilm in film.AktorFilmList)
                {
                    bool tmp = AktorFilm.InsertData(filmID, aktorFilm);

                    if (!tmp)
                    {
                        boolAktorFilm = false;
                        break;
                    }
                    else boolAktorFilm = true;
                }
            }

            if (boolFilm && boolGenreFilm && boolAktorFilm)
            {
                return true;
            }
            else return false;
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

        

        public override string ToString()
        {
            return this.Judul;
        }


        #endregion
    }
}
