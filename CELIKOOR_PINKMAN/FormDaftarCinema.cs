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
    public partial class FormDaftarCinema : Form
    {
        public FormDaftarCinema()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahCinema frm = new FormTambahCinema();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }
    }
}
