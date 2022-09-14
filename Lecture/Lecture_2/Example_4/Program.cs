// ЗАДАЧА
// Имеем одномерный массив из n элементов,
// требуется найти элемент массива, равный find. Наполнение массива выполнить 
//с помощью метода и генератора псевдослучайных чисел


internal partial class Program
{
    private static void Main(string[] args)
    {
        

        // создадим метод void для наполнения массива числами

        void FillArrey (int [] Collection)// метод которфй наполняет массив случайными числами
        {
            int length = Collection.Length;
            int index = 0;

            while (index<length)
            {
                Collection[index] = new Random().Next(1,20);
                index++;
            }

        }


        // Сщздадим метод который будет выводить на печать наш массив
        void PrintArray(int [] Col )// метод который выводит массив на консоль
        {
           int count = Col.Length;
           int position = 0;
                             
            while (position<count)
            {
                Console.WriteLine(Col[position]);
                position++;
            }
        }

        // Создадим метод, который будет находить индекс элемента массива
        // ( будет точнее сказать возврацать значение - индекс)

        int indexOf(int [] Collection, int fint)
        {
            int count = Collection.Length;
            int index = 0;
            int position = 0;

            while (index<count)
            {
                if(Collection[index]==fint) // если значение с текуцим значением индекса совпадает с fint
                {
                    position=index;
                    index++;
                }
            }
            return position;
        }


        int[] array = new int[10];// задаем новый массив из 10 элементов

        FillArrey(array);// обращаемся к методу для заполнения нашего массива
        array[4]=4;
        array[8]=4;
        PrintArray(array); // обращаемся к методу для вывода массива в терминал

        Console.WriteLine();

        int pos = indexOf(array, 4); // обращаемся к массиву для того, чтобы проверить есть ли в массиве число 4

        Console.WriteLine(pos);


    }
}