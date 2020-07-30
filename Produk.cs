using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_19._11._2917;


namespace FinalProject_19._11._2917
{
    abstract class produk
    {
        //class abstract produk
        public string Nama { get; set; }
        public int Harga { get; set; }
        public string Model { get; set; }
        public int Jumlah { get; set; }
        public int Stock { get; set; }
        public int Total { get; set; }
        public int Ukuran { get; set; }
        public string KodeSepatu { get; set; }
        public abstract string BanyakPilihan();
        public abstract string Struk();
    }
}

