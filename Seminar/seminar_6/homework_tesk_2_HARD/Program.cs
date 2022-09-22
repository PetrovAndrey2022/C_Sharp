// задача 2 HARD необязательная. 
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное 
// число и его индекс. Вывести эту информацию на экран.


internal class Program
{
    private static void Main(string[] args)
    {
        void FullArray(int[,] array)// метод наполняет массив случайными числами
        {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                        for (int j=0; j<array.GetLength(1); j++)
                        {           
                            int number = new Random().Next(100,999);
                            array[i,j] = number;
                        }
                }
        }
        void PrintArray(int [,] Col) // метод выводяций массив на печать
        {
            Console.WriteLine();
            Console.WriteLine("Сгенерированый двухмерный массив.");
            Console.WriteLine();
             for (int i = 0; i < Col.GetLength(0); i++)
                {
                        for (int j=0; j<Col.GetLength(1); j++)
                        {           
                            Console.Write($" {Col[i,j]} ");
                        }
                Console.WriteLine();
                }
             Console.WriteLine();
        }
        void  EvenNumbers(int[,] array)// метод вычисляющий Max и Min элементы массива и их индексы
        {  
            int Max = array[0, 0];
            int indexi = 0;
            int indexj = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                            if(array[i,j]> Max)
                            {
                                Max = array[i, j];
                                indexi = i;
                                indexj = j;             
                            }         
                    }
                }
             Console.WriteLine($"Максимальным элементом массива является число- {Max} c индексом [{indexi},{indexj}] "); 
    
            int Min = array[0, 0];
            int index_i = 0;
            int index_j = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                            if(array[i,j]< Min)
                            {
                                Min = array[i, j];
                                index_i = i;
                                index_j = j;                    
                            }            
                    }
                }
            Console.WriteLine($"Максимальным элементом массива является число- {Min} c индексом [{index_i},{index_j}] ");    
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив случайных целых чисел размерностью m*n, m*n задается с клавиатуры, находит  Max и Min элементами массива и их индексы.");
            Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int [m,n];
            FullArray(array);
            PrintArray(array);
            EvenNumbers(array);
            // Console.WriteLine($"Разница между Max и  Min элементами массива равна - {result} .");
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