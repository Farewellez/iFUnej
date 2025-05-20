using System;

namespace C_3041
{
    class Karyawan_Tetap : Karyawan
    {
        public override void Hitung_Gaji()
        {
            double bonus = 500_000;
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Gaji Akhir: {gaji_pokok + bonus}");
        }
    }
}
