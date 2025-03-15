using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1201230031
{
    class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            // Gunakan dynamic untuk memungkinkan operasi matematis
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;
            return a + b + c;
        }
    }
}
