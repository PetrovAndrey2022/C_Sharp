// Задача 35:
// Задайте одномерный массив из 15 случайных чисел в диапазоне от -100 до 100.
// Найдите количество элементов массива значение которых лежат в отрезке [10? 99]


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
                Col[i] = new Random().Next(-100, 100);
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

        // Выводим массив на печать и пропускает пустые значения (0)
        void PrintArray1(int[] Col)
        {
            for (int i = 0; i < Col.Length; i++)
            {
                if (i != Col.Length - 1 & Col[i]!=0)  Console.Write($"{Col[i]} ");
               

            }
            Console.WriteLine();
           
        }


        //  Метод который на вход принимает массив, считает количество элементов попадающих в диапазон 10-99
        int[] RangeNumbers(int[] Col)
        {
           
           int [] rangeArray = new int [Col.Length];
            for (int i=0; i<Col.Length; i++)
            {
                if (Col[i]>10&Col[i]<99)
                {
                    rangeArray[i]=Col[i];
                }
            
            }
            return rangeArray;
        }

        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа задает массив из случайных чисел в диапазоне от -100 до 100 и ищет элементы лежащие в диапазоне от 10 до 99 ");
            Console.WriteLine("Введите сколько элементов будет в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FillArray(array);
            PrintArray(array);
            int [] res = RangeNumbers(array);
                 if (res.Length==0) Console.WriteLine("В массиве нет элементов попадающих в заданый диапазон");
                else 
                {
                    Console.WriteLine("В заданый диапазон от 10 до 99 попали следующие элементы массива: ");
                    PrintArray1(res);
                }   
            Console.WriteLine("Для выхода из программы нажмите любую клавишу"); 
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Не корректный ввод");
            Console.ReadKey();
        }
    }
}