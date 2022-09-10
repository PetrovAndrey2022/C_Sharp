// Условия задачи
// Написать программу, которая на вход принимает одно число (N),
// а на  выходе показывает все целые числа в промежутке от -N до N
try
{
    Console.Clear();
    Console.WriteLine("Введите число и нажмите enter");
    int n = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введенное число = "+n);
    int i = -n; 
    
    while (i <= n)
    {
        Console.Write(i + ", ");
        i++;
    }
}
catch
{
    Console.WriteLine("Не корректно введено значение");
}

