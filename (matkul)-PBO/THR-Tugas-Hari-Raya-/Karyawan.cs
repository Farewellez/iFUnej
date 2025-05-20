using System;

namespace C_3041
{
    class Karyawan
    {
        private string Nama;
        private string ID;
        private double Gaji_Pokok;

        public string nama
        {
            get { return Nama; }
            set { Nama = value; }
        }

        public string id
        {
            get { return ID; }
            set { ID = value; }
        }

        public double gaji_pokok
        {
            get { return Gaji_Pokok; }
            set { Gaji_Pokok = value; }
        }

        public virtual void Hitung_Gaji()
        {
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Gaji Akhir: {gaji_pokok}");
        }
    }
}
