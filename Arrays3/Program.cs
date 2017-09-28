using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arraysISM;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, minr, maxr;
            bool f;
            do
            {
                Console.WriteLine("Введите количество строк : ");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите количество столб.: ");
                f = int.TryParse(Console.ReadLine(), out m);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите диапазон чисел.: ");
                f = int.TryParse(Console.ReadLine(), out minr);
            } while (f == false);
            do
            {
                f = int.TryParse(Console.ReadLine(), out maxr);
            } while (f == false);
            int[,] matr1 = new int[n, m];

            Random rnd = new Random();

            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    matr1[i, j] = rnd.Next(minr, maxr + 1);
                    Console.Write($"{matr1[i, j],4}");
                }
                Console.WriteLine();
            }


            int count;
            arraysISM.arr1.SumaZero1(matr1, out count);
            Console.WriteLine($"К-во полож элементов{count}");

            int MAX;
            arraysISM.arr1.SumaZero2(matr1, ref minr, ref m, ref n, out MAX);
            Console.WriteLine($"Максимальное ктр. вст. больше одного раза {MAX}");

            int zeroC;
            arraysISM.arr1.SumaZeroC(matr1, ref n, out zeroC);
            Console.WriteLine($"К-во строк без 0 ={zeroC}");

            int zeroT;
            arraysISM.arr1.SumaT(matr1,out zeroT);
            Console.WriteLine($"К-во столб. с 0 ={zeroC}");

            int index;
            arraysISM.arr1.Row(matr1,out index);
            Console.WriteLine($"Строка с наибольшей серией ={index}");

           
            arraysISM.arr1.Dobi(matr1);

            int maxD = arraysISM.arr1.Diag(matr1, ref n);
            Console.WriteLine($"Макс. сумма диагоналей {maxD} ");

         
            arraysISM.arr1.SumaColZero(matr1);

            int absX=arraysISM.arr1.AbsX(matr1, ref n, ref  maxr);
            Console.WriteLine($"Наибольший модуль среди сумм паралельных диагонали{absX}");

            arraysISM.arr1.SumaMinus(matr1);

            arraysISM.arr1.Trans(matr1, ref n, ref m);






        }
    }
}
