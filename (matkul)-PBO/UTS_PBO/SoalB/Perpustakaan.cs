using System;
namespace PBO_B
{
    class Perpustakaan
    {
        public static void tampilkan_buku()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Daftar semua buku".PadLeft(35));
            Console.WriteLine(new string('-', 50));
            Buku_Sejarah.ListBukuSejarah();
            Pemrograman.ListBukuPemrograman();
        }
    }
}