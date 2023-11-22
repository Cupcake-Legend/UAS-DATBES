using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Aktor
    {
        #region data members
        private int id;
        private string nama;
        private DateTime tgl_Lahir;
        private char gender;
        private string negara_asal;
        #endregion

        #region constructor
        public Aktor(int id, string nama, DateTime tgl_Lahir, char gender, string negara_asal)
        {
            this.Id = id;
            this.Nama = nama;
            this.Tgl_Lahir = tgl_Lahir;
            this.Gender = gender;
            this.Negara_asal = negara_asal;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime Tgl_Lahir { get => tgl_Lahir; set => tgl_Lahir = value; }
        public char Gender
        {
            get => gender;
            set
            {
                if (value == 'L' || value == 'P') gender = value;
                else throw new Exception("Gender hanya bisa bernilai L / P");
            }
        }
        public string Negara_asal { get => negara_asal; set => negara_asal = value; }
        #endregion

        #region methods
        public static Aktor SelectDataSingle(string aktorID)
        {
            string sql = "SELECT * FROM aktors WHERE id = '" + aktorID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Aktor aktor;

            if (hasil.Read())
            {
                aktor = new Aktor(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   DateTime.Parse(hasil.GetValue(2).ToString()),
                   (char)hasil.GetValue(3),
                   hasil.GetValue(4).ToString()
                   );

                return aktor;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Aktor> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria.Length > 0)
            {
                sql = "SELECT * FROM aktors";
            }
            else
            {
                sql = "SELECT * FROM aktors " +
                    "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Aktor> listAktors = new List<Aktor>();

            while (hasil.Read())
            {
                Aktor aktor = new Aktor(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   DateTime.Parse(hasil.GetValue(2).ToString()),
                   (char)hasil.GetValue(3),
                   hasil.GetValue(4).ToString()
                   );

                listAktors.Add(aktor);
            }

            return listAktors;
        }

        public static bool InsertData(Aktor aktor)
        {
            string sql =
                "INSERT INTO aktors(nama, tgl_lahir, gender, negara_asal) " +
                "VALUES ('" +
                aktor.Nama + "', '" +
                aktor.Tgl_Lahir.ToString("yyyy-MM-dd") + "', '" +
                aktor.Gender + "', '" +
                aktor.Negara_asal + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(Aktor aktor)
        {
            string sql =
                "UPDATE aktors SET " +
                "nama = '" + aktor.Nama + "', " +
                "tgl_lahir = '" + aktor.Tgl_Lahir.ToString("yyyy-MM=dd") + "', " +
                "gender = '" + aktor.Gender + "', " +
                "negara_asal = " + aktor.Negara_asal + "' " +
                "WHERE id = '" + aktor.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Aktor aktor)
        {
            string sql = "DELETE FROM aktors WHERE id = '" + aktor.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
