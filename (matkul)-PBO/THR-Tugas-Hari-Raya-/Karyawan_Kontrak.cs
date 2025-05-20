using System;

namespace C_3041
{
    class Karyawan_Kontrak : Karyawan
    {
        public override void Hitung_Gaji()
        {
            double potongan = 200_000;
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Gaji Akhir: {gaji_pokok - potongan}");
        }
    }
}
