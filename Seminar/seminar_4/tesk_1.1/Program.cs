// Задача 24:
// Написать программу, которая принимает на вход числа (А) и выдвет сумму чисел
// от 1 до А



internal class Program
{
    private static void Main(string[] args)
    {
        int sunNumber(int number)
        {
            int sum = 0;
            if (number>1)
            {
                    for (int i = 1; i <= number; i++)
                    {
                        sum += i;
                        Console.WriteLine($" При i= {i} сумма равна = {sum}");
                    }
            
            }
             else
            {
                    Console.WriteLine(" Не корректный ввод, надо было вводить положительное число больше 1.");
            }
             return sum;
        }


        try
        {  
            Console.Clear();
            Console.WriteLine("Данная программа принимает число и выдает сумму чисел от 1 до этого числа.");
            Console.WriteLine("Введите число и нажмите Enter.");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = sunNumber(number);
            Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}.");
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