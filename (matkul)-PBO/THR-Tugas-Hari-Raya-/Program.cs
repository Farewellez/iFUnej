using System;

namespace C_3041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pilih jenis karyawan:");
                Console.WriteLine("1. Karyawan Tetap\n2. Karyawan Kontrak\n3. Karyawan Magang");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nama Karyawan:");
                string nama = Console.ReadLine();
                Console.WriteLine("ID Karyawan:");
                string id = Console.ReadLine();

                Console.WriteLine("Gaji Pokok:");
                double gaji = Convert.ToDouble(Console.ReadLine());

                Karyawan karyawan;

                switch (pilihan)
                {
                    case 1:
                        karyawan = new Karyawan_Tetap();
                        break;
                    case 2:
                        karyawan = new Karyawan_Kontrak();
                        break;
                    case 3:
                        karyawan = new Karyawan_Magang();
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        return;
                }

                karyawan.nama = nama;
                karyawan.id = id;
                karyawan.gaji_pokok = gaji;

                Console.WriteLine("\n--- Detail Gaji ---");
                karyawan.Hitung_Gaji();
            }
            catch (FormatException)
            {
                Console.WriteLine("Input tidak valid! Pastikan kamu memasukkan angka untuk pilihan dan gaji.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi error: {ex.Message}");
            }
        }
    }
}
