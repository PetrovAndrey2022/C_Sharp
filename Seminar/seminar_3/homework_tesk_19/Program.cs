// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            //Console.Clear();
            Console.WriteLine("Данная программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
            Console.WriteLine("Введите число и нажмите ENTER");
            int number = Convert.ToInt32(Console.ReadLine());
           
                int n5 = (number / 10000) % 10;
                int n4 = (number / 1000) % 10;
                int n3 = (number / 100) % 10;
                int n2 = (number / 10) % 10;
                int n1 = number % 10;

                if (n2 == n4 & n1 == n5) 
                    Console.WriteLine("Введенное число является палиндромом ");
                else 
                    Console.WriteLine("Введенное число не является палиндромом ");


                Console.WriteLine("Для выхода из программы нажмите любую клавишу");
                Console.ReadKey();
         
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