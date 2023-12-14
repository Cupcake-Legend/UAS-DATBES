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
    public partial class FormUbahCinema : Form
    {
        public FormUbahCinema()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema c = new Cinema(int.Parse(textBoxId.Text), textBoxNama.Text, textBoxAlamat.Text, dateTimePickerTanggal.Value, textBoxKota.Text);
                Cinema.UpdateData(c);
                MessageBox.Show("Data cinema telah diubah.", "Info");
                buttonKeluar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarCinema frm = (FormDaftarCinema)this.Owner;
            frm.FormDaftarCinema_Load(buttonKeluar, e);
            this.Close();
        }
    }
}
