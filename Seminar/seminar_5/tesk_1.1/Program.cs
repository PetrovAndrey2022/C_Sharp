// Задача 31:
// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка (-9,9). Найдите сумму отрицательных и положительных чисел массива.
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
            int[] FindSums(int[] Col)
        {
            int[] sums = new int[2]; // создаем новый массид для записи в него результатор
                                     // вычмсления сумм отрицательных и положительных элементов
            foreach (int item in Col) // item перебирает по очереди все элементы коллекции
                                      // foreach только просматривает массив и в нем нельзя менять элементы 
                                      // в отличии от других циклов
                {
                    if (item > 0) sums[1] += item;
                    else sums[0] += item;
                }
            return sums;
        }
       
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа задает массив из 12 элементов, заполняет его"
                            + " случайными числами из промежутка от -9 до 9 и далее находит сумму"
                            + "положительный и отрицательных элементов.");
            int[] array = new int[12];
            FillArray(array);
            PrintArray(array);
            int[] result = FindSums(array);
            Console.WriteLine($"Сумма отрицательных элементов массива равна {result[0]}");
            Console.WriteLine($"Сумма положительных элементов массива равна {result[1]}");
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Не корректный ввод");
            Console.ReadKey();
        }
    }
}