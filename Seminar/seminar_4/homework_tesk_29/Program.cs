/* Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
 N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры. */
internal partial class Program
{
    private static void Main(string[] args)
    {      
            // создадим метод  для наполнения массива числами
            void FillArrey (int [] Collection)
            {
                int length = Collection.Length;
                int index = 0;
                Console.WriteLine("Приступаем к формированию массива:");
                while (index<length)
                {
                    Console.WriteLine($"Введите {index+1} элемент массива и нажмите ENTER.");
                    Collection[index] = Convert.ToInt32(Console.ReadLine());
                    index++;
                }
            }
             // Сoздадим метод который будет выводить на печать наш массив
            void PrintArray(int [] Col )
            {
            int count = Col.Length;
            int position = 0;
            Console.WriteLine();
            Console.Write($"Вы ввели массив из {count} элементов: ");   
                while (position<count)
                {
                    Console.Write($"{Col[position]} ");
                    position++;
                }
                Console.WriteLine();
            }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа формирует массив из N элементов и выводит их на экран.");
            Console.WriteLine("______________________________________________________________________.");
            Console.WriteLine();
            Console.WriteLine("Введите какое колличество элементов будет в массиве и нажмите ENTER.");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[count];// задаем новый массив из N элементов
            FillArrey(array);// обращаемся к методу для заполнения нашего массива
            PrintArray(array); // обращаемся к методу для вывода массива в терминал
            Console.WriteLine();
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }
        catch 
        {
            Console.WriteLine(); 
            Console.WriteLine("Программа выполнена не будет.");        
            Console.WriteLine("Надо было вводить числа.");             
        }
    }
}
