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

namespace CELIKOOR_PINKMAN
{
    public partial class FormLihatFilm : Form
    {
        public FormLihatFilm()
        {
            InitializeComponent();
        }
        List<Film> listFilm = new List<Film>();
        List<Genre> listGenre = new List<Genre>();
        List<Studio>listStudio = new List<Studio>();
        List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();

        private void FormLihatFilm_Load(object sender, EventArgs e)
        {
            listFilm = Film.SelectDataList("", "");
            listGenre = Genre.SelectDataList("", "");
            listStudio = Studio.SelectDataList("", "");
            listJadwalFilm = JadwalFilm.SelectDataList("", "");
            
            FormatDataGrid();
            TampilDataGrid();
            comboBoxGenre.DataSource = listGenre;
            comboBoxGenre.DisplayMember = "nama";
            
            comboBoxJam.DataSource = listJadwalFilm;
            comboBoxGenre.DisplayMember = "jamPemutaran";

            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "nama";




        }

        private void FormatDataGrid()
        {
            dataGridView1.Columns.Add("colID", "ID");
            dataGridView1.Columns.Add("colJudul", "Judul");
            dataGridView1.Columns.Add("colSinopsis", "Sinopsis");
            dataGridView1.Columns.Add("colTahun", "Tahun    ");
            dataGridView1.Columns.Add("colDurasi", "Durasi");
            dataGridView1.Columns.Add("colKelompok", "Kelompok");
            dataGridView1.Columns.Add("colBahasa", "Bahasa");
            dataGridView1.Columns.Add("colSub", "Sub-Indo");
            dataGridView1.Columns.Add("colCover", "Cover Image  ");
            dataGridView1.Columns.Add("colDiskon", "Diskon");
        }
        private void TampilDataGrid()
        {
            if(listFilm.Count > 0)
            {
                foreach(Film f in listFilm)
                {
                    dataGridView1.Rows.Add(f.Id, f.Judul, f.Sinopsis, f.Tahun, f.Durasi, f.KelompokFilm, f.Bahasa, f.IsSubIndo, f.CoverImage, f.DiskonNominal);

                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {

        }
    }
}
