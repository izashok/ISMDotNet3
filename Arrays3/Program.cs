using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int count = 0;
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
            Console.WriteLine("Количество чисел больше 0 count= {0}",count);
            //кінець першого завдання
            //початок другого завдання
            int MAX = minr;
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
            Console.WriteLine("Макс. число, повтор. больше раза МАХ={0}", MAX);
            // кінець другого завдання
            // початок третього завдання
            int zeroC = 0;
            for (int i = 0; i < matr1.GetLength(0); i++) {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] == 0) {

                        zeroC = zeroC + 1;
                        break;
                    }
                    
                        
                }
            }
            zeroC = n - zeroC;
            Console.WriteLine("К-во строчек не имеющих 0 равно={0}",zeroC);
            //кінець третього
            //початок четвертого завдання

            int zeroT = 0;
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
            Console.WriteLine("К-во столб. имеющих 0 равно={0}",zeroT);
            //кінець четвертого
            //початок п"ятого завдання
            int rowmax=0;
            
            int index = 0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1)-1; j++)
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
            Console.WriteLine("Индекс строчки с самой большой серией i={0}",index);
            //кінець п"ятого
            //початок шостого завдання
            int dobutok;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                dobutok = 1;
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] < 0) {

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
                    //початок сьомого
            int[] arr = new int[n - 1];// верхні діагоналі
            
            int x = 1;
            
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                int k = 0;
                for (int j = x; j < matr1.GetLength(1); j++)
                {
                    
                    arr[k] =arr[k]+matr1[i, j];
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
                    
                    if (xn==0)
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
                if(arr[i] > maxD)
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
            Console.WriteLine("Наибольшая сума чисел диагоналей || главной suma={0}", maxD);

            //кінець сьомого
            //початок восьмого
            int sumas;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                sumas = 0;
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[j, i] >= 0)
                    {
                        sumas = sumas + matr1[j, i];

                    }
                    else {
                        sumas = -1;
                        break;
                    }
                }
                if(sumas>=0)
                Console.WriteLine("Сумма столп. с значениями >0 равна={0}, index={1}",sumas,i );
            }
            Console.WriteLine();
            //кінець восьмого
            //початок дев"ятого
            int[] arrz = new int[n - 1];
            for (int i = 1; i < matr1.GetLength(0); i++)
            {
                int k = 0;
                for (int j =n-i; j<matr1.GetLength(1); j++)
                {
                    arrz[k] = Math.Abs(matr1[i, j]) + arrz[k];
                   
                    k++;
                    if (k == n - 1)
                        break;
                }
            }
            int kj = 0;
            int[] arrv = new int[n - 1];
            for (int i = 0; i < n-1; i++)
            {
                
                int k = kj;
                for (int j = 0; j <n-1-i; j++)
                {
                    arrv[k] =arrv[k] + Math.Abs(matr1[i, j]);
                    k++;
                    if (k == n - 1)
                        break;
                }
                kj++;
          
            }
            int absX = maxr*maxr;
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
            Console.WriteLine("Минимум среди модулей сум диагоналей || вторичной равен={0} ", absX);
            //кінець дев"ятого
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
                       
                        kq =1;
                    }
                   
                        
                       

                }
                if (kq==1)
                Console.WriteLine("Сума чисел в столб. с отриц. элемен.равна={0} индекс={1}",sumam, i);
              
            }


            //кінець десятого
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
