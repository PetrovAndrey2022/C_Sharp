// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


internal class Program
{
    private static void Main(string[] args)
    {
        void PrintNumber(int n) // метод выводяций число на консоль
        {
            int number=n;
            if (number>1)   Console.Write($" {number}, ");
            if (number==1)  // словия прекращения выполнения рекурсии
                {
                    Console.WriteLine($" {number}.");
                    return; 
                }
            number --;
            PrintNumber(number);
        }
        try
        {
            // Console.Clear();
            Console.WriteLine("Данная программа выводит на консоль все натуральные числа в промежутке от N до 1. Значение N задается с клавиатуры.");
            Console.WriteLine();
            Console.Write("Введите число N и нажмите Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
                if (n>0) PrintNumber(n); // При отрицательном значении даст переполнение памяти.
                else  Console.WriteLine("Не корректно введено значение, N должно быть больше 0.");
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