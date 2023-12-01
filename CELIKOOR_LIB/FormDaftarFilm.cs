using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELIKOOR_LIB
{
    public partial class FormDaftarFilm : Form
    {
        public FormDaftarFilm()
        {
            InitializeComponent();
        }
        List<Film> listFilm = new List<Film>();

        private void FormDaftarFilm_Load(object sender, EventArgs e)
        {
            listFilm = Film.SelectDataList("", "");

            if (listFilm.Count > 0)
            {
                if(dataGridView1.ColumnCount <)



            }



        }
    }
}
