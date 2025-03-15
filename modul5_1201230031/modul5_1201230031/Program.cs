using System;
using System.Collections.Generic;


namespace modul5_1201230031
{
    class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan penjumlahan = new Penjumlahan();
            int nimAkhiran = 8;

            if (nimAkhiran == 1 || nimAkhiran == 2)
            {
                float angka1 = 12.0f; 
                float angka2 = 34.0f;
                float angka3 = 56.0f;
                float hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
                Console.WriteLine($"Hasil penjumlahan (float): {hasil}");
            }
            else if (nimAkhiran == 3 || nimAkhiran == 4 || nimAkhiran == 5)
            {
                double angka1 = 12.0; 
                double angka2 = 34.0;
                double angka3 = 56.0;
                double hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
                Console.WriteLine($"Hasil penjumlahan (double): {hasil}");
            }
            else if (nimAkhiran == 6 || nimAkhiran == 7 || nimAkhiran == 8)
            {
                int angka1 = 12; 
                int angka2 = 34;
                int angka3 = 56;
                int hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
                Console.WriteLine($"Hasil penjumlahan (int): {hasil}");
            }
            else if (nimAkhiran == 9 || nimAkhiran == 0)
            {
                long angka1 = 12L;
                long angka2 = 34L;
                long angka3 = 56L;
                long hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
                Console.WriteLine($"Hasil penjumlahan (long): {hasil}");
            }
            else
            {
                Console.WriteLine("Digit terakhir NIM tidak valid.");
            }
        }
    }
}
            // Buat instance dari SimpleDataBase dengan tipe data sesuai NIM
            SimpleDataBase<int> database = new SimpleDataBase<int>();

            // Contoh NIM: 12345678 (digit terakhir adalah 8)
            // Berdasarkan aturan, NIM berakhiran 6, 7, atau 8 menggunakan tipe data int
            int nimAkhiran = 8; // Ganti dengan digit terakhir NIM Anda

            // Tambahkan tiga data sesuai 2-digit NIM
            database.AddNewData(12); // Contoh input
            database.AddNewData(34);
            database.AddNewData(56);

            // Cetak semua data
            database.PrintAllData();
        }
    }
}
