using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CELIKOOR_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];
            var settingsSection = userSettings.Sections["CinemaProject.db"] as ClientSettingsSection;

            string DbServer = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword;
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = strCon;
            Connect();

        }

        public MySqlConnection KoneksiDB { get => koneksiDB; set => koneksiDB = value; }

        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;




        }
    }
}
