
// вывести все числа от 0 до х введенного пользователем
Console.Clear();
Console.WriteLine("Введите число и нажмите enter");
int x = Convert.ToInt32(Console.ReadLine());
int i = 0;
Console.WriteLine("Вывод на консоль чисел в диапазоне от 0 до " + x);
while (i <= x)
{
    Console.Write(i + ", ");
    i++;

}




