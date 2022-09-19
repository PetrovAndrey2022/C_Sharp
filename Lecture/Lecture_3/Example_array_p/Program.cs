// Задача
// Сортировка массива методом выбора
// Смысл сортировки заключается:
//  1. чтобы найти мин элемент в неотсортир массиве
//  2.  поставить его на первую позицию
// 3. повторять пока не отсортируем все


// метод наполняющий массив
internal partial class Program
{
    private static void Main(string[] args)
    {
        void FullArray(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Введите {i + 1} -й элемент массива с индексом {i} ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        // метод выводящий массив на печать
        void PrintArray(int[] array)
        {
            int length = array.Length;
           
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{array[i]}");
            }
           
        }

        // Метод который выполняет сортировку
        void SelectionSort(int [] array)
        {
            int length = array.Length;          

            for (int i=0; i<length; i++)
            {
                int minPosition = i;// присваиваем мин значение первому элементу
                for (int j=0; j<length; j++)
                {
                   
                    // Console.Write($"  при j= {j} ");
                    if(array[j]<array[minPosition])
                        {
                        minPosition = j;
                        int temporary = array[i];
                        array[i] = array[minPosition];
                        array[minPosition]=temporary;
                        // Console.WriteLine($" minPosition = {array[minPosition]} ");
                        }
                }     
               
            }


        }

        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа принимает массив, сортирует его методом выбора, выводит отсортированный массив.");
            Console.WriteLine("Введите число элементов в массиве и нажмите Enter.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FullArray(array);
            Console.Write("Вы ввели массив, массив не отсортирован: ");
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив ");
            SelectionSort(array);
            PrintArray(array);
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