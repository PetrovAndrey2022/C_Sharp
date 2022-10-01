// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


internal class Program
{
    private static void Main(string[] args)
    {
            void FullArray(int[,,] array)// метод наполняет массив не повторяющимися двузначными случайными числами
            {
                for (int x = 0; x<array.GetLength(0); x++) //лист
                {
                    for (int y=0; y<array.GetLength(1); y++) //строка
                    {           
                        for (int z=0; z<array.GetLength(2); z++) //столбец
                        {           
                              // проверка на наличие повторений
                           for (int a = 0; a<array.GetLength(0); a++) //лист
                            {
                                for (int b=0; b<array.GetLength(1); b++) //строка
                                {           
                                    for (int c=0; c<array.GetLength(2); c++) //столбец
                                    {  
                                        int rnd  = new Random().Next(10,100); 
                                        if(rnd!=array[a,b,c])    array[x,y,z] =rnd;
                                        else rnd = new Random().Next(10,100); 
                                    }
                                } 
                            }         
                        }
                    }
                }
            }

            void PrintArray(int [,,] array) // метод выводяций массив на печать
            {
                for (int x = 0; x<array.GetLength(0); x++) //лист
                {
                    Console.WriteLine($" {x+1} лист ");
                    for (int y=0; y<array.GetLength(1); y++) //строка
                    {           
                        for (int z=0; z<array.GetLength(2); z++) //столбец
                        {           
                            Console.Write($" {array[x,y,z]} ({x}.{y}.{z})  ");
                        }
                     Console.WriteLine();
                    }
                Console.WriteLine();
                }
            }
        try
        {
                Console.Clear();
                Console.WriteLine("Данная программа генерирует трехмерный массив, размерность массива задается с клавиатуры," 
                                +" заполняет его случайными двузначными числами не повторяющимися и выводит его построчно" 
                                +"на на экран с указанием индекса каждого элемента.");
                Console.WriteLine();
                Console.Write("Введите колличество листов в массиве и нажмите  Enter. - ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
                int с = Convert.ToInt32(Console.ReadLine());
                int [,,] array3D = new int [a,b,с];
                FullArray(array3D);
                Console.WriteLine(); 
                PrintArray(array3D);
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