using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_19._11._2917
{
    class Sepatu : produk
    {
    
        public string KodeBarang;

        public Sepatu(string nama, string model, int harga, int stock, string KodeBarang)
        {
            this.Nama = nama;
            this.Model = model;
            this.Harga = harga;
            this.Stock = stock;
            this.KodeBarang = KodeBarang;
            
            
            this.Total = this.Harga * this.Jumlah;
            

        }

        public override string BanyakPilihan()
        {
            //input berapa banyak yang ingin dibeli

            string barangpilihan = String.Format("\n\nBerapa Banyak Sepatu {0} Yang Anda Ingin Beli? : ", this.Nama);

            return barangpilihan;
        }
        public override string Struk()
        {
            //cetak pilihan pengguna saat ini


            
            this.Total = this.Harga * this.Jumlah;
            Console.Clear(); 
            string struk = String.Format("\n\n===================== Code SEPATU: {5} ===================== \n==                  {0} Harga Rp.{1}                  ==" +
            "\n==                       Ukuran {2}                           ==\n==      Sepatu Berjumlah {3} Anda Harus Membayar Rp.{4}     ==\n =============================================================== \n                  TEKAN ENTER UNTUK KEMBALI", this.Nama,this.Harga, this.Ukuran, this.Jumlah, this.Total, this.KodeBarang);

            return struk;

        }


    }


}