﻿// Задача необязательная 2:
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали 
// для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и 
// произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число 
// в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться 
// с людьми, например: 1 программист, 2 программиста, 5 программистов. В комнате может быть очень много программистов. 
// Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
             Console.Clear();
            Console.WriteLine("Данная программа принимает на вход любое положительное число от ноля до 9999 и в зависимости от введенного числа подставляет окончания.");
            Console.WriteLine("Введите число и нажмите ENTER");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число программистов =  " + number);

            // if (number>=0 & number<=9999)
            // {
                int n4 = number/1000;          // Тысячи.
                int n3 = (number/100) % 10;    // Сотни.   
                int n2 = (number/10) % 10;     //Десятки.
                int n1 = number % 10;         // Еденицы.
               
                int n = 0; // промежуточная переменная
                
                // отлавливаем числа заканчивающиеся на ноль
                if (n4 == 0 && n3 == 0 && n2 == 0 && n1 == 0) // введен ноль
                {
                   n=0;    
                }
                else
                   if (n4 == 0 && n3 == 0 && n2 != 0 && n1 == 0) // введено 10,20....90
                   {
                        n=10;
                    }
                    else
                   
                        if (n4 == 0 && n3 != 0 && n2 == 0 && n1 == 0) // введено 100,200....900
                        {
                            n=10;
                        }
                        else
                       
                            if (n4 != 0 && n3 == 0 && n2==0 && n1 ==0) // введено 1000, 2000,.....9000
                            {
                                n=10;
                            }
                                                       
                        
                   

                 //  отлавливаем числа заканчивающиеся на 1 и на 11

                 if (n1==1 && n2==1)
                 {
                     n=11;
                 }
                 else
                {
                     n=n1;
                }

                 switch(n)
                {
                        
                    case 0:
                     {
                        Console.WriteLine("В комнате нет программистOB.");
                        Console.WriteLine("Для выхода из программы нажмите ENTER.");
                        Console.ReadLine();
                        break;
                    }
                    case 1:
                    {
                        Console.WriteLine("В комнате находится "+ number+ " - программиСT.");
                        Console.WriteLine("Для выхода из программы нажмите ENTER.");
                        Console.ReadLine();
                        break;
                    }
                    
                    case 2:
                    case 3:
                    case 4:
                    {
                        Console.WriteLine("В комнате находится "+ number+ " - программисТА.");
                        Console.WriteLine("Для выхода из программы нажмите ENTER.");
                        Console.ReadLine();
                        break;
                    }
                    case 10: 
                    case 11:
                    {
                        Console.WriteLine("В комнате находится "+ number+ " - программисТОВ.");
                        Console.WriteLine("Для выхода из программы нажмите ENTER.");
                         Console.ReadLine();
                         break;
                    }               
                    default:   
                    {        
                        Console.WriteLine("В комнате находится "+ number+ " - программистОВ");
                        Console.WriteLine("Для выхода из программы нажмите ENTER.");
                        Console.ReadLine();
                        break;
                
                    }
                }
            

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