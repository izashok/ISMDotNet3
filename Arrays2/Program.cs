using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f;
            int i, minr, maxr, min, minN, n, q, q1, o1, s;
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
            min = maxr;//добуток елементів після мінімального початок
            minN = 0;
            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                {
                    min = arr1[i];
                    minN = i;
                }
            }
            int d = 1;
            for (i = minN; i < arr1.Length; i++)
            {
                d = d * arr1[i];
            }
            Console.WriteLine("Произведение элементов после минимального, d={0}", d); //добуток елементів після мінімального кінець

            //друге завдання початок
            q = 0;//Знаходження другого додатнього елемента початок
            q1 = 0;
            for (i = 0; i < arr1.Length; i++)
            {

                if (arr1[i] > 0)
                {
                    q++;
                    q1 = i;
                    if (q == 2)
                        break;
                }
            }
            // знаходження другого додатнього елемента кінець

            o1 = 0;//знаходження першого від"ємного елемента початок
            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < 0)
                {
                    o1 = i;
                    break;
                }
            }
            //знаходження першого від"ємного елемента кінець

            if (q1 < o1)
            {
                o1 = q1 + o1;
                q1 = o1 - q1;
                o1 = o1 - q1;

            }
            s = 0;
            for (i = o1+1; i < q1; i++)
            {
                s = s + arr1[i];
            }
            Console.WriteLine("Сума элементов между первым отрицательным и вторым положительным {0}", s);
            // кінець другого завдання

            //початок третього завдання
            int zero1 = 0, zero2 = 0;
            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == 0)
                {
                    zero1 = i;
                    break;

                }
            }
            for (i = zero1; i < arr1.Length; i++)
            {
                if (arr1[i] == 0)

                    zero2 = i;

            }
            int sumazero = 0;
            for (i = zero1+1; i < zero2; i++)
            {
                sumazero = sumazero + arr1[i];
            }
            Console.WriteLine("Сумма элементов между нулевыми элементами {0}", sumazero);

            //кінець третього завдання

            //початок четвертого завдання
            int ModMax = 0, ModMin = maxr, ModMNx = 0, ModMXx = 0;

            for (i = 0; i < arr1.Length; i++)
            {
                if (Math.Abs(arr1[i]) > Math.Abs(ModMax))
                {
                    ModMax = arr1[i];
                    ModMXx = i;
                }
                else
                    if (Math.Abs(arr1[i]) < Math.Abs(ModMin))
                {
                    ModMin = arr1[i];
                    ModMNx = i;
                }
            }
            if (ModMXx < ModMNx)
            {
                ModMNx = ModMNx + ModMXx;
                ModMXx = ModMNx - ModMXx;
                ModMNx = ModMNx - ModMXx;


            }
            int dob = 1;
            for (i = ModMNx+1; i < ModMXx; i++)
            {
                dob = dob * arr1[i];
            }
            Console.WriteLine("Произведение элементов между min и max по модулю {0} ", dob);
            //кінець четвертого завдання
}
}
}
