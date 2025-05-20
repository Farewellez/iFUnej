using System;
using System.Data;

namespace PBO_B
{
    public class Halaman_Awal
    {
        int width;
        string greeting;
        string tambah_koleksi;
        string tampilkan_buku;
        string update_buku;
        string hapus_buku;
        string exit;
        public Halaman_Awal()
        {
            width = 50;
            greeting = "SELAMAT DATANG DI PERPUSTAKAAN";
            tambah_koleksi = "1. Tambah koleksi buku";
            tampilkan_buku = "2. Tampilkan semua buku";
            update_buku = "3. Update informasi buku";
            hapus_buku = "4. Hapus buku dari koleksi";
            exit = "5. Keluar";
        }
        public void User()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(new string ('*', width));
                Console.WriteLine($"*{greeting.PadLeft((width - greeting.Length) / 2 + greeting.Length).PadRight(width - 2)}*");
                Console.WriteLine($"*{tambah_koleksi.PadLeft((width - tambah_koleksi.Length) / 2 + tambah_koleksi.Length - 3).PadRight(width - 2)}*");
                Console.WriteLine($"*{tampilkan_buku.PadLeft((width - tampilkan_buku.Length) / 2 + tampilkan_buku.Length - 2).PadRight(width - 2)}*");
                Console.WriteLine($"*{update_buku.PadLeft((width - update_buku.Length) / 2 + update_buku.Length - 2).PadRight(width - 2)}*");
                Console.WriteLine($"*{hapus_buku.PadLeft((width - hapus_buku.Length) / 2 + hapus_buku.Length - 1).PadRight(width - 2)}*");
                Console.WriteLine($"*{exit.PadLeft((width - exit.Length) / 2 + exit.Length - 9).PadRight(width - 2)}*");
                Console.WriteLine(new string('*', width));
                Console.Write("Silahkan masukkan pilihan [1 - 5]: ");
                try
                {
                    int pilihan_user = Convert.ToInt32(Console.ReadLine());
                    switch (pilihan_user)  
                    {
                        case 1:
                            Console.WriteLine("Masuk ke class perpustakaan");
                            break;
                        case 2:
                            Console.Clear();
                            Perpustakaan.tampilkan_buku();
                            break;
                        case 3:
                            Console.WriteLine("Masuk ke class perpustakaan");
                            break;
                        case 4:
                            Console.WriteLine("Masuk ke class perpustakaan");
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine(new string('*', 50));
                            Console.WriteLine("*" + "Keluar dari program".PadLeft(33).PadRight(48) + "*");
                            Console.WriteLine(new string('*', 50));
                            Environment.Exit(3);
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(new string('*', 50));
                            Console.WriteLine("*" + "Pilihan Tidak Valid !!!".PadLeft(35).PadRight(48) + "*");
                            Console.WriteLine(new string('*', 50));
                            Console.Write("Tekan Enter: ");
                            Console.ReadLine();
                            continue;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine(new string('*', 50));
                    Console.WriteLine("*" + "!!!ERROR!!!".PadLeft(30).PadRight(48) + "*");
                    Console.WriteLine(new string('*', 50));
                    Console.Write("Tekan Enter: ");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
        }
    } 
}