﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class SesiFilm
    {
        #region data members
        private JadwalFilm jadwalFilm;
        private FilmStudio filmStudio;
        #endregion

        #region constructor
        public SesiFilm(JadwalFilm jadwalFilm, FilmStudio filmStudio)
        {
            this.JadwalFilm = jadwalFilm;
            this.FilmStudio = filmStudio;
        }
        #endregion

        #region properties
        public FilmStudio FilmStudio { get => filmStudio; set => filmStudio = value; }
        public JadwalFilm JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        #endregion

        #region methods
        public static SesiFilm SelectDataSingle(string jadwalFilmID, string studioID, string filmID)
        {
            string sql = "SELECT * FROM sesi_films " +
                "WHERE jadwal_film_id = '" + jadwalFilmID + "' " +
                "AND studios_id = '" + studioID + "' " +
                "AND films_id = '" + filmID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                JadwalFilm jadwalFilm = JadwalFilm.SelectDataSingle(hasil.GetValue(0).ToString());

                FilmStudio filmStudio = FilmStudio.SelectDataSingle(hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString());

                SesiFilm sesiFilm = new SesiFilm(jadwalFilm, filmStudio);

                return sesiFilm;
            }
            else return null;
        }

        



        public static List<SesiFilm> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql = "SELECT * FROM sesi_films WHERE " + kriteria + " = '" + nilaiKriteria + "' ";


            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<SesiFilm> sesiFilms = new List<SesiFilm>();

            while (hasil.Read())
            {
                JadwalFilm jadwalFilm = JadwalFilm.SelectDataSingle(hasil.GetValue(0).ToString());

                FilmStudio filmStudio = FilmStudio.SelectDataSingle(hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString());

                SesiFilm sesiFilm = new SesiFilm(jadwalFilm, filmStudio);

                sesiFilms.Add(sesiFilm);
            }
            return sesiFilms;
        }

        public static bool InsertData(JadwalFilm jadwalFilm, SesiFilm sesiFilm)
        {
            string sql = "INSERT INTO sesi_films " +
                "VALUES('" +
                jadwalFilm.Id + "', '" +
                sesiFilm.filmStudio.Studio.Id + "', '" +
                sesiFilm.filmStudio.Film.Id + "')";

            int rowsEffectedJadwal = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffectedJadwal == 0) return false;
            else return true;
        }

        /*public static bool UpdateData(string jadwalFilmID, SesiFilm sesiFilm)
        {
            string sql = "UPDATE sesi_film SET " +
                "studios_id = '" + sesiFilm.FilmStudio.Studio.Id + "', " +
                "films_id = '" + sesiFilm.FilmStudio.Film.Id + "' " +
                "WHERE jadwal_film_id = '" + jadwalFilmID + "'";

            int rowsEffectedJadwal = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffectedJadwal == 0) return false;
            else return true;
        }*/

        public static bool UpdateData(SesiFilm sesiFilm, string changeAattribute)
        {
            string sql;
            if (changeAattribute == "film")
            {
                sql = "UPDATE sesi_films SET " +
                "films_id = '" + sesiFilm.FilmStudio.Film.Id + "' " +
                "WHERE studios_id = '" + sesiFilm.FilmStudio.Studio.Id + "' " +
                "AND jadwal_film_id = '" + sesiFilm.JadwalFilm.Id + "'";
            }
            else if (changeAattribute == "studio")
            {
                sql = "UPDATE sesi_films SET " +
                    "studios_id = '" + sesiFilm.FilmStudio.Studio.Id + "' " +
                    "WHERE films_id = '" + sesiFilm.FilmStudio.Film.Id + "' " +
                    "AND jadwal_film_id = '" + sesiFilm.JadwalFilm.Id + "'";
            }
            else if (changeAattribute == "jadwal-film")
            {
                sql = "UPDATE sesi_films SET " +
                    "jadwal_film_id = '" + sesiFilm.JadwalFilm.Id +  "' " +
                    "WHERE films_id = '" + sesiFilm.FilmStudio.Film.Id + "' " +
                    "AND studio_id = '" + sesiFilm.FilmStudio.Studio.Id + "'";
            }
            else throw new Exception("Attribute that wants to be changed must be either film or studio or jadwal-film");

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(SesiFilm sesiFilm)
        {
            string sql = "DELETE FROM sesi_films WHERE " +
                "studios_id = '" + sesiFilm.FilmStudio.Studio.Id + "' AND " +
                "films_id = '" + sesiFilm.FilmStudio.Film.Id + "' AND " +
                "jadwal_film_id = '" + sesiFilm.JadwalFilm.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static List<Studio> FindStudio(string filmID, string cinemasID)
        {
            string sql = "SELECT studios.id, studios.nama, cinemas.id, cinemas.nama_cabang " +
                "FROM sesi_films " +
                "INNER JOIN studios on studios.id = sesi_films.studios_id " +
                "INNER JOIN cinemas on cinemas.id = studios.cinemas_id " +
                "WHERE sesi_films.films_id = '" + filmID + "' and cinemas.id = '" + cinemasID + "' ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Studio> listStudio = new List<Studio>();

            while (hasil.Read())
            {
                Studio s = Studio.SelectDataSingle(hasil.GetValue(0).ToString());

                listStudio.Add(s);  

            }
            return listStudio;




        }

        public static List<JadwalFilm> FindFilmSchedule(FilmStudio filmStudio)
        {
            string sql = "SELECT sesi_films.jadwal_film_id " +
                "FROM sesi_films " +
                "INNER JOIN studios on studios.id = sesi_films.studios_id " +
                "INNER JOIN films on films.id = sesi_films.films_id " +
                "WHERE sesi_films.films_id = '"+ filmStudio.Film.Id +"' AND sesi_films.studios_id = '"+ filmStudio.Studio.Id +"'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JadwalFilm>listJadwalFilm = new List<JadwalFilm>();


            while (hasil.Read())
            {
                JadwalFilm jadwal = JadwalFilm.SelectDataSingle(hasil.GetValue(0).ToString());
                listJadwalFilm.Add(jadwal);
            }
            return listJadwalFilm;




        }






        #endregion
    }
}
