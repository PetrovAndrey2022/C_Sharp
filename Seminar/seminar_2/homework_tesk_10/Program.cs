// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            // Console.Clear();
            Console.WriteLine("Данная программа принимает на вход трехзначное число, а на выходе показывает разряды этого числа");
            Console.WriteLine("Введите число и нажмите ENTER");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + number);
             if (number > 99 & number <= 999)
             {
                         
                int n100 = (number/100)%10;
                int n10 = (number/10)%10;
                int n1 = number % 10;
                       
                Console.WriteLine("Третья цифра  (сотни)   - цифра " + n100);
                Console.WriteLine("вторая цифра  (десятки) - цифра " + n10);
                Console.WriteLine("Первая цифра  (единицы) - цифра " + n1);
          
                 Console.WriteLine("Для выхода из программы нажмите ENTER");
                 Console.ReadLine();
            }
            else
                Console.WriteLine("вы ввели число не той разрядности");
                        
        }
        catch
        {
            Console.WriteLine("Программа выполнена не будет.");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Надо было вводить целое число.");
            Console.WriteLine("Для выхода из программы нажмите ENTER");
            Console.ReadLine();
        }
    }
}