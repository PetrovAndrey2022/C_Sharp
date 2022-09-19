// Вести массив из n элементов, n вводится с клавиатуры,
// и вывести массив в терминал.

// метод который создает массив
internal partial class Program
{
    private static void Main(string[] args)
    {
        void FullArray(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Введите {i + 1} -й элемент массива и нажмите Enter.");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
        }


        void PrintArray(int[] Col)
        {

            int length = Col.Length;
            Console.Write($"Вы ввели массив из {Col.Length} элементов - ");

            for (int i = 0; i < length; i++)
            {

                Console.Write($"{Col[i]} ");
            }

            Console.WriteLine();

        }








        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа создает массив чисел из N элементов, N задается с клавиатуры и выводит его на печать (в терминал).");
            Console.WriteLine("Введите число элементов в массиве Enter.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FullArray(array);
            PrintArray(array);
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