// Задача 33:
// Задайте массив. Напишите программу, которая определяет, присутствует
// ли заданное число в массиве.
// 5, массив [1 4 6 9] - нет
// -3, массив [-3 7 9 ....]


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
            void FindNumbers(int[] Col, int n)
             {
                int numbers=n; 
                int res=0;                
                foreach (int item in Col) // item перебирает по очереди все элементы коллекции
                                        // foreach только просматривает массив и в нем нельзя менять элементы 
                                        // в отличии от других циклов
                    {
                        if (item == n) res=1;
                    }
                    if (res == 1) Console.WriteLine("Искомое число присутствует в массиве");
                    else Console.WriteLine("Такого нисла нет в массиве");
             }
       
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа пределяет, присутствуе ли заданное число в массиве");
            Console.WriteLine("Введите сколько элементов будет в массиве");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("Введите число для поиска");
            int numbers=Convert.ToInt32(Console.ReadLine());
            FindNumbers(array,numbers);
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