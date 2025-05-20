using System;

namespace PBO_B
{
    class Book
    {
        protected string ID;
        protected string Judul;
        protected string Penulis;
        protected long Tahun_Terbit;
        protected string Status;
        protected Book(string id_buku, string judul_buku, string penulis_buku, long tahun_terbit_buku, string status_buku)
        {
            ID = id_buku;
            Judul = judul_buku;
            Penulis = penulis_buku;
            Tahun_Terbit = tahun_terbit_buku;
            Status = status_buku;
        }
    }
    class Buku_Sejarah : Book
    {
        private static List<Buku_Sejarah> buku_sejarah = new List<Buku_Sejarah>
        {
            new Buku_Sejarah("SH001", "Sapiens: Sejarah Singkat Umat Manusia", "Yuval Noah Harari", 2011, "Tersedia"),
            new Buku_Sejarah("SH002", "Sejarah Indonesia Modern", "M.C. Ricklefs", 2005, "Dipinjam")
        };
        public Buku_Sejarah(string id_buku, string judul_buku, string penulis_buku, long tahun_terbit_buku, string status_buku)
            : base(id_buku, judul_buku, penulis_buku, tahun_terbit_buku, status_buku){}
        public static void ListBukuSejarah()
        {
            foreach (var sejarah in buku_sejarah)
            {
                Console.WriteLine("=================================");
                Console.WriteLine($"ID buku: {sejarah.ID}");
                Console.WriteLine($"Judul buku: {sejarah.Judul}");
                Console.WriteLine($"Penulis buku: {sejarah.Penulis}");
                Console.WriteLine($"Tahun Terbit buku: {sejarah.Tahun_Terbit}");
                Console.WriteLine($"Status buku: {sejarah.Status}");
            }
        }
    }
    class Pemrograman : Book
    {
        private static List<Pemrograman> buku_pemrograman = new List<Pemrograman>
        {
            new Pemrograman("PR001","Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", 2008, "Tersedia"),
            new Pemrograman("PR002","C# in Depth", "Jon Skeet", 2008, "Dipinjam")
        };
        public Pemrograman(string id_buku, string judul_buku, string penulis_buku, long tahun_terbit_buku, string status_buku)
            : base(id_buku, judul_buku, penulis_buku, tahun_terbit_buku, status_buku){}
        public static void ListBukuPemrograman()
        {
            foreach (var pemrograman in buku_pemrograman)
            {
                Console.WriteLine("=================================");
                Console.WriteLine($"ID buku: {pemrograman.ID}");
                Console.WriteLine($"Judul buku: {pemrograman.Judul}");
                Console.WriteLine($"Penulis buku: {pemrograman.Penulis}");
                Console.WriteLine($"Tahun Terbit buku: {pemrograman.Tahun_Terbit}");
                Console.WriteLine($"Status buku: {pemrograman.Status}");
            }
        }
    }
}
