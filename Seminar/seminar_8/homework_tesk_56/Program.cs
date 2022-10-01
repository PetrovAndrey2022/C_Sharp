// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
       
        void MinSumString(int [,] array) // Метод вычисляет минимальнут сумму элементов строки и индекс этой строки
        {
            int sum_string =0;
            int min_sum_string =0;
            int number_string =0;
            int index =0;

            for (int i=0; i<array.GetLength(0); i++)
            {
                    for (int j=0; j<array.GetLength(1); j++)
                    {                  
                        sum_string+=array[i,j]; 
                        index = i; 
                    }     
                     Console.WriteLine($" Cумма элементов массива {index} строки =   {sum_string}");
                    if (min_sum_string==0)  // Присваиваем минимальному значению суммы элементов строки - значение 0 строки
                        {
                            min_sum_string=sum_string;
                            number_string = index;
                        }
                        if (min_sum_string>sum_string) // стравниваем min сумму строки с текущей
                        {
                            min_sum_string=sum_string;
                            number_string = index;
                            sum_string=0; // обнуляем сумму строки
                        }
                        else 
                        {   
                            sum_string=0; // обнуляем сумму строки
                        }
            }
            Console.WriteLine();
            Console.WriteLine($" Строка с минимальной суммой элементов -  {number_string},  сумма элементов строки = {min_sum_string}");
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив целых целых чисел размерностью m*n, m*n задается с клавиатуры," 
                             +" считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов в строке.");
            Console.WriteLine();
            Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int [m,n];
            FullArray(array);
            PrintArray(array);
            MinSumString(array);
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