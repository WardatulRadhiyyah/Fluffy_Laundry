using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluffy_Laundry
{
    public class Paket_cucian
    {
        private double _Hargapaket;
        private string _Jenispaket;
        private int _Durasi;

        public double Hargapaket
        {
            get { return _Hargapaket; }
            set { _Hargapaket = value; }
        }
       
        public string jenispaket
        {
            get { return _Jenispaket; }
            set { _Jenispaket = value; }
        }
        public int Durasi
        {
            get { return _Durasi; }
            set { _Durasi = value; }
        }
        public Paket_cucian() { }
        public Paket_cucian(string Jenispaket)
        
        {
            if (Jenispaket == "Paket A")
            {
                Hargapaket = 10000;
                Durasi = 3;
                jenispaket = Jenispaket;
            }
           else if (Jenispaket == "Paket B")
            {
                Hargapaket = 12000;
                Durasi = 2;
                jenispaket = Jenispaket;
            }
           else if (Jenispaket == "Paket C")
            {
                Hargapaket = 14000;
                Durasi = 1;
                jenispaket = Jenispaket;
            }
        }
    }
}
   

   
   

