// Задача 11 HARD - необязательная: 
// Напишите программу, которая принимает на вход целое число любой разрядности число и 
// удаляет вторую цифру слева направо этого числа.
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            // Console.Clear();
            Console.WriteLine("Данная программа принимает на вход любое положительное  число от 0  до 999999 и удаляет вторую цифру слева или сообщает, что ее нет");
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

                if ( n1 > 0 & n1<=9 ) Console.WriteLine("Число после удаления второй цифры - " +n2+ " слева = " +n1+n3+n4+n5+n6);
                else 
                    if ( n1 ==0 & n6 != 0 & n5 != 0 & n4 != 0 & n3 != 0 & n2!=0  ) Console.WriteLine("Число после удаления второй цифры - " +n3+ " слева = " +n2+n4+n5+n6);
                    else  
                        if (  n6 != 0 & n5 != 0 & n4 != 0 & n3 != 0 & n2==0 & n1 ==0) Console.WriteLine("Число после удаления второй цифры - " +n4+ " слева = " +n3+n5+n6);
                         else 
                            if ( n6 != 0 & n5 != 0 & n4 != 0 & n3 == 0 & n2==0 & n1 ==0) Console.WriteLine("Число после удаления второй цифры - " +n5+ " слева = " +n4+n6);
                             else 
                                if (n6 != 0 & n5 != 0 & n4 == 0 & n3 == 0 & n2==0 & n1 ==0) Console.WriteLine("Число после удаления второй цифры - " +n6+ " слева = " +n5);
                                 else 
                                    if (n6 != 0 & n5 == 0 & n4 == 0 & n3 == 0 & n2==0 & n1 ==0) Console.WriteLine("Вы ввели число у которого нет второго числа");
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