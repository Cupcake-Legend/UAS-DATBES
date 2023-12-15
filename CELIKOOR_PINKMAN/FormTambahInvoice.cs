using CELIKOOR_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELIKOOR_PINKMAN
{
    public partial class FormTambahInvoice : Form
    {
        List<Konsumen> listKonsumen = new List<Konsumen>();
        List<Pegawai> listPegawai = new List<Pegawai>();
        public FormTambahInvoice()
        {
            InitializeComponent();
        }

        private void FormTambahInvoice_Load(object sender, EventArgs e)
        {
            listKonsumen = Konsumen.SelectDataList("", "");
            comboBoxKonsumen.DataSource = listKonsumen;
            comboBoxKonsumen.DisplayMember = "nama";

            listPegawai = Pegawai.SelectDataList("", "");
            var listKasir = listPegawai.Where(p => p.Roles.Contains("KASIR")).ToList();
            comboBoxKasir.DataSource = listKasir;
            comboBoxKasir.DisplayMember = "nama";
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice i = new Invoice(0, dateTimePickerTanggal.Value, double.Parse(textBoxGrandTotal.Text),
                    double.Parse(textBoxDiskon.Text), (Konsumen)comboBoxKonsumen.SelectedItem, (Pegawai)comboBoxKasir.SelectedItem,
                    comboBoxStatus.SelectedItem.ToString());
                bool success = Invoice.InsertData(i);
                if (success)
                {
                    MessageBox.Show("Data berhasil ditambahkan!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan! Pesan kesalahan: " + ex.Message, "Error");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarInvoice frm = (FormDaftarInvoice)this.Owner;
            frm.FormDaftarInvoice_Load(buttonKeluar, e);
            this.Close();
        }
    }
}
