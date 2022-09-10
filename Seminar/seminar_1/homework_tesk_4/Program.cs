/* Задача 4: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. */

Console.Clear();
Console.WriteLine("Данная программа из трех введенных вами чисел, определяет какое число является Max, а какое Min.");
Console.WriteLine("Введите первое число и нажмите ENTER");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите ENTER");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число и нажмите ENTER");
int number3 = Convert.ToInt32(Console.ReadLine());
// проверка корректности ввода чисел
if (number1 == number2 & number2 == number3)
{
    Console.WriteLine("ВВЕДЕНЫ ОДИНАКОВЫЕ ЧИСЛА!!!");
}
// нахождение максимального числа 
int Max = number1;
if (Max < number2)
{
    Max = number2;
    if (Max < number3)
        Max = number3;
}
// нахождение минимального числа
int Min = number1;
if (Min > number2)
{
    Min= number2;
    if (Min > number3)
        Min = number3;
}
Console.WriteLine("Вы ввели три числа "+ number1+ ", "+ number2+", "+ number3);
Console.WriteLine("Maximum number it is = "+ Max);
Console.WriteLine("Minimum number it is = "+ Min); 
Console.WriteLine("Для выхода из программы нажмите ENTER");
Console.ReadLine();