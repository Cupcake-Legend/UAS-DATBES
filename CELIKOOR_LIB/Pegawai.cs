using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Pegawai
    {
        #region data members
        private int id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string roles;
        #endregion

        #region constructor
        public Pegawai(int id, string nama, string email, string username, string password, string roles)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Roles = roles;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Roles 
        { 
            get => roles; 
            set
            {
                if (value == "ADMIN" || value == "KASIR" || value == "OPERATOR") roles = value;
                else throw new Exception("Roles hanya bisa bernilai ADMIN / KASIR / OPERATOR");
            }
        }
        #endregion

        #region methods
        public static Pegawai SelectDataSingle(string pegawaiID)
        {
            string sql = "SELECT * FROM pegawais WHERE id = '" + pegawaiID + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Pegawai pegawai;

            if (hasil.Read())
            {
                pegawai = new Pegawai(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString(),
                   hasil.GetValue(3).ToString(),
                   hasil.GetValue(4).ToString(),
                   hasil.GetValue(5).ToString()
                   );

                return pegawai;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Pegawai> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria.Length > 0)
            {
                sql = "SELECT * FROM pegawais";
            }
            else
            {
                sql = "SELECT * FROM pegawais " +
                    "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Pegawai> listPegawais = new List<Pegawai>();

            while (hasil.Read())
            {
                Pegawai pegawai = new Pegawai(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString(),
                   hasil.GetValue(3).ToString(),
                   hasil.GetValue(4).ToString(),
                   hasil.GetValue(5).ToString()
                   );

                listPegawais.Add(pegawai);
            }

            return listPegawais;
        }

        public static bool InsertData(Pegawai pegawai)
        {
            string sql =
                "INSERT INTO pegawai(nama, email, username, password, roles) " +
                "VALUES ('" +
                pegawai.Nama + "', '" +
                pegawai.Email + "', '" +
                pegawai.Username + "', '" +
                pegawai.Password + "', '" +
                pegawai.Roles + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(Pegawai pegawai)
        {
            string sql =
                "UPDATE pegawais SET " +
                "nama = '" + pegawai.Nama + "', " +
                "email = '" + pegawai.Email + "' " +
                "WHERE id = '" + pegawai.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Pegawai pegawai)
        {
            string sql = "DELETE FROM pegawais WHERE id = '" + pegawai.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static Pegawai CheckLogin(string username, string password)
        {
            string sql = "SELECT * FROM pegawais WHERE username = '" + username + "' AND password ='" + password + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString(),
                   hasil.GetValue(3).ToString(),
                   hasil.GetValue(4).ToString(),
                   hasil.GetValue(5).ToString()
                   );

                return pegawai;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
