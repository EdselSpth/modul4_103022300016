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
                Console.WriteLine($"{produk,-24} | {KodeProduk.getKodeProduk(produk)}"); // Print nama produk dan kode produk
            }

            Console.WriteLine("----------------------------------------"); // Fungsi Header
            FanLaptop fan = new FanLaptop(); // Inisialisasi objek fan

            fan.getStatusFan();
            Console.WriteLine("----------------------------------------"); // Fungsi Header
            String input = " "; // Inisialisasi input
            while (input != "exit") // perulangan untuk exit
            {
                Console.WriteLine("Masukkan perintah (modeUp, modeDown, turboShortcut, exit) : ");
                input = Console.ReadLine();
                Console.WriteLine("----------------------------------------"); // Fungsi Header
                if (Enum.TryParse(input, out trigger Trigger)) // pengecekan input user berdasarkan enum trigger 
                {
                    fan.ubahStateFan(Trigger); // Mengubah Status fan dengan memanggil method ubahStateFan
                    fan.getStatusFan(); // Menampilkan Status fan dengan memangil method getStatusFan
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenali");
                }
                Console.WriteLine("----------------------------------------"); // Fungsi Header
            }
        }

    }
}