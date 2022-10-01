// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

internal class Program
{
    private static void Main(string[] args)
    {
        int [,] FullArray(int[,] array)// метод наполняет массив по спирали
        {
            int n=array.GetLength(0);//количество строк в массиве (для удобства)
            int m=array.GetLength(1);//количество столбцов в массиве (для удобства)

            int Ibeg =0; // верхняя сторона треугольника
            int Ifin =0; // правая сторона треугольника
            int Jbeg =0; // нижняя сторона треугольника
            int Jfin =0; // лувая сторона треугольника 

            int k=1; // переменная для заполнения массива
            int i=0;
            int j=0;

            while (k<=n*m) // количество элементов в массиве
            {
                Console.Write($"Введите {k} элемент массива и нажмите Enter - ");
               int x = Convert.ToInt32(Console.ReadLine());
                array[i,j] = x;
                if (i==Ibeg && j<m-Jfin-1) // если у нас правая сторона прямоугольника и мы не достигли правой стороны, то двигаемся вправо - ++j
                    ++j;
                else 
                    if (j==m-Jfin-1 && i<n-Ifin-1) // если мы на правой стороне прямоугольника и не достигли нижней стороны, то двигаемся вниз - ++i
                        ++i;
                    else 
                        if (i==n-Ifin-1 && j>Jbeg) // если мы на нижней стороне прямоугольника и не достигли левой стороны, то двигаемся вниз - --j
                        --j;
                        else
                        --i;  // иначе мы на левой стороне и двигаемся вверх - --i

                if ((i==Ibeg+1)&&(j==Jbeg)&&(Jbeg!=m-Jfin-1))     // проверяем, не закончился ли первый прямоугольник (внешний)
                {    // увеличиваем отступы от краев первого прямойгольника
                    ++Ibeg;  
                    ++Ifin; 
                    ++Jbeg; 
                    ++Jfin;
                }
            ++k;
            }
        return array;  
        }
        void PrintArray(int [,] Col) // метод выводяций массив на печать
        {
             for (int i = 0; i < Col.GetLength(0); i++)
                {
                        for (int j=0; j<Col.GetLength(1); j++)
                        {           
                            Console.Write($" {Col[i,j]}  ");
                        }
                Console.WriteLine();
                }
             Console.WriteLine();
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа заполняет двумерный массив по спирали, размерность массива задается с клавиатуры," 
                             +" ввод элементов массива тоже вводится вручную и выводит на экран.");
            Console.WriteLine();
            Console.Write("Введите колличество строк в массиве и нажмите  Enter. - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов в массиве и нажмите  Enter. - ");
            int b = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int [a,b];
            int [,] result = FullArray(array);
            Console.WriteLine($" Массив заполненный по спирали");
            Console.WriteLine();
            PrintArray(result);
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