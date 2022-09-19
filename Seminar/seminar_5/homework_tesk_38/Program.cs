// Задача 38: 
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


internal class Program
{
    private static void Main(string[] args)
    {
        void FullArray(double[] array)// метод наполняет массив случайными числами
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                double number = new Random().NextDouble();
                array[i] = number;
            }
        }
        void PrintArray(double[] Col) // метод выводяций массив на печать
        {
            int length = Col.Length;
            Console.Write($"Был сгенерирован массив из {Col.Length} элементов - ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{Col[i]} ");
            }
            Console.WriteLine();
        }

        double  evenNumbers(double[] array)// метод вычисляющий разницу между макс и мин элем массива
        { 
            int length = array.Length;
            double Max = 0;
            double Min = 0;
            double res = 0;
            Max = array.Max();
            Console.WriteLine($"Максимальным элементом массива является число- {Max}");  
            Min = array.Min();
            Console.WriteLine($"Максимальным элементом массива является число- {Min}");  
            res = Max - Min; 
        return res;   
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив вещественных чисел из N элементов, N задается с клавиатуры и выводит разницу между Max и Min элементами массива.");
            Console.WriteLine("Введите число элементов в массиве и нажмите Enter.");
            int n = Convert.ToInt32(Console.ReadLine());
            double [] array = new double[n];
            FullArray(array);
            PrintArray(array);
            double result = evenNumbers(array);
            Console.WriteLine($"Разница между Max и  Min элементами массива равна - {result} .");
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