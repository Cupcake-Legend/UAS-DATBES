using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class AktorFilm
    {
        #region data members
        private Aktor aktor;
        private string peran;
        #endregion

        #region constructor
        public AktorFilm(Aktor aktor, string peran)
        {
            this.Aktor = aktor;
            this.Peran = peran;
        }
        #endregion

        #region properties
        public Aktor Aktor { get => aktor; set => aktor = value; }
        public string Peran 
        { 
            get => peran;
            set
            {
                if (value == "UTAMA" || value == "PEMBANTU" || value == "FIGURAN")
                {
                    peran = value;
                }
                else throw new Exception("Peran hanya bisa bernilai UTAMA / PEMBANTU / FIGURAN");
            }
        }
        #endregion

        #region methods
        public static AktorFilm SelectDataSingle(string filmID, string aktorID)
        {
            string sql = "SELECT * FROM genre_film WHERE aktros_id = '" + aktorID + "' AND films_id = '" + filmID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                Aktor aktor = Aktor.SelectDataSingle(hasil.GetValue(0).ToString());

                AktorFilm aktorFilm = new AktorFilm(aktor, hasil.GetValue(2).ToString());

                return aktorFilm;
            }
            else return null;
        }

        public static List<AktorFilm> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT * FROM aktor_film";
            }
            else
            {
                sql = "SELECT * FROM aktor_film WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<AktorFilm> aktorFilms = new List<AktorFilm>();

            while (hasil.Read())
            {
                Aktor aktor = Aktor.SelectDataSingle(hasil.GetValue(0).ToString());

                AktorFilm aktorFilm = new AktorFilm(aktor, hasil.GetValue(2).ToString());

                aktorFilms.Add(aktorFilm);
            }

            return aktorFilms;
        }

        internal static bool InsertData(string filmID, AktorFilm aktorFilm)
        {
            string sql = "INSERT INTO aktor_film VALUES ('" + aktorFilm.Aktor.Id + "', '" + filmID + "', '" + aktorFilm.Peran + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(string filmID, AktorFilm aktorFilm)
        {
            string sql = "UPDATE aktor_film SET " +
                "aktors_id = '" + aktorFilm.Aktor.Id + "', " +
                "peran = '" + aktorFilm.Peran + "' " +
                "WHERE aktros_id = '" + aktorFilm.Aktor.Id + "' AND films_id = '" + filmID + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(string filmID, AktorFilm aktorFilm)
        {
            string sql = "DELETE FROM aktor_film WHERE aktros_id = '" + aktorFilm.Aktor.Id + "' AND films_id = '" + filmID + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
