﻿using System.Diagnostics.Tracing;
using System.Globalization;

namespace B_UTSPBO_3041
{
    // Membuat parent class Book ( Real no AI :D )
    class Book
    {
        // Membuat Atribut dari class book
        public string ID1 = "001";
        public string ID2 = "002";
        public string ID3 = "003";
        public string Judu1 = "Tutorial bahasa pemrograman jaksel";
        public string Judu2 = "1001 cara menjadi kaya dalam 1 malam";
        public string Judu3 = "Cara dapat nilai 100 di PBO 100% Real";
        public int Tahun_Terbit1 = 2005;
        public int Tahun_Terbit2 = 1945;
        public int Tahun_Terbit3 = 2025;

        // Membuat method untuk menampilkan seluruh buku di perpustakaan
        public virtual void BookList()
        {
            string[] list_buku = { " " + ID1 + " " + Judu1 + " "+ Tahun_Terbit1, ID2 + " " + Judu2 + " " + Tahun_Terbit2, ID3 + " " + Judu3 + " " + Tahun_Terbit3 }; 
            Console.WriteLine("\n");
            foreach (string buku in list_buku)
            {
                Console.WriteLine(buku);
            }
        }
    }

    /* Membuat kelas perpustakaan untuk mengelola koleksi buku dan berisi informasi 
    penting lainnya seperti nama perpustakaan dan alamat 
     */
    class Perpustakaan : Book
    {
        // Membuat atribut nama perpustakaan dan alamat
        public string Nama_Perpustakaan;
        public string Alamat;
        public string[] koleksi_buku;

        public Perpustakaan(string nama_perpustakaan, string alamat)
        {
            Nama_Perpustakaan = nama_perpustakaan;
            Alamat = alamat;
        }

        public override void BookList()
        {
            base.BookList();
            Console.WriteLine("Disini Anda bisa:\n1. Create: Menambahkan buku baru ke koleksi ");
            Console.WriteLine("2. Update: Mengubah informasi buku \n3. Delete: Menghapus buku dari koleksi ");
            Console.WriteLine($"Perpustakaan by: {Nama_Perpustakaan}; Alamat: {Alamat}");
            Console.WriteLine("> Silahkan Pilih Opsi nya [1 / 2/ 3]:");
            string user_input = Console.ReadLine();
            if (user_input == "1")
            {
                Console.WriteLine("Pilih buku baru yang mau di tambahkan ke koleksi (berdasarkan ID):\n");
                string ID_buku = Console.ReadLine();
                koleksi_buku.Append(ID_buku);

            }
            else if (user_input == "2")
            {
                Console.WriteLine("Pilih buku baru yang mau di ubah informasinya:\n");
                string Info_buku = Console.ReadLine();
            }
            else if (user_input == "3")
            {
                Console.WriteLine("Pilih buku baru yang mau di hapus:\n");
                int delete_buku = Convert.ToInt32(Console.ReadLine());
                if (delete_buku == 1 || delete_buku == 2 || delete_buku == 3)
                {
                    koleksi_buku[delete_buku] = "Lupa cara hapus list di C#, Mending python :)";
                }
            }
        }

    }
    // Class untuk menu interaktif
    public class Menu_Interaktif
    {
        public static void Menu()
        {
            // Membuat menu interaktif untuk pengguna
            Console.WriteLine("---------- SELAMAT DATANG DI E-LIBRARY ----------");
            Console.Write("Tekan enter untuk melanjutkan\n");
            Console.ReadLine();
            // Membuat sesi pilihan untuk user
            while (true)
            {
                // Membuat pilihan fitur untuk user
                Console.WriteLine("---------- SILAHKAN PILIH FITUR YANG TERSEDIA ----------");
                Console.WriteLine("Disini Anda bisa:\n1. Create: Menambahkan buku baru ke koleksi ");
                Console.WriteLine("2. Read: Menampilkan semua buku atau mencari buku berdasarkan ID/judul ");
                Console.WriteLine("3. Update: Mengubah informasi buku \n4. Delete: Menghapus buku dari koleksi ");
                // Mengambil input user
                Console.Write("Pilih (Input hanya angka): ");
                string user_choice = Console.ReadLine();
                // Membuat perkondisian dengan if
                if (user_choice == "1")
                {
                    string perpus = "UPT Perpustakaan";
                    string alamat = "Institus tegal boto, Jember, Jawa Timur";
                    Perpustakaan perpustakaan = new Perpustakaan(perpus, alamat);
                    perpustakaan.BookList();
                    break;
                }
                else if (user_choice == "2")
                {
                    // Menampilkan isi buku di perpustakaan
                    string perpus = "UPT Perpustakaan";
                    string alamat = "Institus tegal boto, Jember, Jawa Timur";
                    Perpustakaan perpustakaan = new Perpustakaan(perpus, alamat);
                    perpustakaan.BookList();
                    break;
                }
                else if (user_choice == "3")
                {
                    string perpus = "UPT Perpustakaan";
                    string alamat = "Institus tegal boto, Jember, Jawa Timur";
                    Perpustakaan perpustakaan = new Perpustakaan(perpus, alamat);
                    perpustakaan.BookList();
                    break;
                }
                else if (user_choice == "4")
                {
                    string perpus = "UPT Perpustakaan";
                    string alamat = "Institus tegal boto, Jember, Jawa Timur";
                    Perpustakaan perpustakaan = new Perpustakaan(perpus, alamat);
                    perpustakaan.BookList();
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan Tidak Valid");
                    continue;
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Menu_Interaktif.Menu(); 
        }
    }
}