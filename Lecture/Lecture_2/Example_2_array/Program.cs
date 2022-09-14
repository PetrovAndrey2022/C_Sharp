/* Массивы

задаем массив:  
    int [] array = {1,2,3,4,5,6,7,8,9,10}; // массив из 10 элементов

    int [] array = {0,0,0,0,0};// пустой массив из 5 элементов
    int [] array = new int [5]; // новый массив из 5 элементов
    int [] array = new int []; // создать новый массив пустой
    int [] array = new int [5] {1,0,2,0,5}; // создать новый масссив  из 5 элементов */


// ЗАДАЧА:
// Найти Max из 9 чисел с использованием массива.

internal partial class Program
{
    private static void Main(string[] args)
    {
       

        //array[0] = 12; // обращаемся к элементу массива с индексом 0 и изменяем его значение с 1 на 12
                       //Console.WriteLine(array);// вывести на консоль весь массив
       // Console.WriteLine(array[0]);  // вывести на консоль элемент массива с индексом 0


        int Max(int arg1, int arg2, int arg3)
        {
            int result = arg1;// присваиваем максимальное значение первому аргументу
            if (arg2 > result) result = arg2;
            if (arg3 > result) result = arg3;
            return result;
        }
      
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // задаем новый массив из 9 элементов
        int max = Max( Max(array[0], array[1], array[2]),
                       Max(array[3], array[4], array[5]),
                       Max(array[6], array[8], array[8]));

        Console.WriteLine(max);
    }

}