// Задача 41:
//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



internal class Program
{
    private static void Main(string[] args)
    {
        void FullArray(int[] array)// метод наполняет массив
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                
                Console.Write($" Введите {i+1}. число и нажмите Enter -  ");
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }
        }
        void PrintArray(int[] Col) // метод выводяций массив на печать
        {
            int length = Col.Length;
            Console.Write($"Пользователем было введено {Col.Length} чисел: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{Col[i]} ");
            }
            Console.WriteLine();
        }

        int  positiveNumbers(int[] array)// метод проверяющий, положительное ли число
        {
            int res =0;
            int length = array.Length;
            Console.Write("Положительными числами являются:");
            int i=0;
            while(i<length)
            {                
                if (array[i]>0)
                {
                     Console.Write($" {array[i]} "); 
                     res+=1; 
                     i++; 
                }             
                else i++;
            }
        Console.WriteLine();  
        return res;   
        }

        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа считает, сколько положительных чисел (больше нуля) было введено.");
            Console.WriteLine("Введите сколько чисел будете вводить и нажмите Enter.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FullArray(array);
            PrintArray(array);
            int result = positiveNumbers(array);
            Console.WriteLine($"Среди введенных чисел, положительных оказалось - {result} .");
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