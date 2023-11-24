using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Film
    {
        #region data members
        private int id;
        private string judul;
        private string sinopsis;
        private int tahun;
        private int durasi;
        private Kelompok kelompokFilm;
        private string bahasa;
        private bool isSubIndo;
        private string coverImage;
        private double diskonNominal;
        #endregion

        #region constructors
        public Film(int id, string judul, string sinopsis, int tahun, int durasi, Kelompok kelompokFilm, string bahasa, bool isSubIndo, string coverImage, double diskonNominal)
        {
            this.Id = id;
            this.Judul = judul;
            this.Sinopsis = sinopsis;
            this.Tahun = tahun;
            this.Durasi = durasi;
            this.KelompokFilm = kelompokFilm;
            this.Bahasa = bahasa;
            this.IsSubIndo = isSubIndo;
            this.CoverImage = coverImage;
            this.DiskonNominal = diskonNominal;
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok KelompokFilm { get => kelompokFilm; set => kelompokFilm = value; }
        public string Bahasa 
        { 
            get => bahasa; 
            set
            {
                if (value == "EN" || value == "ID" || value == "CHN" || value == "KOR" || value == "JPN" || value == "OTH") bahasa = value;
                else throw new Exception("Bahasa hanya bisa bernilai EN / ID / CHN / KOR / JPN / OTH");
            }
        }
        public bool IsSubIndo { get => isSubIndo; set => isSubIndo = value; }
        public string CoverImage { get => coverImage; set => coverImage = value; }
        public double DiskonNominal { get => diskonNominal; set => diskonNominal = value; }
        #endregion

        #region methods

        #endregion
    }
}
