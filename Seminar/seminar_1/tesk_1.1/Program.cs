/* Написать программу, которая на вход принимает число
и выдает уго квадрат ( число умноженное само на себя)*/


Console.Clear(); // очищает консоль
Console.WriteLine("Введите целое число"); // просим ввести число
int namber = Convert.ToInt32(Console.ReadLine()); // введенное значение преобразуем в интежер и присваиваем в переменную
int sqrNamber = namber * namber; // возводим число в квадрат
Console.WriteLine("Вы ввели число " + namber); // вывод в консоль введенного числа для наглядности
Console.WriteLine("Квадрат числа  " + namber + "  равен  " + sqrNamber); // вывод на консоль
if (namber > 0) Console.WriteLine(" Вы ввели положительное число");
else
    if (namber < 0) Console.WriteLine("Вы ввели отрицательное число");
else
    Console.WriteLine("Вы ввели ноль");
Console.Read(); // Ожидание ввода команды 
