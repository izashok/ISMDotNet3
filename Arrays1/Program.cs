using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arraysISM;




namespace Arrays1
{
    class Program

    {
        static void Main(string[] args)
        {
            int n, i, minr, maxr;
            bool f;

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


                int S1 =arraysISM.arr1.Zero(arr1);
                Console.Write($"Сумма элементов <0 {S1}");
                Console.ReadLine();

            
            
                int maxE, maxEn;
                arraysISM.arr1.MaxE(arr1,ref minr, out maxE, out maxEn);
                Console.WriteLine($"Максимальний элемент{maxE}, {maxEn}");
            
            
                int mod, modn;
                arraysISM.arr1.Mod(arr1, out mod, out modn);
                Console.WriteLine($"Наибольший по модулю {modn}, {mod}");
            
            
                int S2 = arraysISM.arr1.Dod(arr1);
                Console.WriteLine($"Сумма идексов дод элементов {S2}");

                int  q;
                arraysISM.arr1.Inti(arr1, ref n, out q);
                Console.WriteLine($"К-во целых чисел{q}");

               //End of the first task


           


                




















        }

    }
}
