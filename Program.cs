using System;

namespace modul4_103022300016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daftar Produk"); // Fungsi Header
            Console.WriteLine("----------------------------------------"); // Fungsi Header
            Console.WriteLine("Produk Elektronik \t | Kode Produk"); // Fungsi Header
            Console.WriteLine("----------------------------------------"); // Fungsi Header
            foreach (KodeProduk.produk produk in Enum.GetValues(typeof(KodeProduk.produk))) // Perulangan menunjukkan enum
            {
                String namaProduk = produk.ToString(); // Konversi Enum ke string
                Console.WriteLine($"{produk, -24} | {KodeProduk.getKodeProduk(produk)}"); // Print nama produk dan kode produk
            }
        }
    }
}