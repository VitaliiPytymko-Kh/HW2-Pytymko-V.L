/*Завдання 2
Дано двовимірний масив розміром 5×5, заповне-
ний випадковими числами з діапазону від –100 до 100.
Визначити суму елементів масиву, розташованих між
мінімальним і максимальним елементами*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Pytymko_V.L
{
    internal class Task2
    { 
      /*  static void Main(string[] args) 
        {
            int[,] arr= new int [5,5];
        
        Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-100, 100);
                }
            }

            Console.WriteLine("Матриця чисел 5х5 :");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                }
              Console.WriteLine();
            }

            int minARR = arr[0, 0];
            int maxARR = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < minARR)
                    {
                        minARR = arr[i, j];
                    }
                    if (arr[i, j] > maxARR)
                    {
                        maxARR = arr[i, j];
                    }
                }
            }

            Console.WriteLine(" minARR :" + minARR);
      
            Console.WriteLine(" maxARR :" + maxARR);

            int SumarrMinMax = 0;
            bool foundMin = false;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == minARR)
                    {
                        foundMin = true;
                    }
                    else if (foundMin && arr[i, j] == maxARR)
                    {
                        foundMin = false;
                        break; 
                    }
                    else if (foundMin)
                    {
                        SumarrMinMax += arr[i, j];
                    }
                }
                if (!foundMin)
                {
                    break; 
                }
            }
            Console.WriteLine("sumarrMinMax : " + SumarrMinMax);

        }*/
    }
}
