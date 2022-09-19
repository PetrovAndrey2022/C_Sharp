// Задача 26:
// Напишите программу которая принимает на вход число
// и выдает количество цифр в числа.


    // Метод считающий сумму чисел в числе
    int Sum (string number)
    {
        int sum=0;
        int length = number.Length;
        for (int i=0; i<length; i++)
        {
            int res=int.Parse($"{number [i]}");
            sum*=res;
        }

        return sum;
    }


    int Number (string number)
    {
        int sum=0;
        int length = number.Length;
        for (int i=0; i<length; i++)
        {
           sum=length;
        }

        return sum;
    }



 try
        {  
            Console.Clear();
            Console.WriteLine("Данная программа принимает число и выдает сумму чисел в числе и кол-во цифр в числе.");
            Console.WriteLine("Введите число и нажмите Enter.");
            string [] number = new string [0];
            string? number1 = Console.ReadLine();
            int sum = Sum (number1); // считаем сумму чисел в числе
            int sum1 = Number(number1); // считаем кол-во чисел в числе
            Console.WriteLine($"Сумма цифр в числе {number1} равна {sum}.");
            Console.WriteLine($"Сумма чисел в числе {number1} равна {sum1}.");
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Надо было вводить число.");
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }


    //     для расчета длинны числа можно использовать алгоритм
    // double fromLog = 0;
    // fromLog = Math.Floger(Math.Log10(n)+1);
    // Console.WriteLine (fromLog);