using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();
            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;

            //1.Yol ama uzun bir yol...

            //for (int i = 0; i < eklenecekData1 .Length ; i++)
            //{
            //    sayilarim.Add(eklenecekData1[i]);
            //}

            //2.Yol  AddRange

            sayilarim.AddRange(eklenecekData1);

            //---------------------------------------------------------------

            //int capacity = sayilarim.Capacity;
            //int count = sayilarim.Count;

            sayilarim.TrimExcess(); //Count ve Capacity değerlerini eşitler.
            int capacity = sayilarim.Capacity;
            int count = sayilarim.Count;

            //Soru ? = sayilarim koleksiyonu içerisinde bulunan datayı ekrana yazdırmak istiyorum.Bunu nasıl yapaarsınız.

            sayilarim.ForEach(i => Console.WriteLine(i));
            // => :  ilgili koleksiyon içerisinde arama yap
            // => linq konusu List<T> içerisinde

            int bulunanDeger = sayilarim[3];
            Console.WriteLine("List<T> koleksiyonu içerisinde 3. index te bulunan değer : {0}",bulunanDeger );

            sayilarim.Insert(3, 100); //3.index e 100 ekledik

            bool kontrol1 = sayilarim.Any();
            bool kontrol2 = sayilarim.Any(i => i>5); //5 elemanını içeriyor mu?

            Console.ReadKey();

        }
    }
}
