using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class JenisStudio
    {
        #region data members
        private int id;
        private string nama;
        private string deskripsi;
        #endregion

        #region constructors
        public JenisStudio(int id, string nama, string deskripsi)
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
        public static JenisStudio SelectDataSingle(string jenisStudioID)
        {
            string sql = "SELECT * FROM jenis_studios WHERE id = '" + jenisStudioID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            JenisStudio jenisStudio;

            if (hasil.Read())
            {
                jenisStudio = new JenisStudio(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString()
                   );

                return jenisStudio;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<JenisStudio> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT * FROM jenis_studios";
            }
            else
            {
                sql = "SELECT * FROM jenis_studios " +
                    "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JenisStudio> listJenisStudios = new List<JenisStudio>();

            while (hasil.Read())
            {
                JenisStudio jenisStudio = new JenisStudio(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString()
                   );

                listJenisStudios.Add(jenisStudio);
            }

            return listJenisStudios;
        }

        public static bool InsertData(JenisStudio jenisStudio)
        {
            string sql =
                "INSERT INTO jenis_studios(nama, deskripsi) " +
                "VALUES ('" +
                jenisStudio.Nama + "', '" +
                jenisStudio.Deskripsi + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool EditData(JenisStudio jenisStudio)
        {
            string sql =
                "UPDATE jenis_studios SET " +
                "nama = '" + jenisStudio.Nama + "', " +
                "deskripsi = '" + jenisStudio.Deskripsi + "' " +
                "WHERE id = '" + jenisStudio.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(JenisStudio jenisStudio)
        {
            string sql = "DELETE FROM jenis_studios WHERE id = '" + jenisStudio.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }
        #endregion
    }
}
