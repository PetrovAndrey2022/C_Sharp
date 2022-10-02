// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


internal class Program
{
    private static void Main(string[] args)
    {
        int FunctionA(int m, int n) // метод вычисляет функцию Аккермана для двух неотрицательных чисел m до n
        {
          
            if (m == 0)  return n + 1;
            else
            { 
                if ((m != 0) && (n == 0)) return FunctionA(m- 1, 1);
                else return FunctionA(m - 1, FunctionA(m, n - 1));
            }
        }
        try
        {
            // Console.Clear();
            Console.WriteLine("Данная программа вычисляет функцию Аккермана. Значение M и N задается с клавиатуры.");
            Console.WriteLine();
            Console.Write("Введите число M  и нажмите Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число N и нажмите Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0 && m >= 0)  // При отрицательном значении даст переполнение памяти.
                {
                    int result = FunctionA(m,n);
                    Console.Write($"Результат вычисления функции Аккермана для двух чисел  А({m},{n}) = {result}");
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