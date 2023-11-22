using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Kelompok
    {
        #region data members
        private int id;
        private string nama;
        #endregion

        #region constructor
        public Kelompok(int id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region methods
        public static Kelompok SelectDataSingle(string kelompokID)
        {
            string sql = "SELECT * FROM kelompoks WHERE id = '" + kelompokID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Kelompok kelompok;

            if (hasil.Read())
            {
                kelompok = new Kelompok(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString()
                   );

                return kelompok;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Kelompok> SelectDataKelompok(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria.Length > 0)
            {
                sql = "SELECT * FROM kelompoks";
            }
            else
            {
                sql = "SELECT * FROM kelompoks " +
                    "WHERE " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Kelompok> listKelompoks = new List<Kelompok>();

            while (hasil.Read())
            {
                Kelompok kelompok = new Kelompok(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString()
                   );

                listKelompoks.Add(kelompok);
            }

            return listKelompoks;
        }

        public static bool InsertData(Kelompok kelompok)
        {
            string sql =
                "INSERT INTO kelompoks(nama) " +
                "VALUES ('" +
                kelompok.Nama + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(Kelompok kelompok)
        {
            string sql =
                "UPDATE kelompoks SET " +
                "nama = '" + kelompok.Nama + "' " +
                "WHERE id = '" + kelompok.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Kelompok kelompok)
        {
            string sql = "DELETE FROM kelompoks WHERE id = '" + kelompok.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
