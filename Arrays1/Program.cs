using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, minr, maxr, S1, maxE, maxEn, mod, modn, S2;
            bool f;

            do
            {
                Console.WriteLine("Введите длину массива ");
                f = int.TryParse(Console.ReadLine(), out n);
             } while(f == false) ;

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
            for (i = 0; i< arr1.Length; i++)
            {
                arr1[i] = rnd.Next(minr, maxr + 1); //+ rn1.NextDouble(); Генерація масиву+ додавання дробових чисел
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");

            }
            S1 = 0; // Сума елементів менших за 0 початок
            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < 0)
                {
                    S1 = S1 + arr1[i];
                }
            
            }
            Console.WriteLine("Сума элемент. <0 ={0}" , S1); // Сума елементів менших за 0 кінець
            maxEn = 0;

            maxE = minr;// Найбільший елемент початок
            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > maxE)
                { 
                maxE = arr1[i];
                maxEn = i;
                }
            }

            Console.WriteLine("Максимальный элемент и его индекс = {0} [{1}]" , maxE, maxEn);// Найбільший елемент кінець

            mod = 0;//Найбільший елемент по модулю початок
            modn = 0;
            for (i = 0; i < arr1.Length; i++)
            {
                if (Math.Abs(arr1[i]) > mod)
                {
                   mod=Math.Abs(arr1[i]);
                    modn = i;
                }
            }
            Console.WriteLine("Максимальный элемент по модулю его индекс = {0} [{1}]", -mod, modn);// Найбільший елемент по модулю кінець

            S2 = 0;// Сума індексів додатніх елементів
            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                {
                    S2 = S2 + i;
                }
            }
            Console.WriteLine("Сума индексов чисел >0 = {0}", S2);// Сума індексів додатніх елементів
            double rez = 0;
            double[] arr2 = new double[n];
            for (i = 0; i < arr1.Length; i++)
            {
                rez = arr2[i]-Math.Floor(arr2[i]);
                if (rez > 0 && rez < 1)
                {
                }
                else
                    Console.WriteLine(arr1[i]);
            }


        }
        
    }
}
