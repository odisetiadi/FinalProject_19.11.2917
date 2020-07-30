using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_19._11._2917;
using System.ComponentModel.Design;

namespace FinalProject_19._11._2917
{
    class Program
    {
        static void Main(string[] args)
        {
            static void TampilMenu()
            {//berfungsi untuk menampilkan menu awal pada program
                Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("==                 TOKO SEPATU DWI                   ==");
                Console.WriteLine("=======================================================");
                Console.WriteLine("==         DAFTAR SEPATU  ||          HARGA          ==");
                Console.WriteLine("=======================================================");
                Console.WriteLine("== 1.      ADIDAS         ||         Rp100.000       ==");
                Console.WriteLine("== 2.       NIKE          ||         Rp130.000       ==");
                Console.WriteLine("== 3.      ARDILES        ||         Rp125.000       ==");
                Console.WriteLine("== 4.      COMPASS        ||         Rp205.000       ==");
                Console.WriteLine("== 5.      KODACHI        ||         Rp90.000        ==");
                Console.WriteLine("=======================================================");
                Console.WriteLine("== 6.                   KELUAR                       ==");
                Console.WriteLine("=======================================================");
                Console.WriteLine("==                MASUKAN PILIHAN ANDA               ==");
                Console.WriteLine("=======================================================");
            }
            Sepatu ADIDAS = new Sepatu("ADIDAS", "SPORT", 100000, 10, "AD131");//berfungsi untuk mengisikan nilai pada object sepatu
            Sepatu NIKE = new Sepatu("NIKE", "SPORT", 130000, 24, "NK23");
            Sepatu ARDILES = new Sepatu("ARDILES", "CASUAL", 125000, 20, "AR112");
            Sepatu COMPASS = new Sepatu("COMPASS", "CASUAL", 205000, 2, "CMPS13");
            Sepatu KODACHI = new Sepatu("KODACHI", "CASUAL", 90000, 32, "KDC22");

            while (true)
            {
                TampilMenu();
                Console.Write("\nPILIH [1..6]: ");
                Console.Write("MASUKKAN NOMOR = ");
                string pilih = Console.ReadLine();
                Console.Clear();
                switch (pilih)// percabangan
                {
                    default:
                        Console.WriteLine("pilihan tidak Tersedia");
                        Console.WriteLine("Tekan Enter Untuk Kembali");


                        break;



                    case "1":
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("||1.MERK=" + ADIDAS.Nama + "||MODEL=" + ADIDAS.Model + "||HARGA=" + ADIDAS.Harga + "||STOCK=" + ADIDAS.Stock + "||");
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("TEKAN ENTER UNTUK MELANJUTKAN");
                        Console.ReadLine();

                        diterima(ADIDAS);

                        break;


                    case "2":
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("||2.MERK=" + NIKE.Nama + "||MODEL=" + NIKE.Model + "||HARGA=" + NIKE.Harga + "||STOCK=" + ADIDAS.Stock + "||");
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("TEKAN ENTER UNTUK MELANJUTKAN");
                        Console.ReadLine();

                        diterima(NIKE);
                        break;

                    case "3":

                        Console.WriteLine("=======================================================");
                        Console.WriteLine("||3.MERK=" + ARDILES.Nama + "||MODEL=" + ARDILES.Model + "||HARGA=" + ARDILES.Harga + "||STOCK=" + ARDILES.Stock + "||");
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("TEKAN ENTER UNTUK MELANJUTKAN");
                        Console.ReadLine();

                        diterima(ARDILES);
                        break;

                    case "4":

                        Console.WriteLine("=======================================================");
                        Console.WriteLine("||4.MERK=" + COMPASS.Nama + "||MODEL=" + COMPASS.Model + "||HARGA=" + COMPASS.Harga + "||STOCK=" + COMPASS.Stock + "||");
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("TEKAN ENTER UNTUK MELANJUTKAN");
                        Console.ReadLine();

                        diterima(COMPASS);

                        break;
                    case "5":
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("||5.MERK=" + KODACHI.Nama + "||MODEL=" + KODACHI.Model + "||HARGA=" + KODACHI.Harga + "||STOCK=" + KODACHI.Stock + "||");
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("TEKAN ENTER UNTUK MELANJUTKAN");
                        Console.ReadLine();

                        diterima(KODACHI);
                        break;

                    case "6":
                        Console.WriteLine("TERIMA KASIH");
                        return;



                }

                Console.ReadLine();

            }
        }

        private static void diterima(produk item)//opsi yang telah kita pilih akan di proses
        {
            ukuransepatu(item);
            BerapaBanyak(item);
            terdapatinputjumlah(item);


        }




        private static void terdapatinputjumlah(produk item)//untuk memastikan ketersediaan barang
        {
           

            int inputjumlah = int.Parse(Console.ReadLine());
            item.Jumlah = inputjumlah;
            if (item.Jumlah > item.Stock)
            {
                Console.WriteLine("\nTidak Dapat Memberi {0} {1} Yang Anda Minta\nKarena Hanya Tersisa {2} Di Stock.\nKami Minta Maaf Atas Hal Ini.\n                                          Terima Kasih!", item.Jumlah, item.Nama, item.Stock);

            }
            else
            {
                
                cetakstruk(item);
            }
            item.Stock -= item.Jumlah;
            Console.WriteLine("TEKAN ENTER UNTUK KEMBALI ");

        }

        private static void ukuransepatu(produk item)//untuk menginputkan ukuran sepatu
        {
            Console.Write("MASUKAN UKURAN SEPATU ANDA [39 - 42] = ");
            int inputukuran = int.Parse(Console.ReadLine());
            item.Ukuran = inputukuran;
            if (item.Ukuran > 42)
            {
                Console.WriteLine("UKURAN TIDAK TERSEDIA");
                Console.ReadLine();
                return;
            }
            else if (item.Ukuran < 39)
            {
                Console.WriteLine("UKURAN TIDAK TERSEDIA");
                Console.ReadLine();
                return;
            }

        }
       


    private static void BerapaBanyak(produk item)//untuk menentukan banyak sepatu yang akan dibeli 
        {
            Console.Write(item.BanyakPilihan());
        }

            private static void cetakstruk(produk item)
        {
            Console.WriteLine(item.Struk());
            Console.ReadKey();
            Console.Clear();

        }


    }
}




