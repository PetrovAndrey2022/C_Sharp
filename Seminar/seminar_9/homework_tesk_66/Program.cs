// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30



internal class Program
{
    private static void Main(string[] args)
    {
        void SumNumbers(int m, int n, int sum=0) // метод считающий сумму чисел от m до n
        {
            if (m<n)
            {
                sum+=m;
                m++;
                SumNumbers(m, n, sum);
            } 
            else Console.Write($"{sum+m}");
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа находит сумму натуральных элементов в диапазоне от M до N. Значение M и N задается с клавиатуры.");
            Console.WriteLine();
            Console.Write("Введите число M (начальное значение в натуральном ряде чисел) и нажмите Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число N (конечное значение в натуральном ряде чисел) и нажмите Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && m > 0 && m < n)  // При отрицательном значении даст переполнение памяти.
                {
                    Console.Write($" Сумма чисел натурального ряда в диапазоне от {m} до {n} равна = ");
                    SumNumbers(m,n);
                    Console.WriteLine();
                }
                else Console.WriteLine("Не корректно введено значение.");
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