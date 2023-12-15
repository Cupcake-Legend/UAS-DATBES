using CELIKOOR_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CELIKOOR_PINKMAN
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            string sql = "";
            if (comboBox1.SelectedIndex == 0) // "Film terlaris"
            {
                sql = "SELECT films.judul, SUM(films.id) as total , monthname(invoices.tanggal) as month " +
                    "FROM invoices " +
                    "INNER JOIN tikets on tikets.invoices_id = invoices.id " +
                    "INNER JOIN sesi_films as sesifilms on sesifilms.films_id = tikets.films_id " +
                    "INNER JOIN films on films.id = sesifilms.films_id " +
                    "WHERE YEAR(invoices.tanggal) = '2023' " +
                    "GROUP BY films.judul, month " +
                    "ORDER BY month desc, total desc";


                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                dataGridView1.Columns.Add("colJudul", "Judul");
                dataGridView1.Columns.Add("colTotal", "Total");
                dataGridView1.Columns.Add("colMonth", "Month");

                while (hasil.Read())
                {
                    dataGridView1.Rows.Add(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString());

                }



            }
            else if (comboBox1.SelectedIndex == 1) // "Pemasukan terbanyak dari cabang"
            {
                sql = "SELECT cinemas.nama_cabang as 'Nama Cabang' , SUM(tikets.harga) as 'Total' " +
                    "FROM tikets " +
                    "INNER JOIN sesi_films on sesi_films.films_id = tikets.films_id " +
                    "INNER JOIN film_studio on film_studio.films_id = sesi_films.films_id " +
                    "INNER JOIN studios on studios.id = film_studio.studios_id " +
                    "INNER JOIN cinemas on cinemas.id = studios.cinemas_id " +
                    "GROUP BY cinemas.nama_cabang " +
                    "ORDER BY SUM(tikets.harga) desc";

                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                dataGridView1.Columns.Add("colNama", "Nama Cabang");
                dataGridView1.Columns.Add("colTotal", "Total");

                while (hasil.Read())
                {
                    dataGridView1.Rows.Add(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                }




            }
            else if (comboBox1.SelectedIndex == 2) // "Film paling banyak jumlah ketidakhadiran"
            {
                sql = "SELECT films.judul, COUNT(tikets.status_hadir) as jumlah " +
                    "FROM tikets " +
                    "INNER JOIN sesi_films as sesifilms on sesifilms.films_id = tikets.films_id " +
                    "INNER JOIN films on films.id = sesifilms.films_id " +
                    "WHERE tikets.status_hadir = 0 " +
                    "GROUP BY films.judul " +
                    "ORDER BY jumlah DESC " +
                    "LIMIT 3 ";

                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                dataGridView1.Columns.Add("colJudul", "Judul");
                dataGridView1.Columns.Add("colJumlah", "Jumlah");

                while (hasil.Read())
                {
                    dataGridView1.Rows.Add(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                }

            }
            else if (comboBox1.SelectedIndex == 3) // "Studio dengan tingkat utilitas terendah")
            {
                sql = "SELECT cinemas.nama_cabang as 'Nama Cabang', studios.id as 'Studio ID', Monthname(invoices.tanggal) as Month, " +
                    "(SELECT SUM(studios.kapasitas)) - COUNT(tikets.status_hadir) as Jumlah " +
                    "FROM invoices " +
                    "INNER JOIN tikets on tikets.invoices_id = invoices.id " +
                    "INNER JOIN sesi_films on sesi_films.films_id = tikets.films_id " +
                    "INNER JOIN film_studio on film_studio.films_id = sesi_films.films_id " +
                    "INNER JOIN studios on studios.id = film_studio.studios_id " +
                    "INNER JOIN cinemas on cinemas.id = studios.cinemas_id " +
                    "WHERE tikets.status_hadir = '0' " +
                    "GROUP BY cinemas.nama_cabang, studios.id, Month " +
                    "ORDER BY Month DESC";
                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                dataGridView1.Columns.Add("colNama", "Nama Cabang");
                dataGridView1.Columns.Add("colStudio", "Studio ID");
                dataGridView1.Columns.Add("colMonth", "Month");
                dataGridView1.Columns.Add("colJumlah", "Jumlah");

                while (hasil.Read())
                {
                    dataGridView1.Rows.Add(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
                }




            }
            else if (comboBox1.SelectedIndex == 4) //  "Konsumen paling sering nonton comedy"
            {
                sql = "SELECT konsumens.nama, COUNT(invoices.id) as jumlah " +
                    "FROM invoices " +
                    "INNER JOIN konsumens on konsumens.id = invoices.konsumens_id " +
                    "INNER JOIN tikets on tikets.invoices_id = invoices.id " +
                    "INNER JOIN sesi_films as sesifilms on sesifilms.films_id = tikets.films_id " +
                    "INNER JOIN film_studio on film_studio.films_id = sesifilms.films_id " +
                    "INNER JOIN films on films.id = sesifilms.films_id " +
                    "INNER JOIN genre_film on genre_film.films_id = films.id " +
                    "INNER JOIN genres on genres.id = genre_film.genres_id " +
                    "WHERE genres.nama = 'Comedy' " +
                    "GROUP BY konsumens.nama " +
                    "LIMIT 10";

                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                dataGridView1.Columns.Add("colNama", "Nama");
                dataGridView1.Columns.Add("colJumlah", "Jumlah");

                while (hasil.Read())
                {
                    dataGridView1.Rows.Add(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                }

            }

        }
    }
}
