// Условия задачи.
// Напишите программу, которая принимает на вход трехзначное число
//  и на выходе показывает последнюю цыфру этого числа


try
{
    Console.Clear();
    Console.WriteLine("Данная программа принимает на вход трехзначное число и выводит его последнюю цифру");
    Console.WriteLine("Введите трехзначное число и нажмите ENTER");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вы ввели число "+ number);
    int n = number%10;
    Console.WriteLine("Последней цифрой введенного вами числа "+number+ " является цифра "+n);
    Console.WriteLine("Для выхода из программы нажмите ENTER");
    Console.ReadLine();
}
catch
{
    Console.WriteLine("Программа выполнена не будет.");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Надо было вводить число.");
    Console.WriteLine("Для выхода из программы нажмите ENTER");
    Console.ReadLine();
}




