// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
       
       int[,] SelectionSort(int [,] array)
        {       
            for (int i=0; i<array.GetLength(0); i++)
            {
                for (int j=0; j<array.GetLength(1); j++)
                 {                      
                   
                    for (int z=0; z<array.GetLength(1); z++)
                    {
                        if(array[i,z]<array[i,j])
                        {
                            // int Max_position=array[i,z];
                            int temp = array[i,j];
                            array[i,j]=array[i,z];
                            array[i,z]=temp;
                        }
                    }     
                 }   
            }
        return array;
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив целых целых чисел размерностью m*n, m*n задается с клавиатуры," 
                             +" упорядочивает по убыванию элементы каждой строки двумерного массива.");
            Console.WriteLine();
            Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int [m,n];
            FullArray(array);
            Console.WriteLine();
            Console.WriteLine("Сгенерированый массив случайных чисел.");
            PrintArray(array);
            int[,] result =  SelectionSort(array);
            Console.WriteLine("Массив отсортированный по строкам в порядке убывания.");
            PrintArray(result);
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