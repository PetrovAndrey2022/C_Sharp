// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using System;
internal class Program
{
    private static void Main(string[] args)
    {
        void FullArray(double[,] array)// метод наполняет массив случайными числами
        {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                        for (int j=0; j<array.GetLength(1); j++)
                        {           
                            array[i,j] = new Random().NextDouble()*100;
                        }
                }
        }
        void PrintArray(double [,] Col) // метод выводяций массив на печать
        {
            Console.WriteLine();
            Console.WriteLine("Сгенерированый двухмерный массив вещественных чисел.");
            Console.WriteLine();
             for (int i = 0; i < Col.GetLength(0); i++)
                {
                        for (int j=0; j<Col.GetLength(1); j++)
                        {           
                            Console.Write(" {0,6:F2}", Col[i,j] ); 
                        }
                Console.WriteLine();
                }
             Console.WriteLine();
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив случайных вещественных чисел размерностью m*n, m*n задается с клавиатуры.");
            Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
            double [,] array = new double [m,n];
            FullArray(array);
            PrintArray(array);
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