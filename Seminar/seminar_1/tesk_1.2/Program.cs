
// Написать программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго


Console.Clear(); // очищает консоль
Console.WriteLine("Введите первое целое число и нажмите enter"); // просим ввести первое число
int namberA = Convert.ToInt32(Console.ReadLine()); // введенное значение преобразуем в интежер и присваиваем в переменную
Console.WriteLine("Введите второе целое число и нажмите enter"); // просим ввести первое число
int namberB = Convert.ToInt32(Console.ReadLine()); // введенное значение преобразуем в интежер и присваиваем в переменную
int sqrNamberA = namberA * namberA; // возводим первое число в квадрат
int sqrNamberB = namberB * namberB; //возводим второе число в квадрат
Console.WriteLine("Вы ввели числа: "); // вывод в консоль 
Console.WriteLine("   первое число -  " + namberA); // вывод в консоль введенного числа для наглядности
Console.WriteLine("   второе число -  " + namberB); // вывод в консоль введенного числа для наглядности
Console.WriteLine(); // пустая строка
Console.WriteLine("Квадраты введенных чисел равны: "); // вывод в консоль 
Console.WriteLine("   квадрат первого числа равен - " + sqrNamberA);
Console.WriteLine("   квадрат второго числа равен - " + sqrNamberB);
Console.WriteLine(); // пустая строка
if (sqrNamberA == namberB) Console.WriteLine("Первое введенное число является квадратом второго введенного числа.");
else
    Console.WriteLine("Первое введенное число НЕ является квадратом второго введенного числа.");
if (sqrNamberB == namberA) Console.WriteLine("Второе введенное число является квадратом первого введенного числа.");
else
    Console.WriteLine("Второе введенное число НЕ является квадратом первого введенного числа.");
Console.WriteLine(); // пустая строка
Console.WriteLine("Для выхода из программы нажмите enter");
Console.Read(); // Ожидание ввода команды 
