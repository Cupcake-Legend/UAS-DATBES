using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Genre
    {
        #region data members
        private int id;
        private string nama;
        private string deskripsi;
        #endregion

        #region constructor
        public Genre(int id, string nama, string deskripsi)
        {
            this.Id = id;
            this.Nama = nama;
            this.Deskripsi = deskripsi;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region methods
        public static Genre SelectDataSingle(string genreID)
        {
            string sql = "SELECT * FROM genres WHERE id = '" + genreID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Genre genre;

            if (hasil.Read())
            {
                genre = new Genre(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString()
                   );

                return genre;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Genre> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria.Length > 0)
            {
                sql = "SELECT * FROM genres";
            }
            else
            {
                sql = "SELECT * FROM genres " +
                    "WHERE " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Genre> listGenres = new List<Genre>();

            while (hasil.Read())
            {
                Genre genre = new Genre(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString()
                   );

                listGenres.Add(genre);
            }

            return listGenres;
        }

        public static bool InsertData(Genre genre)
        {
            string sql =
                "INSERT INTO genres(nama, deskripsi) " +
                "VALUES ('" +
                genre.Nama + "', '" +
                genre.Deskripsi + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool EditData(Genre genre)
        {
            string sql =
                "UPDATE genres SET " +
                "nama = '" + genre.Nama + "', " +
                "deskripsi = '" + genre.Deskripsi + "'" +
                "WHERE id = '" + genre.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Genre genre)
        {
            string sql = "DELETE FROM genres WHERE id = '" + genre.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
