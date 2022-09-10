// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

//Console.Clear(); // очищаем консоль
Console.WriteLine("Эта программа по введенному числу определяет день недели ипроверяет, является ли он выходным.");
Console.WriteLine("Введите цифрой день недели и нажмите Enter.");// Приглошение ко вводу данных
try
{
    int DayWeek = Convert.ToInt32(Console.ReadLine()); // задаем переменную в которой будет хранится введенное значение
    switch(DayWeek)
    {
        case 1:
            Console.WriteLine("Введенное число соответствует Понедельнику.");
            break;
        case 2:
            Console.WriteLine("Введенное число соответствует Вторнику.");
            break;
        case 3:
            Console.WriteLine("Введенное число соответствует Среде.");
            break;
        case 4:
            Console.WriteLine("Введенное число соответствует Четвергу.");
            break;
        case 5:
            Console.WriteLine("Введенное число соответствует Пятнице.");
            break;
        case 6:
            Console.WriteLine("Введенное число соответствует Субботе.");
            break;
        case 7:
            Console.WriteLine("Введенное число соответствует Воскресенью.");
            break;
        default:           
            Console.WriteLine("Введенное число не соответствует дням недели.");
            break;
    }
    if (DayWeek==6|DayWeek==7)// true если хоть один true
    {
        Console.WriteLine("Да, это является выходной.");
        Console.WriteLine("Для выхода из программы нажмите Enter.");
        Console.ReadLine();
    }
     else 
     {
      if (DayWeek>=1&DayWeek<=5)  
        { 
            Console.WriteLine("Нет, это является рабочий день.");
            Console.WriteLine("Для выхода из программы нажмите Enter.");
            Console.ReadLine();
        }
     }
}
catch
{
    Console.WriteLine("Не корректно введено значение.");
    Console.WriteLine("Для выхода из программы нажмите Enter.");
    Console.ReadLine(); 
}
