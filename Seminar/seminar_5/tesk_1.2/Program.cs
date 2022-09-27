// Задача 32:
// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие  отрицательные и наоборот
// [-4 -8 8 2] [4 -8 8 2]


using System;
internal class Program
{
    private static void Main(string[] args)
    {

            // Заполняем массив случайными числами
            void FillArray(int[] Col)
            {
                for (int i = 0; i < Col.Length; i++)
                {
                    Col[i] = new Random().Next(-9, 10);
                }
            }

            // Выводим массив на печать
            void PrintArray(int[] Col)
            {
                for (int i = 0; i < Col.Length; i++)
                {
                    if (i != Col.Length - 1) Console.Write($"{Col[i]}, ");
                    else Console.WriteLine(Col[i]);

                }
            }

            //  Метод который на вход принимает массив, считает в 
            // нем сумму положительных и отрицательных элементов
            //  и возвращает 2 значения в виде массива
            int[] ReplacementNumbers(int[] Col)
             {
               
                int length =Col.Length;
                int [] ReplacementArray = new int [length];  
                for (int i=0; i<length; i++)
                {
                    ReplacementArray[i]=-Col[i];
                }
                
                
              
                return ReplacementArray;
             }
       
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа меняет числа в массиве на противоположные");
            Console.WriteLine("Введите сколько элементов будет в массиве");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FillArray(array);
            Console.WriteLine("Исходный массив чисел");
            PrintArray(array);
            int[] result = ReplacementNumbers(array);
            Console.WriteLine("Массив чисел с измененным знаком числа");
            PrintArray(result);
            Console.WriteLine("Для выхода из программы нажмите любую кнопку");
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Не корректный ввод");
            Console.ReadKey();
        }
    }
}