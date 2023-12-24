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
            comboBoxJam.DisplayMember = "jamPemutaran";

            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "nama";




        }

        private void FormatDataGrid()
        {
            dataGridView1.Columns.Add("colID", "ID");
            dataGridView1.Columns["colID"].Visible = false;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Name = "colCover";
            imageCol.HeaderText = "Cover Image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Add(imageCol);

            DataGridViewTextBoxColumn judul = new DataGridViewTextBoxColumn();
            judul.Name = "colJudul";
            judul.HeaderText = "Judul";
            judul.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns.Add(judul);



            DataGridViewTextBoxColumn sinopsis = new DataGridViewTextBoxColumn();
            sinopsis.Name = "colSinopsis";
            sinopsis.HeaderText = "Sinopsis";
            sinopsis.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns.Add(sinopsis);

        }
        private void TampilDataGrid()
        {
            if(listFilm.Count > 0)
            {
                dataGridView1.RowTemplate.Height = 150;

                foreach(Film f in listFilm)
                {
                    string imagePath = f.CoverImage;
                    Bitmap image = new Bitmap(imagePath);
                    dataGridView1.Rows.Add(f.Id, image, f.Judul, f.Sinopsis);
                    

                    if (!dataGridView1.Columns.Contains("btnDetails"))
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        //nama header
                        bcol.HeaderText = "Aksi";
                        //nama tombol
                        bcol.Text = "Lihat Detail";
                        bcol.Name = "btnDetails";

                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);

                    }
                    if (!dataGridView1.Columns.Contains("btnBeli"))
                    {
                        DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                        //nama header
                        bcol1.HeaderText = "Aksi";
                        //nama tombol
                        bcol1.Text = "Beli Tiket";
                        bcol1.Name = "btnBeli";

                        bcol1.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol1);

                    }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKodeKategori = dataGridView1.CurrentRow.Cells["colID"].Value.ToString();
            Film f = Film.SelectDataSingle(pKodeKategori);

            if (e.ColumnIndex == dataGridView1.Columns["btnDetails"].Index && e.RowIndex >= 0)
            {

            }
            if (e.ColumnIndex == dataGridView1.Columns["btnBeli"].Index && e.RowIndex >= 0)
            {
                FormPemesananTiket frm = new FormPemesananTiket();
                frm.Owner = this;

                frm.film = f;

                Bitmap image = new Bitmap(f.CoverImage);
                frm.pictureBox1.Image = image;
                frm.labelKelompok.Text = f.KelompokFilm.ToString();
                
                frm.labelDurasi.Text = f.Durasi.ToString() + "  jam";
                frm.labelSipnosis.Text = f.Sinopsis.ToString();

                string genre = "";
                
                foreach(GenreFilm g in f.GenreFilmList)
                {
                    genre += g + " ";
                    

                }
                frm.labelGenre.Text = genre;
                frm.comboBoxFilm.Text = f.Judul;

                List<FilmStudio> listFilmStudio = new List<FilmStudio>();
                listFilmStudio = FilmStudio.SelectDataList("films_id", f.Id.ToString());

                frm.comboBoxStudio.SelectedIndex = -1;


                frm.comboBoxFilm.DataSource = listFilmStudio;
                frm.comboBoxFilm.DisplayMember = "Film";

               

                List<FilmStudio> listFS = new List<FilmStudio>();


                listFS = FilmStudio.SelectDataList("films_id", f.Id.ToString());


                List<Studio> listStudio = new List<Studio>();


                foreach (FilmStudio filmStudio in listFS)
                {
                    listStudio.Add(filmStudio.Studio);
                }



                frm.comboBoxCinema.DataSource = listStudio;
                frm.comboBoxCinema.DisplayMember = "cinemaStudio";




                frm.ShowDialog();

            }

        }
    }
}
