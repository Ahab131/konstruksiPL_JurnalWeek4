using System;
using System.Collections.Generic;

namespace modul5_1201230031
{
    class Program
    {
        static void Main(string[] args)
        {
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