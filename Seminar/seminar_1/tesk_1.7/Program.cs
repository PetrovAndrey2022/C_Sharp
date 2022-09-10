// Условия задачи.
// Напишите программу, которая принимает на вход трехзначное число
//  и на выходе показывает первую цыфру этого числа


internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа принимает на вход любое положительное шестизначное число и раскладывает его по разрядам");
            Console.WriteLine("Введите число и нажмите ENTER");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + number);
             if (number > 0 & number <= 999000)
             {
                int n100000 = number/100000;
                int n10000 = (number/10000)%10;
                int n1000 = (number/1000)%10;
                Console.WriteLine("Первая цифра (сотни тысяч  )  является цифра " + n100000);
                Console.WriteLine("Вторая цифра (десятки тысяч)  является цифра " + n10000);
                Console.WriteLine("Третья цифра        (тысячи)  является цифра " + n1000);
            
                int n100 = (number/100)%10;
                int n10 = (number/10)%10;
                int n1 = number % 10;
                       
                Console.WriteLine("Четвертая цифра      (сотни)  является цифра " + n100);
                Console.WriteLine("Пятая цифра        (десятки)  является цифра " + n10);
                Console.WriteLine("шестая цифра       (единицы)  является цифра " + n1);
          
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