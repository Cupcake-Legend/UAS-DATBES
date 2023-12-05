using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class Ticket
    {
        #region data members
        private string nomorKursi;
        private bool statusHadir;
        private Pegawai pegawaiOperator;
        private double harga;
        private JadwalFilm jadwalFilm;
        private Studio studio;
        private Film film;
        #endregion

        #region constructors
        public Ticket(string nomorKursi, bool statusHadir, Pegawai pegawaiOperator, double harga, JadwalFilm jadwalFilm, Studio studio, Film film)
        {
            this.NomorKursi = nomorKursi;
            this.StatusHadir = statusHadir;
            this.PegawaiOperator = pegawaiOperator;
            this.Harga = harga;
            this.JadwalFilm = jadwalFilm;
            this.Studio = studio;
            this.Film = film;
        }
        #endregion

        #region properties
        public string NomorKursi { get => nomorKursi; set => nomorKursi = value; }
        public bool StatusHadir { get => statusHadir; set => statusHadir = value; }
        public Pegawai PegawaiOperator { get => pegawaiOperator; set => pegawaiOperator = value; }
        public double Harga { get => harga; set => harga = value; }
        public JadwalFilm JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        #endregion

        #region methods

        #endregion
    }
}
