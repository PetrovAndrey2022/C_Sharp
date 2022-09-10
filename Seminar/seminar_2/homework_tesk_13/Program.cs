// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа принимает на вход любое положительное  число от 0  до 999999 и выводит третью цифру или сообщает, что ее нет");
            Console.WriteLine("Введите число и нажмите ENTER");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + number);
             if (number >= 0 & number <= 999999)
             {
                int n1 = number/100000;
                int n2 = (number/10000)%10;
                int n3= (number/1000)%10;
                int n4= (number/100)%10;
                int n5 = (number/10)%10;
                int n6 = number % 10;

                if ( n1 > 0 & n1<=9 ) Console.WriteLine("Вы ввели шестизначное число. Третья его цифра = "+ n3);
                else 
                    if ( n1 ==0 & n6 != 0 & n5 != 0 & n4 != 0 & n3 != 0 & n2!=0  ) Console.WriteLine("Вы ввели пятизначное число. Третья его цифра = "+ n4);
                    else  
                        if (  n6 != 0 & n5 != 0 & n4 != 0 & n3 != 0 & n2==0 & n1 ==0) Console.WriteLine("Вы ввели четырехзначное число. Третья его цифра = "+ n5);
                         else 
                            if ( n6 != 0 & n5 != 0 & n4 != 0 & n3 == 0 & n2==0 & n1 ==0) Console.WriteLine("Вы ввели трехзначное число. Третья его цифра = "+ n6);
                             else 
                                if (n6 != 0 & n5 != 0 & n4 == 0 & n3 == 0 & n2==0 & n1 ==0) Console.WriteLine("Вы ввели двухзнаxное число и у него нет третьей цифры");
                                 else 
                                    if (n6 != 0 & n5 == 0 & n4 == 0 & n3 == 0 & n2==0 & n1 ==0) Console.WriteLine("Вы ввели число у которого нет второго и третьего разряда");
                                     else 
                                        if (n6 == 0 & n5 == 0 & n4 == 0 & n3 == 0 & n2==0 & n1 ==0) Console.WriteLine("Вы ввели ноль ");
                                
                 Console.WriteLine("Для выхода из программы нажмите ENTER");
                 Console.ReadLine();
            }
            else
                Console.WriteLine("вы ввели число не той разрядности");
                        
        }
        catch
        {
            Console.WriteLine("Программа выполнена не будет.");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Надо было вводить целое число.");
            Console.WriteLine("Для выхода из программы нажмите ENTER");
            Console.ReadLine();
        }
    }
}