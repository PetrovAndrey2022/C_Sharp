/* Напишите программу, которая будет выдавать название дня 
недели по заданному номеру.  */


Console.Clear(); // очищаем консоль
Console.WriteLine("Введите цифрой день недели и нажмите Enter");// Приглошение ко вводу данных
int DayWeek = Convert.ToInt32(Console.ReadLine()); // задаем переменную в которой будет хранится введенное значение
// Проверяем корректность ввода дней недели с клавиатуры
/* if (DayWeek > 0 & DayWeek <= 7)
{
    if (DayWeek == 1) Console.WriteLine("Введенное число соответствует Понедельнику");
    if (DayWeek == 2) Console.WriteLine("Введенное число соответствует Вторнику");
    if (DayWeek == 3) Console.WriteLine("Введенное число соответствует Среде");
    if (DayWeek == 4) Console.WriteLine("Введенное число соответствует Четвергу");
    if (DayWeek == 5) Console.WriteLine("Введенное число соответствует Пятнице");
    if (DayWeek == 6) Console.WriteLine("Введенное число соответствует Субботе");
    if (DayWeek == 7) Console.WriteLine("Введенное число соответствует Воскресенью");
                      Console.WriteLine("_________________________________________");
}
else
{
    Console.WriteLine("Некорректно введен день недели");
    Console.WriteLine("______________________________");
}
*/


switch(DayWeek)
{
    case 1:
        Console.WriteLine("Введенное число соответствует Понедельнику");
        break;
    case 2:
        Console.WriteLine("Введенное число соответствует Вторнику");
        break;
    case 3:
        Console.WriteLine("Введенное число соответствует Среде");
        break;
    case 4:
        Console.WriteLine("Введенное число соответствует Четвергу");
        break;
    case 5:
        Console.WriteLine("Введенное число соответствует Пятнице");
        break;
    case 6:
        Console.WriteLine("Введенное число соответствует Субботе");
        break;
    case 7:
        Console.WriteLine("Введенное число соответствует Воскресенью");
        break;
    default:
        Console.WriteLine("Введенное число не соответствует дням недели");
        break;
}
Console.WriteLine("Для выхода из программы нажмите Enter");
Console.ReadLine(); 
