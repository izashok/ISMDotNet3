using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arraysISM
{
    public class arr1
    {
        public static int Zero(params int[] integers)
        {

            int S1 = 0; // Сума елементів менших за 0 початок
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] < 0)
                {
                    S1 += integers[i];
                }

            }
            return S1;
        }

        public static void MaxE(int[] integers, ref int minr, out int maxE, out int maxEn)
        {
            maxE = minr;
            maxEn = 0;
            for (int i = 0; i < integers.Length; i++)
            {

                if (integers[i] > maxE)
                {

                    maxE = integers[i];
                    maxEn = i;
                }
            }
            Console.WriteLine($"{maxE},{maxEn}");
          
        }

        public static void Mod(int[] integers, out int mod, out int modn)
        {
            mod = 0;//Найбільший елемент по модулю початок
            modn = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (Math.Abs(integers[i]) > mod)
                {
                    mod = Math.Abs(integers[i]);
                    modn = i;
                }
            }

        }

        public static int Dod( params int[] integers)
        {
            int S2 = 0;// Сума індексів додатніх елементів
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] > 0)
                {
                    S2 = S2 + i;
                }
            }

            return S2;
        }

        public static void Inti(double[] integers, ref int n, out int q)
        {
            q = 0;
            double rez = 0;
            double[] arr2 = new double[n];
            for (int i = 0; i < integers.Length; i++)
            {
                rez = arr2[i] - Math.Floor(arr2[i]);
                if (rez > 0 && rez < 1)
                {
                }
                else
                    q = q + 1;

            }
        }
        public static void DobMin(int[] integers, ref int maxr, out int d)
        {
            int min = maxr;//добуток елементів після мінімального початок
            int minN = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] < min)
                {
                    min = integers[i];
                    minN = i;
                }
            }
            d = 1;
            for (int i = minN; i < integers.Length; i++)
            {
                d = d * integers[i];
            }
            //добуток елементів після мінімального кінець
        }

        public static void SumaMinMax(int[] arr1, out int s)
        {
            //друге завдання початок
            int q = 0;//Знаходження другого додатнього елемента початок
            int q1 = 0;
            for (int i = 0; i < arr1.Length; i++)
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

            int o1 = 0;//знаходження першого від"ємного елемента початок
            for (int i = 0; i < arr1.Length; i++)
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
            for (int i = o1 + 1; i < q1; i++)
            {
                s = s + arr1[i];
            }

        }

        public static void SumaZero(int[] arr1, out int sumazero)
        {
            //початок третього завдання
            int zero1 = 0, zero2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == 0)
                {
                    zero1 = i;
                    break;

                }
            }
            for (int i = zero1; i < arr1.Length; i++)
            {
                if (arr1[i] == 0)

                    zero2 = i;

            }
            sumazero = 0;
            for (int i = zero1 + 1; i < zero2; i++)
            {
                sumazero = sumazero + arr1[i];
            }


            //кінець третього завдання
        }

        public static void SumaMod(int[] arr1, ref int maxr,out int dob)
        {
            //початок четвертого завдання
            int ModMax = 0, ModMin = maxr, ModMNx = 0, ModMXx = 0;

            for (int i = 0; i < arr1.Length; i++)
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
             dob = 1;
            for (int i = ModMNx + 1; i < ModMXx; i++)
            {
                dob = dob * arr1[i];
            }

            //кінець четвертого завдання
        }

        public static void SumaZero1(int[,] matr1, out int count)
        {
            count = 0;
            //початок першого завдання
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] > 0)
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine("Количество чисел больше 0 count= {0}", count);
            //кінець першого завдання
        }

        public static void SumaZero2(int[,] matr1, ref int minr, ref int m, ref int n, out int MAX)
        {
            //початок другого завдання
            MAX = minr;
            int x1 = m * n;
            int[] arrx = new int[x1];
            x1 = 0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {

                for (int j = 0; j < matr1.GetLength(1); j++)
                {

                    arrx[x1] = matr1[i, j];
                    x1++;

                }

            }
            int qq = 0;
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < arrx.GetLength(0) - 1; j++)
                {
                    if (arrx[j] < arrx[j + 1])
                    {
                        qq = arrx[j];
                        arrx[j] = arrx[j + 1];
                        arrx[j + 1] = qq;

                    }
                }
            }

            for (int i = 0; i < arrx.Length; i++)
            {

                if (arrx[i] == arrx[i + 1])
                {
                    MAX = arrx[i];
                    break;
                }




            }
            
            // кінець другого завдання
        }

        // початок третього завдання
        public static void SumaZeroC(int[,] matr1, ref int n, out int zeroC)
        {
            zeroC = 0;
            for (int i = 0; i < matr1.GetLength(0); i++) {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] == 0)
                    {

                        zeroC = zeroC + 1;
                        break;
                    }


                }
            }
            zeroC = n - zeroC;

            //кінець третього
        }
        public static void SumaT(int[,] matr1, out int zeroT)
        {
            //початок четвертого завдання

            zeroT = 0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[j, i] == 0)
                    {
                        zeroT = zeroT + 1;
                        break;
                    }

                }
            }
            //кінець четвертого
        }

        public static void Row(int[,] matr1, out int index)
        {
            //початок п"ятого завдання
            int rowmax = 0;

            index = 0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1) - 1; j++)
                {
                    int row = 0;
                    if (matr1[i, j] == matr1[i, j + 1])
                    {
                        row = row + 1;
                        if (row > rowmax)
                        {
                            rowmax = row;
                            index = i;
                        }
                    }

                }
            }
            Console.WriteLine("Индекс строчки с самой большой серией i={0}", index);
            //кінець п"ятого
        }

        public static void Dobi(int[,] matr1)
        {
            //початок шостого завдання
            int dobutok;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                dobutok = 1;
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] < 0)
                    {

                        dobutok = -1;
                        break;
                    }
                    else
                        dobutok = matr1[i, j] * dobutok;

                }
                if (dobutok >= 0)
                    Console.WriteLine("Индекс ряда и произведение i={0} dobutok={1}", i, dobutok);

            }

            //кінець шостого
        }

        public static int Diag(int[,] matr1, ref int n)
        {

            //початок сьомого
            int[] arr = new int[n - 1];// верхні діагоналі

            int x = 1;

            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                int k = 0;
                for (int j = x; j < matr1.GetLength(1); j++)
                {

                    arr[k] = arr[k] + matr1[i, j];
                    k++;
                    if (k == n - 2)
                    {
                        break;
                    }
                }
                x++;

            }


            //верхні діагоналі
            //нижні діагоналі
            int[] arr1 = new int[n - 1];

            x = 1;

            for (int i = 1; i < matr1.GetLength(0); i++)
            {
                int xn = i - 1;
                for (int j = 0; j < i; j++)
                {
                    arr1[xn] = arr1[xn] + matr1[i, j];

                    if (xn == 0)
                    {
                        break;
                    }
                    xn--;
                }
            }



            //нижні діагоналі

            int maxD = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] > maxD)
                {
                    maxD = arr[i];
                }
            }
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                if (arr1[i] > maxD)
                {
                    maxD = arr1[i];
                }
            }

            return maxD;
            //кінець сьомого
        }

        public static void SumaColZero(int[,] matr1)
        {
            //початок восьмого
           int sumas = 0;
            int i;
            for (i = 0; i < matr1.GetLength(0); i++)
            {
                sumas = 0;
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[j, i] >= 0)
                    {
                        sumas = sumas + matr1[j, i];

                    }
                    else
                    {
                        sumas = -1;
                        break;
                    }
                }
                if (sumas >= 0)
                    Console.WriteLine("Сумма столп. с значениями >0 равна={0}, index={1}", sumas, i);
            }
            Console.WriteLine();
            //кінець восьмого
        }

        public static int AbsX(int[,] matr1, ref int n, ref int maxr)
        {
            //початок дев"ятого
            int[] arrz = new int[n - 1];
            for (int i = 1; i < matr1.GetLength(0); i++)
            {
                int k = 0;
                for (int j = n - i; j < matr1.GetLength(1); j++)
                {
                    arrz[k] = Math.Abs(matr1[i, j]) + arrz[k];

                    k++;
                    if (k == n - 1)
                        break;
                }
            }
            int kj = 0;
            int[] arrv = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {

                int k = kj;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    arrv[k] = arrv[k] + Math.Abs(matr1[i, j]);
                    k++;
                    if (k == n - 1)
                        break;
                }
                kj++;

            }
            int absX = maxr * maxr;
            for (int i = 0; i < arrz.GetLength(0); i++)
            {
                if (arrz[i] < absX)
                    absX = arrz[i];
            }
            for (int i = 0; i < arrv.GetLength(0); i++)
            {
                if (arrv[i] < absX)
                    absX = arrv[i];
            }
            return absX;
            //кінець дев"ятого
        }

        public static void SumaMinus(int[,] matr1)
        {

            //початок десятого

            int kq;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                kq = 0;
                int sumam = 0;
                for (int j = 0; j < matr1.GetLength(1); j++)
                {

                    sumam = sumam + matr1[j, i];
                    if (matr1[j, i] < 0)
                    {

                        kq = 1;
                    }




                }
                if (kq == 1)
                    Console.WriteLine("Сума чисел в столб. с отриц. элемен.равна={0} индекс={1}", sumam, i);

            }


            //кінець десятого
        }

        public static void Trans(int[,] matr1, ref int n, ref int m)
            {
            //початок одиннадцятого
            int[,] matr2 = new int[n, m];

            for (int i = 0; i < matr1.GetLength(0); i++)

                for (int j = 0; j < matr1.GetLength(1); j++)

                    matr2[j, i] = matr1[i, j];
            Console.WriteLine("Транспонована");
            for (int i = 0; i < matr2.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    Console.Write($"{matr2[i, j],4}");
                }
                Console.WriteLine();
            }
            //кінець одиннадцятого
        }
















    }
}
