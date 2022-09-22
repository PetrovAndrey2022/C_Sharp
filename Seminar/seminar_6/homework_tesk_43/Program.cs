// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

internal class Program
{
    private static void Main(string[] args)
    {
        string GrossingPoint(int b1, int k1, int b2, int k2)// метод вычисляющий точку пересесения двух прямых
        {
            Console.WriteLine();
            Console.WriteLine("Решаем систему уравнений:");
            Console.WriteLine("y = k1 * x + b1");
            Console.WriteLine("y = k2 * x + b2");
            Console.WriteLine();
            Console.WriteLine("Вычтем из первого уравнения второе:");
            Console.WriteLine("y-y=k1*x+b1-(k2*x+b2)");
            Console.WriteLine("y = k2 * x + b2");
            Console.WriteLine();
            Console.WriteLine("Найдем значение переменной x:");
            Console.WriteLine("0=k1*x+b1-k2*x-b2");
            Console.WriteLine("y = k2 * x + b2");
            Console.WriteLine("х(k1-k2)=b2-b1");
            Console.WriteLine("y = k2 * x + b2"); 
            Console.WriteLine();   
            Console.WriteLine("x=(b2-b1)/(k1-k2)");   
            Console.WriteLine("y = k2 * x + b2"); 
            Console.WriteLine(); 
            double x1 = b2-b1;   // промежуточные значения
            double y1 = k1-k2;   // промежуточные значения
            double x = (x1/y1);
            double  y = k2 * x + b2;
        return  $"Точка пересечения двух прямых имеет координаты: x ={x}, y={y}";
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2, значения b1, k1, b2 и k2 задаются пользователем.");
            Console.WriteLine("Введите значение b1 и нажмите Enter.");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение k1 и нажмите Enter.");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b2 и нажмите Enter.");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение k2 и нажмите Enter.");
            int k2 = Convert.ToInt32(Console.ReadLine());         
            Console.WriteLine(GrossingPoint(b1,k1,b2,k2));
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