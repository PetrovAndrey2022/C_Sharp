// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



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
        void  ItemValue(int[,] array, int a, int b)// метод возвращающий значение элемента массива  по его  индексу
        {  
            int result =array[a,b];
             for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (result == array[i,j])  Console.WriteLine ($"Значение элемента массива с заданным индексом =  {array[i,j]} ");                              
                    }                    
                }
        }
        try
        {
            // Console.Clear();
            Console.WriteLine("Данная программа генерирует массив целых целых чисел размерностью m*n, m*n задается с клавиатуры," 
                             +" на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента"
                             +" или же указание, что такого элемента в массиве нет.");
            Console.WriteLine();
            Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int [m,n];
            FullArray(array);
            PrintArray(array);
            Console.Write($"Введите строку в которой находится искомый элемент массива в диапазоне от 0 до {m-1} и нажмите Enter. - ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите столбец в котором находится искомый элемент массива в диапазоне от 0 до {n-1} и нажмите Enter. - ");
            int j = Convert.ToInt32(Console.ReadLine());
          
            if (i>=0 & i<=m-1)// Проверка наличия введенных индексов в массиве
                {
                     if (j>=0 & j<=n-1) ItemValue(array, i, j);
                     else   Console.WriteLine($"Элемента с индексом i = {i} и J = {j} в данном массиве нет.");          
                }
             else   Console.WriteLine($"Элемента с индексом i = {i} и J = {j} в данном массиве нет. ");   

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