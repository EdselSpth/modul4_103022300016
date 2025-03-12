using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300016
{
    internal class KodeProduk
    {
        public enum produk // Pembuatan Enum
        {
            Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera
        };

        public static String getKodeProduk(produk Produk)
        // Pembuatan method getKodeProduk Static dengan parameter produk
        {
            String[] kodeProduk = {"E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" }; // Array berisi data kodeProduk
            return kodeProduk[(int)Produk]; // Mengembalikan nilai kodeProduk sesuai dengan index Produk
        }

    }
}
