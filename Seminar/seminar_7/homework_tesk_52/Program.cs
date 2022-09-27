// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
                            array[i,j]  = new Random().Next(10,100);
                          
                        }
                }
        }
        void PrintArray(int [,] Col) // метод выводяций массив на печать
        {
            Console.WriteLine();
            Console.WriteLine("Сгенерированый двухмерный массив.");
            Console.WriteLine();
             for (int i = 0; i < Col.GetLength(0); i++)
                {
                        for (int j=0; j<Col.GetLength(1); j++)
                        {           
                            Console.Write($" {Col[i,j]} ");
                        }
                Console.WriteLine();
                }
             Console.WriteLine();
        }
        void  MiddlingArithmetic(int[,] array)// метод вычисляющий среднеарифметическое по столбцам массива
        {  
            int sum =0;
            Console.WriteLine("Среднеарифметическое по столбцам:"); 
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum +=array[i,j];                               
                }                       
                Console.Write($" {sum/array.GetLength(0)} "); 
                sum =0;
            }
            Console.WriteLine(); 
            Console.WriteLine(); 
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив целых целых чисел размерностью m*n, m*n задается с клавиатуры," 
                             +" находит  средне арифметическое элементов  в каждом столбце массива.");
            Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int [m,n];
            FullArray(array);
            PrintArray(array);
            MiddlingArithmetic(array);
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