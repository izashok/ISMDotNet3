﻿using System;
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
           

           

            

           
}
}
}
