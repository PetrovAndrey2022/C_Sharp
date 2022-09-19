// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




internal class Program
{
    private static void Main(string[] args)
    {
        void FullArray(int[] array)// метод наполняет массив случайными числами
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int number = new Random().Next(100, 1000);
                array[i] = number;
            }
        }
        void PrintArray(int[] Col) // метод выводяций массив на печать
        {
            int length = Col.Length;
            Console.Write($"Был сгенерирован массив из {Col.Length} элементов - ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{Col[i]} ");
            }
            Console.WriteLine();
        }

        int  evenNumbers(int[] array)// метод вычисляющий кол-во четных элементов в массиве
        {
            int res =0;
            int length = array.Length;
            Console.WriteLine("Четными элементами в этом массиве являются:");
            for (int i=0; i<length; i++)
            {           
               if (((array[i])%2)==0) 
               {
                 res=res+1;  
                 Console.Write($" {array[i]} ");   
               }        
            }
         Console.WriteLine();
        return res;   
        }

        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив трехзначных чисел из N элементов, N задается с клавиатуры и выводит его на печать и считает кол-во четных элементов в массиве.");
            Console.WriteLine("Введите число элементов в массиве и нажмите Enter.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FullArray(array);
            PrintArray(array);
            int result = evenNumbers(array);
            Console.WriteLine($"Всего в массиве - {result} четных элементов.");
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