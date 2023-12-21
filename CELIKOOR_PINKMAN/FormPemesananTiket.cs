using CELIKOOR_LIB;
using MySqlX.XDevAPI.Relational;
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
    public partial class FormPemesananTiket : Form
    {
        public FormPemesananTiket()
        {
            InitializeComponent();
        }
        public Film film;
        
        private void FormPemesananTiket_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void labelSisaKursi_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelA.Controls.Clear();
            panelB.Controls.Clear();
            panelC.Controls.Clear();

            Studio s = (Studio)comboBoxStudio.SelectedItem;

            labelKetKursi.Text = s.Kapasitas.ToString();

            if(dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday ||
                dateTimePicker1.Value.DayOfWeek == DayOfWeek.Tuesday ||
                dateTimePicker1.Value.DayOfWeek == DayOfWeek.Wednesday ||
                dateTimePicker1.Value.DayOfWeek == DayOfWeek.Thursday
                )
            {
                labelHarga.Text = s.HargaWeekday.ToString();

            }
            else if(dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday || dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                labelHarga.Text = s.HargaWeekend.ToString();
            }

            GenerateCheckBoxes("A", panelA);
            GenerateCheckBoxes("B", panelB);
            GenerateCheckBoxes("C", panelC);
            


        }

        private void GenerateCheckBoxes(string columnName, Panel panel)
        {
            Studio s = (Studio)comboBoxStudio.SelectedItem;
            int kapastitas = s.Kapasitas;
            int rows = (int)Math.Ceiling((decimal)kapastitas / 12);
            int limit = 4;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    int seatNumber = i * limit + j + 1;
                    CheckBox cb = new CheckBox();
                    cb.Text = seatNumber.ToString();
                    cb.AutoSize = true;
                    cb.Location = new System.Drawing.Point(10 + j * 45, 30 + i * 30);
                    cb.Name = columnName + seatNumber.ToString();
                    panel.Controls.Add(cb);


                }
            }
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {

            Studio s = (Studio)comboBoxCinema.SelectedItem;

            Cinema cinema = Cinema.SelectDataSingle(s.CinemaStudio.Id.ToString());

            List<Studio> listStudio = new List<Studio>();

            listStudio = Studio.SelectDataList("c.id", cinema.Id.ToString());

            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "nama";

            labelStudio.Text = comboBoxStudio.Text;

           

            
           

        }
    }
}
