using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class FilmStudio
    {
        #region data members
        private Studio studio;
        private Film film;
        #endregion

        #region constructor
        public FilmStudio(Studio studio, Film film)
        {
            this.Studio = studio;
            this.Film = film;
        }
        #endregion

        #region properties
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        #endregion

        #region methods
        public static FilmStudio SelectDataSingle(string studioID, string filmID)
        {
            string sql = "SELECT * FROM film_studio WHERE studios_id = '" + studioID + "' AND films_id = '" + filmID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                Studio studio = Studio.SelectDataSingle(hasil.GetValue(0).ToString());

                Film film = Film.SelectDataSingle(hasil.GetValue(1).ToString());

                FilmStudio filmStudio = new FilmStudio(studio, film);

                return filmStudio;
            }
            else return null;
        }

        public static List<FilmStudio> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SElECT * FROM film_studio";
            }
            else
            {
                sql = "SELECT * FROM film_studio WHERE " + kriteria + " ='" + nilaiKriteria + "'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<FilmStudio> listFilmStudios = new List<FilmStudio>();

            while (hasil.Read())
            {
                Studio studio = Studio.SelectDataSingle(hasil.GetValue(0).ToString());

                Film film = Film.SelectDataSingle(hasil.GetValue(1).ToString());

                FilmStudio filmStudio = new FilmStudio(studio, film);

                listFilmStudios.Add(filmStudio);
            }
            return listFilmStudios;
        }

        public static bool InsertData(FilmStudio filmStudio)
        {
            string sql = "INSERT INTO film_studio " +
                "VALUES ('" + filmStudio.Studio.Id + "', '" + filmStudio.Film.Id + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        
        public static bool UpdateData(FilmStudio filmStudio, string changeAttribute)
        {
            string sql;
            if (changeAttribute == "film")
            {
                sql = "UPDATE film_studio SET " +
                "films_id = '" + filmStudio.Film.Id + "' " +
                "WHERE studios_id = '" + filmStudio.Studio.Id + "'";
            }
            else if (changeAttribute == "studio")
            {
                sql = "UPDATE film_studio SET " +
                    "studios_id = '" + filmStudio.Studio.Id + "' " +
                    "WHERE films_id = '" + filmStudio.Film.Id + "'";
            }
            else throw new Exception("Attribute that wants to be changed must be either film or studio");

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(FilmStudio filmStudio)
        {
            string sql = "DELETE FROM film_studio WHERE " +
                "studios_id = '" + filmStudio.Studio.Id + "' AND " +
                "films_id = '" + filmStudio.Film.Id + "'"; 
         
            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

       


        #endregion
    }
}
