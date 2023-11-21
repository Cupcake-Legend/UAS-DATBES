using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CELIKOOR_LIB;

namespace CELIKOOR_PINKMAN
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;
            try
            {
                Koneksi k = new Koneksi();
                MessageBox.Show("Connection success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        private void labelDontHaveAnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
