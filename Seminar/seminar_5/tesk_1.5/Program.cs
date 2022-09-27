// Задача 37:
// Найдите произведение пар чисел в одномерном массиве .
// Парой считается первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве 


using System;


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

    
        //  Метод который вычисляет произведение пар (1 и т-1, 2и т-2 и тд)
        int[] RangeNumbers(int[] Col)
        {
            
           int length = Convert.ToInt32(Math.Round(Convert.ToDouble(Col.Length/2)));
            Console.WriteLine(length);
           
           if (Col.Length%2!=0) length = length+1;          
           int [] rangeArray = new int [length];
           int i=0;
           if (Col.Length%2!=0) length = length-1;
            while(i<length)
                {
                    rangeArray[i]=(Col[i]*Col[(Col.Length-(1+i))]);
                    Console.WriteLine($"при i={i} = {rangeArray[i]}");
                    i++;         
                }
                rangeArray[length]=Col[length];


            // rangeArray[length]=Col[length];
            
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
            PrintArray(res);
            Console.WriteLine("Для выхода из программы нажмите любую клавишу"); 
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Не корректный ввод");
            Console.ReadKey();
        }
