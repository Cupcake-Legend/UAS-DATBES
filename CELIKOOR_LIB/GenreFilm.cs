using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class GenreFilm
    {
        #region data members
        private Genre genre;
        #endregion

        #region constructor
        public GenreFilm(Genre genre)
        {
            this.Genre = genre;
        }
        #endregion

        #region properties
        public Genre Genre { get => genre; set => genre = value; }
        #endregion

        #region methods
        public static GenreFilm SelectDataSingle(string filmID, string genreID)
        {
            string sql = "SELECT * FROM genre_film WHERE fims_id = '" + filmID + "' AND genres_id = '" + genreID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                Genre genre = Genre.SelectDataSingle(hasil.GetValue(1).ToString());

                GenreFilm genreFilm = new GenreFilm(genre);

                return genreFilm;
            }
            else return null;
        }

        public static List<GenreFilm> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT * FROM genre_film";
            }
            else
            {
                sql = "SELECT * FROM genre_film WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<GenreFilm> genreFilms = new List<GenreFilm>();

            while (hasil.Read())
            {
                Genre genre = Genre.SelectDataSingle(hasil.GetValue(1).ToString());

                GenreFilm genreFilm = new GenreFilm(genre);

                genreFilms.Add(genreFilm);
            }

            return genreFilms;
        }

        internal static bool InsertData(string filmsID, GenreFilm genreFilm)
        {
            string sql = "INSERT INTO genre_film VALUES('" + filmsID + "', '" + genreFilm.Genre.Id + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(string filmsID, GenreFilm genreFilm) 
        {
            string sql = "UPDATE genre_film SET " +
                "genres_id = '" + genreFilm.Genre.Id + "' " +
                "WHERE films_id = '" + filmsID + "' AND genres_id = '" + genreFilm.Genre.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(string filmsID, GenreFilm genreFilm)
        {
            string sql = "DELETE FROM genre_film WHERE films_id = '" + filmsID + "' AND genres_id = '" + genreFilm.Genre.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
