internal class Program
{
    private static void Main(string[] args)
    {
        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
            Console.WriteLine();
            }
        }
        // static void Main(string[] args)
        // {
            Console.Write("Введите размерность массива:\nn=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 20);
                    
                }
            }
            Console.WriteLine("\nИсходный массив:");
            Print(arr);
            int indi = 0;
            int max = arr[indi, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        indi = i;
                    }
            Console.WriteLine("\nСтрока с максимальный элементом: {0}", indi);
            int tmp;
            for (int k = 0; k < arr.GetLength(1); k++)
                for (int p = k + 1; p < arr.GetLength(1); p++)
                    if (arr[indi, k] < arr[indi, p])
                    {
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            tmp = arr[i, p];
                            arr[i, p] = arr[i, k];
                            arr[i, k] = tmp;
                        }
                    }
            Console.WriteLine("\nИтоговый массив:");
            Print(arr);
            Console.ReadKey();
        // }
    }
}