// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



internal class Program
{
    private static void Main(string[] args)
    {
        void FullArray(int[] array)// метод наполняет массив случайными числами
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int number = new Random().Next(-1000,1000);
                array[i] = number;
            }
        }
        void PrintArray(int[] Col) // метод выводяций массив на печать
        {
            int length = Col.Length;
            Console.Write($"Был сгенерирован массив из {Col.Length} элементов - ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{Col[i]} ");
            }
            Console.WriteLine();
        }

        int  evenNumbers(int[] array)// метод вычисляющий сумму элементов стоящих на нечетных позициях
        {
            int res =0;
            int length = array.Length;
            Console.WriteLine("Элементами стояцими на нечетных позициях являются:");
            int i=1;
            while(i<length)
            {                
                Console.Write($" {array[i]} ");   
                res+=array[i];  
                i=i+2;
            }
        Console.WriteLine();  
        return res;   
        }

        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив из N элементов, N задается с клавиатуры и выводит сумму элементов стояцих на нечетных позициях.");
            Console.WriteLine("Введите число элементов в массиве и нажмите Enter.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FullArray(array);
            PrintArray(array);
            int result = evenNumbers(array);
            Console.WriteLine($"Сумма элементов массива стоящих на нечетных позициях равна - {result} .");
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