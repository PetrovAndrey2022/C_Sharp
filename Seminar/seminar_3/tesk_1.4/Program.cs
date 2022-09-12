// Задача 22:
// Написать программу, которая принимает на вход чисто (N)
// и выдает таблицу квадратов чисет от 1 до N.
// 5 - 1,4,9,16,25
// 2-1,4


internal class Program
{
    private static void Main(string[] args)
    {
        string SquareNumbers(int n)
        {
            string square_numbers= $"числа {n} = ";

            for (int i = 1; i<= n; i++)
            {
             square_numbers = square_numbers+ $" {Math.Pow(i, 2)}";
            }
            return square_numbers; 
        }
         try
        {
            Console.Clear();
            Console.WriteLine("Данная программа принимает на вход число N и выдает таблицу квадратов чисел от 1 до n.");
            Console.WriteLine("Введите значение числа n и нажмите ENTER.");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));


            Console.WriteLine($"Таблица квадратов {SquareNumbers(n)}");
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Надо было вводить вещественные значения.");
        }
    }
}