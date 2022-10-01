// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


internal class Program
{
    private static void Main(string[] args)
    {
        void FullArray(int[,] array)// метод наполняет массив случайными числами
        {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                        for (int j=0; j<array.GetLength(1); j++)
                        {           
                            array[i,j]  = new Random().Next(1,10); 
                        }
                }
        }
        void PrintArray(int [,] Col) // метод выводяций массив на печать
        {
             for (int i = 0; i < Col.GetLength(0); i++)
                {
                        for (int j=0; j<Col.GetLength(1); j++)
                        {           
                            Console.Write($" {Col[i,j]}  ");
                        }
                Console.WriteLine();
                }
             Console.WriteLine();
        }
       
        int[,] MatrixProduct(int [,] matrix_A, int [,] matrix_B) // Метод вычисляет минимальнут сумму элементов строки и индекс этой строки
        {
            int [,] matrix_C = new int [matrix_A.GetLength(0), matrix_A.GetLength(1)];
            for (int i=0; i<matrix_A.GetLength(0); i++)
            {
                    for (int j=0; j<matrix_A.GetLength(1); j++)
                    {                  
                          for (int k=0; k<matrix_B.GetLength(1); k++)
                            {
                                matrix_C[i,j]+=matrix_A[i,k]*matrix_B[k,j]; 
                            }    
                    }    
            }
            return matrix_C;
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует две матрицы A и B размером a*b и с*d, размерность матриц задается с клавиатуры," 
                             +" находит произведение этих матриц и выводит на экран.");
            Console.WriteLine();
            Console.Write("Введите колличество строк в матрице А и нажмите  Enter. - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в матрице А и нажмите  Enter. - ");
            int b = Convert.ToInt32(Console.ReadLine());
            int [,] matrix_A = new int [a,b];
            Console.WriteLine();
            Console.Write("Введите колличество строк в матрице B и нажмите  Enter. - ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в матрице B и нажмите  Enter. - ");
            int d = Convert.ToInt32(Console.ReadLine());
            int [,] matrix_B = new int [c,d];
            Console.WriteLine();
                if (a==b & c==d) // проверка введенной размерности матриц
                 {
                    Console.WriteLine($"  matrix_A ");
                    FullArray(matrix_A);
                    PrintArray(matrix_A);
                    Console.WriteLine($"  matrix_B ");
                    FullArray(matrix_B);
                    PrintArray(matrix_B);
                 }
                 else  
                 { 
                    Console.WriteLine();
                    Console.WriteLine("Не корректно введена размерность матриц, они должны быть равны.");
                    Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
                    Console.ReadKey();
                 }        
            int [,] result = MatrixProduct(matrix_A,matrix_B);
            Console.WriteLine($" Результирующая матрица matrix_C ");
            PrintArray(result);
            Console.WriteLine();
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Надо было вводить число.");
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}