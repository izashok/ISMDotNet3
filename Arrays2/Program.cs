using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arraysISM;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f;
            int i, minr, maxr, n;
            do
            {
                Console.WriteLine("Введите длину массива ");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);

            do
            {
                Console.WriteLine("Введите диапазон чисел");
                f = int.TryParse(Console.ReadLine(), out minr);
               
            } while (f == false);
            do
            {
                f = int.TryParse(Console.ReadLine(), out maxr);
            } while (f == false);

            int[] arr1 = new int[n];
            Random rnd = new Random();
            Random rn1 = new Random();
            for (i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(minr, maxr + 1); //+ rn1.NextDouble(); Генерація масиву+ додавання дробових чисел
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");

            }

            int d;
            arraysISM.arr1.DobMin(arr1, ref maxr, out  d);
            Console.WriteLine($"Произведение чисел после минимального ={d}");

            int ss;
            arraysISM.arr1.SumaZero(arr1, out ss);
            Console.WriteLine($"Cумма чисел между 0 ={ss}");

            int ms;
            arraysISM.arr1.SumaMinMax(arr1, out ms);
            Console.WriteLine($"Сумма между первым отриц. и вторым полож. эл. ={ms}");

            int dob;
            arraysISM.arr1.SumaMod(arr1, ref maxr, out dob);
            Console.WriteLine($"Сумма чисел между макс и мин по модулю чисел ={ss}");








        }
    }
}
