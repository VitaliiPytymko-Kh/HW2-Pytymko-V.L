/*Завдання 4
Створіть додаток, який здійснює операції над матри-
цями:
■ Множення матриці на число;
■ Додавання матриць;
■ Добуток матриць.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Pytymko_V.L
{
    internal class Task3
    {
       /* static void Main()
        {
        Console.WriteLine("Створення матриці!))");
        Console.Write("Кількість Рядків: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Кількість стовбців: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j<cols; j++)
            {
                matrix[i, j] = random.Next(-10, 11);
            }
        }


        Console.WriteLine("Створена матриця випадкових чисел:");
        PrintMatrix(matrix);

        Console.WriteLine(" Давайте помножимо матрицю на число: ");
        int X = int.Parse(Console.ReadLine());

        int[,] resultMatrix = ProdMatrixInt(matrix, X);


        Console.WriteLine("Результат множення матриці на число:");
        PrintMatrix(resultMatrix);

        Console.WriteLine("Давайте додамо матрицю з результатом множення до першої матриці : ");
        int[,] sumMatrix = SumMatrix(matrix, resultMatrix);


        Console.WriteLine("Результат додавання двух матриць:");
        PrintMatrix(sumMatrix);

        Console.WriteLine(" Давайте перемножимо дві матриці: ");
        int[,] productMatrix = ProdMatrix(matrix, sumMatrix);


        Console.WriteLine("Добуток двух матриць:");
        PrintMatrix(productMatrix);

        Console.ReadLine();
    }

        static void PrintMatrix(int[,] matrix) {

               int rows = matrix.GetLength(0);
               int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++) {
                        Console.Write(matrix[i, j] + " ");
                    }
                      Console.WriteLine();
                }
        }

        static int[,] ProdMatrixInt(int[,] matrix, int X){
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++){
                for (int j = 0; j < cols; j++){
                    result[i, j] = matrix[i, j] * X;
                }
            }

            return result;
        }

        static int[,] SumMatrix(int[,] matrix1, int[,] matrix2){
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++){
                for (int j = 0; j < cols; j++){
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        static int[,] ProdMatrix(int[,] matrix1, int[,] matrix2){
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int cols2 = matrix2.GetLength(1);
            int[,] result = new int[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }*/
    }  
}

