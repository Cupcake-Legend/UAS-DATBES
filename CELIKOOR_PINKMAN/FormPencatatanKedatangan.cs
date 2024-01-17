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
    public partial class FormPencatatanKedatangan : Form
    {
        public FormPencatatanKedatangan()
        {
            InitializeComponent();
        }

        private void labelDaftarKonsumen_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPencatatanKedatangan_Load(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string barcodeValue = textBox1.Text;

            bool sukses = Ticket.UpdateStatusHadir(barcodeValue);

            if (sukses)
            {
                MessageBox.Show("Barcode berhasil dipindai.  Selamat datang!!");
                textBox1.Text = "";
            }
            else MessageBox.Show("Barcode tidak valid. Silakan coba lagi.");
            

            // Membersihkan TextBox setelah pemindaian
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
