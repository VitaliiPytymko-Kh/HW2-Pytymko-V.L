/*ЗАВДАННЯ 1
ОГОЛОСИТИ ОДНОВИМІРНИЙ (5 ЕЛЕМЕНТІВ) МАСИВ З НАЗВОЮ
A I ДВОВИМІРНИЙ МАСИВ (3 РЯДКИ, 4 СТОВПЦІ) ДРОБОВИХ ЧИСЕЛ
З НАЗВОЮ B. ЗАПОВНИТИ ОДНОВИМІРНИЙ МАСИВ А ЧИСЛАМИ,
ВВЕДЕНИМИ З КЛАВІАТУРИ КОРИСТУВАЧЕМ, А ДВОВИМІРНИЙ
МАСИВ В — ВИПАДКОВИМИ ЧИСЛАМИ ЗА ДОПОМОГОЮ ЦИКЛІВ.
ВИВЕСТИ НА ЕКРАН ЗНАЧЕННЯ МАСИВІВ: МАСИВУ А — В ОДИН
РЯДОК, МАСИВУ В — У ВИГЛЯДІ МАТРИЦІ. ЗНАЙТИ У ДАНИХ
МАСИВАХ ЗАГАЛЬНИЙ МАКСИМАЛЬНИЙ ЕЛЕМЕНТ, МІНІМАЛЬНИЙ
ЕЛЕМЕНТ, ЗАГАЛЬНУ СУМУ УСІХ ЕЛЕМЕНТІВ, ЗАГАЛЬНИЙ ДОБУТОК
УСІХ ЕЛЕМЕНТІВ, СУМУ ПАРНИХ ЕЛЕМЕНТІВ МАСИВУ А, СУМУ
НЕПАРНИХ СТОВПЦІВ МАСИВУ В.*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Pytymko_V.L
{
    internal class Task1
    {
        static void Main(string[] args)

        {
            int[] A = new int[5];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Вкажіть значення для {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int inputvalue)) { A[i] = inputvalue; }
                else { Console.WriteLine($"Невірний формат, вкажіть ціле число"); i--; }
            }

            Console.WriteLine("Вміст масиву А : ");
            foreach (int element in A) { Console.Write(element + " "); }
            Console.WriteLine("\n");

            int maxA = A[0];
            int minA = A[0];
            int sumA = 0;
            int prodA = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxA)
                {
                    maxA = A[i];
                }
                if (A[i] < minA)
                {
                    minA = A[i];
                }
                sumA += A[i];
                prodA *= A[i];
            }
            Console.WriteLine(" Мaксимальний елемент масива А =  " + maxA);
                       
            Console.WriteLine(" мінімальний елемент масива А =  " + minA);
                       
            Console.WriteLine("sumA=" + sumA);

            Console.WriteLine("prodA=" + prodA);

            int sumpar = 0;
            for (int i = 0; i < A.Length; i += 2) { 
            
            sumpar += A[i];
            
            }

            Console.WriteLine("sumpar A= " + sumpar);



            int rows = 3;
            int cols = 4;
                
                 Random random = new Random();

                 double[,] B = new double[rows,cols];
                 for (int i = 0; i < rows; i++)
                 {
                     for (int j = 0; j < cols; j++)
                     {
                         B[i,j]= random.NextDouble();

                     }
                 }

                Console.WriteLine("Двовимірний масив В  дробових чисел :");
                    for (int i = 0;i < rows; i++) {
                         for (int j = 0; j < cols; j++) 
                         {
                          Console.Write(B[i,j]+" ");  
                         }
                            Console.WriteLine();
                      }

            double maxB = B[0, 0];
            double minB = B[0, 0];
            double sumB = 0;
            double prodB = 1;
           

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] < minB)
                    {
                        minB = B[i, j];
                    }
                    if (B[i, j] > maxB)
                    {
                        maxB = B[i, j];
                    }
                    sumB += B[i, j];
                    prodB *= B[i, j];
                }
            }

            Console.WriteLine(" Мaксимальний елемент двумірного масива B = "+maxB);
                                 
            Console.WriteLine(" Мінімальний елемент двумірного масива B = " + minB);
                      
            Console.WriteLine("sumB = " + sumB);
                      
            Console.WriteLine("prodB = " + prodB);

            double sumoddB = 0.0;
          
                for (int j = 1; j < cols; j+=2)
                    {
                    for (int i = 0; i < rows; i++)
                        {
                         sumoddB += B[i, j];
                        }
                    }

            Console.WriteLine(" sumoddB = "+ sumoddB);

            double OverAllMax = Math.Max(maxA, maxB);
            
            Console.WriteLine("Спiльний максимальний елемент: "+OverAllMax);

            double OverAllMin= Math.Min(minA, minB);
            Console.WriteLine("Спiльний Мінімальний елемент:"+OverAllMin);

            double AllSum = sumA + sumB;
            Console.WriteLine("AllSum= " + AllSum );

            double TotallProd = prodA * prodB;
            Console.WriteLine("TotallProd = "+ TotallProd);

            Console.WriteLine();

         }

    }
}

