// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо
//  и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

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
                            array[i,j]  = new Random().Next(10,100);
                          
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
       
       int[,] SelectionSort(int [,] array)
        {
            int index =0;
            int Max = array[index,0];
                      
            for (int i=0; i<array.GetLength(0); i++)
            {
                for (int j=0; j<array.GetLength(1); j++)
                {                  
                    if(array[i,j]>Max)
                    {
                    Max = array[i, j];
                    index=i;      
                    }      
                }   
            }
            Console.WriteLine($"Строка с максимальным элементом: {index}"); 
            int temp;
            for (int k=0; k<array.GetLength(0); k++)
            {
                for (int p=k+1; p<array.GetLength(1); p++)
                {
                    if (array[index,k]<array[index,p])
                    {
                        for (int i=0; i<array.GetLength(0); i++)
                        {
                            temp= array[i,p];
                            array[i,p]=array[i,k];
                            array[i,k]=temp;
                       }
                    }

                }
             }
        return array;
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа генерирует массив целых целых чисел размерностью m*n, m*n задается с клавиатуры," 
                             +" и сортирует элементы по возрастанию слева направо и сверху вниз");
            Console.WriteLine();
            Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int [m,n];
            FullArray(array);
            PrintArray(array);
            int[,] result =  SelectionSort(array);
            PrintArray(result);
             int[,] result1 =  SelectionSort(result);
            PrintArray(result1);
             int[,] result2 =  SelectionSort(result1);
            PrintArray(result2);
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