using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CELIKOOR_LIB
{
    public class Konsumen
    {
        #region data members
        private int id;
        private string nama;
        private string email;
        private string no_hp;
        private char gender;
        private DateTime tgl_Lahir;
        private double saldo;
        private string username;
        private string password;
        #endregion

        #region constructor
        public Konsumen(int id, string nama, string email, string noHp, char gender, DateTime tgl_Lahir, double saldo, string username, string password)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.No_hp = noHp;
            this.Gender = gender;
            this.Tgl_Lahir = tgl_Lahir;
            this.Saldo = saldo;
            this.Username = username;
            this.Password = password;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string No_hp { get => no_hp; set => no_hp = value; }
        public char Gender 
        { 
            get => gender; 
            set
            {
                if (value == 'L' || value == 'P') gender = value;
                else throw new Exception("Gender hanya bisa bernilai L / P");
            }
        }
        public DateTime Tgl_Lahir { get => tgl_Lahir; set => tgl_Lahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region methods
        public static Konsumen SelectDataSingle(string konsumenId)
        {
            string sql = "SELECT * FROM konsumens WHERE id = '" + konsumenId + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Konsumen konsumen;

            if (hasil.Read())
            {
                konsumen = new Konsumen(
                   (int)hasil.GetValue(0),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString(),
                   hasil.GetValue(3).ToString(),
                   (char)hasil.GetValue(4),
                   DateTime.Parse(hasil.GetValue(5).ToString()),
                   (double)hasil.GetValue(6),
                   hasil.GetValue(7).ToString(),
                   hasil.GetValue(8).ToString()
                   );

                return konsumen;
            }
            else throw new Exception("Data tidak ditemukan");
        }

        public static List<Konsumen> SelectDataList(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria.Length > 0)
            {
                sql = "SELECT * FROM konsumens";
            }
            else
            {
                sql = "SELECT * FROM konsumens " +
                    "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Konsumen> listKonsumens = new List<Konsumen>();

            while (hasil.Read())
            {
                Konsumen konsumen = new Konsumen(
                    (int)hasil.GetValue(0),
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(),
                    hasil.GetValue(3).ToString(),
                    (char)hasil.GetValue(4),
                    DateTime.Parse(hasil.GetValue(5).ToString()),
                    (double)hasil.GetValue(6),
                    hasil.GetValue(7).ToString(),
                    hasil.GetValue(8).ToString()
                    );

                listKonsumens.Add(konsumen);
            }

            return listKonsumens;
        }

        public static bool InsertData(Konsumen konsumen)
        {
            string sql = 
                "INSERT INTO konsumens(nama, email, no_hp, gender, tgl_lahir, saldo, username, password) " +
                "VALUES ('" + 
                konsumen.Nama + "', '" +
                konsumen.Email + "', '" +
                konsumen.No_hp + "', '" +
                konsumen.Gender + "', '" +
                konsumen.Tgl_Lahir.ToString("yyyy-MM-dd") + "', '" +
                konsumen.Saldo + "', '" +
                konsumen.Username + "', '" +
                konsumen.Password + "')";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool UpdateData(Konsumen konsumen)
        {
            string sql =
                "UPDATE konsumens SET " +
                "nama = '" + konsumen.Nama + "', " +
                "email = '" + konsumen.Email + "', " +
                "no_hp = '" + konsumen.No_hp + "', " +
                "gender = '" + konsumen.Gender + "', " +
                "tgl_lahir = '" + konsumen.Tgl_Lahir.ToString("yyyy-MM=dd") + "' " +
                "WHERE id = '" + konsumen.Id + "'";

            int rowsEffected = Koneksi.JalankanPerintahDML(sql);

            if (rowsEffected == 0) return false;
            else return true;
        }

        public static bool DeleteData(Konsumen konsumen)
        {
            string sql = "DELETE FROM konsumens WHERE id = '" + konsumen.Id + "'";

            int effected = Koneksi.JalankanPerintahDML(sql);

            if (effected == 0) return false;
            else return true;
        }

        public static Konsumen CheckLogin(string username, string password)
        {
            string sql = "SELECT * FROM konsumens WHERE username= '" + username + "' AND password='" + password + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                /*
                Konsumen k = new Konsumen((int)hasil.GetValue(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(),
                    hasil.GetValue(3).ToString(), (char)hasil.GetValue(4), (DateTime)hasil.GetValue(5),
                    (double)hasil.GetValue(6), hasil.GetValue(7).ToString(), hasil.GetValue(8).ToString());*/


                Konsumen konsumen = new Konsumen(
                   (int)(hasil.GetValue(0)),
                   hasil.GetValue(1).ToString(),
                   hasil.GetValue(2).ToString(),
                   hasil.GetValue(3).ToString(),
                   char.Parse(hasil.GetValue(4).ToString()),
                   DateTime.Parse(hasil.GetValue(5).ToString()),
                   double.Parse(hasil.GetValue(6).ToString()),
                   hasil.GetValue(7).ToString(),
                   hasil.GetValue(8).ToString()
                   );


                return konsumen;


            }
            else
            {
                return null;
            }



        }



        #endregion
    }
}
