using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1201230031
{
    class SimpleDataBase<T>
    {
        // Property untuk menyimpan data dan waktu input
        private List<T> storedData;
        private List<DateTime> inputDates;

        // Konstruktor
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        // Method untuk menambahkan data baru
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }

        // Method untuk mencetak semua data
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }
}
