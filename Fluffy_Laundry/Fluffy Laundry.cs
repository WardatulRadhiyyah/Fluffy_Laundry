using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluffy_Laundry
{
    public partial class Data_Pemesanan : Form
    {
        public Data_Pemesanan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblnama_Click(object sender, EventArgs e)
        {

        }

        private void lblnohp_Click(object sender, EventArgs e)
        {

        }

        private void lblberat_Click(object sender, EventArgs e)
        {

        }

        private void lbljenis_Click(object sender, EventArgs e)
        {

        }

        private void lblhrgT_Click(object sender, EventArgs e)
        {

        }

        private void lbltgl_Click(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {

            
        }


        private void lbltglPemesanan_Click(object sender, EventArgs e)
        {

        }

        private void tbnama_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbjenispaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_pemesanan data = new Data_pemesanan();
            hitungTotal();
            hitungTanggal();
            
        }

        private void tbnohp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbberat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbhargatotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        public void hitungTotal()
        {
            Data_pemesanan data = new Data_pemesanan(tbnama.Text, tbnohp.Text, Convert.ToInt32(tbberat.Text),Convert.ToDateTime( dateTimePicker2.Text), tbjenispaket.Text);
            switch (tbjenispaket.Text)
            {
                case "Paket A":

                    Paket_A paketA = new Paket_A();
                    data.Totalbiaya = data.Berat * paketA.Hargapaket;
                    tbharga.Text = Convert.ToString(paketA.Hargapaket);
                    break;


                case "Paket B":
                    Paket_B paketB = new Paket_B();
                    data.Totalbiaya = data.Berat * paketB.Hargapaket;
                    tbharga.Text = Convert.ToString(paketB.Hargapaket);
                    break;

                case "Paket C":
                    Paket_A paketC = new Paket_A();
                    data.Totalbiaya = data.Berat * paketC.Hargapaket;
                    tbharga.Text = Convert.ToString(paketC.Hargapaket);
                    break;

             

            }

            tbhargatotal.Text = Convert.ToString(data.Totalbiaya);
        }
        public void hitungTanggal()
        {
            Data_pemesanan data = new Data_pemesanan(tbnama.Text, tbnohp.Text, Convert.ToInt32(tbberat.Text), Convert.ToDateTime(dateTimePicker2.Text), tbjenispaket.Text);
            switch (tbjenispaket.Text)
            {   
                case "Paket A":
                    Paket_A paketA = new Paket_A();
                    data.Tanggalpengambilan = data.Tanggalpemesanan.AddDays(paketA.Durasi);
                    break;
                case "Paket B":
                    Paket_B paketB = new Paket_B();
                    data.Tanggalpengambilan = data.Tanggalpemesanan.AddDays(paketB.Durasi);
                    break;

                case "Paket C":
                    Paket_A paketC = new Paket_A();
                    data.Tanggalpengambilan = data.Tanggalpemesanan.AddDays(paketC.Durasi);
                    break;
            }
            dateTimePicker1.Text = Convert.ToString(data.Tanggalpengambilan);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

