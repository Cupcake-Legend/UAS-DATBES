using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELIKOOR_LIB
{
    public class FilmStudio
    {
        private Studio studio;
        private Film film;

        public FilmStudio(Studio studio, Film film)
        {
            this.Studio = studio;
            this.Film = film;
        }

        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
    }
}
