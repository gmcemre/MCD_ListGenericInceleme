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

            Console.ReadKey();

        }
    }
}
