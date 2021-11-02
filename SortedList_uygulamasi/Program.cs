using System;
using System.Collections;

namespace SortedList_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitap_icerigi = new SortedList();
            kitap_icerigi.Add(1, "Önsöz");
            kitap_icerigi.Add(50, "Değişkenler");
            kitap_icerigi.Add(40, "Operatörler");
            kitap_icerigi.Add(45, "İlişkisel operatörler");

            Console.WriteLine("İçindekiler");
            Console.WriteLine(new string('-',33));
            Console.WriteLine($"{"Konular",-33} {"Sayfalar",8}\n");
            foreach (DictionaryEntry item in kitap_icerigi)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,8}");
            }
        }
    }
}
