using System;

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
