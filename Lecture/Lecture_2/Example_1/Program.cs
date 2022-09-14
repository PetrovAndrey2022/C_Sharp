// Задача:
// Найти Max  из 9 чисел с использованием метода


internal class Program
{
    private static void Main(string[] args)
    {
        //метод который возвращает значение максимального числа из трех
        int Max(int arg1, int arg2, int arg3)
        {
            int result = arg1;// присваиваем максимальное значение первому аргументу
            if (arg2 > result) result = arg2;
            if (arg3 > result) result = arg3;
            return result;
        }
        Console.WriteLine("Введите значение числа a1");
        int a1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение числа b1");
        int b1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение числа c1");
        int c1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение числа a2");
        int a2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение числа b2");
        int b2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение числа c2");
        int c2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение числа a3");
        int a3=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение числа b3");
        int b3=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение числа c3");
        int c3=Convert.ToInt32(Console.ReadLine());


        int max1 = Max(a1, b1, c1);
        int max2 = Max(a2, b2, c2);
        int max3 = Max(a3, b3, c3);

        int max = Max(max1, max2, max3);
        Console.WriteLine(max);
    }
}