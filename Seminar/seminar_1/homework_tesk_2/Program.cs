/*  Задача 2:
  Напишите программу, которая на вход принимает два числа и выдаёт, 
  какое число большее, а какое меньшее. */

Console.Clear();
Console.WriteLine("Данная программа из двух введенных вами чисел, определяет какое число является Max, а какое Min.");
Console.WriteLine("Введите первое число и нажмите ENTER");
int number1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите ENTER");
int number2= Convert.ToInt32(Console.ReadLine());
int Max=number1;
int Min=number2;
    if(number1==number2)//проверка не одинаковые ли числа
    {
        Console.WriteLine("Вы ввели одинаковые числа " + number1+ " и "+ number2);
        Console.WriteLine(                                                      );// выводим пустую строку
    }
    if (number1>number2)// сравнение чисел
    {
        Console.WriteLine("Из двух введенных вами чисел "+ number1+ " и "+ number2);
        Console.WriteLine("Maximum number it is = "+ number1);
        Console.WriteLine("Minimum number it is = "+ number2); 
        Console.WriteLine(                                  );// выводим пустую строку
    }
    else
    {    // меняем значения чисел местами
        int numberx=number2;
        Min=number1;
        Max=numberx;
        Console.WriteLine("Из двух введенных вами чисел "+ number1+ " и "+ number2);
        Console.WriteLine("Maximum number it is = "+ number2);
        Console.WriteLine("Minimum number it is = "+ number1); 
        Console.WriteLine(                                  );          

    }
Console.WriteLine("Для выхода из программы нажмите ENTER");
Console.ReadLine();