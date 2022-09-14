/* Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

        // Метод возводящий в натуральную степень
        int ExtentNumber(int numberA, int numberB)
               {
            int result = numberA;
            for (int i=1; i<numberB;i++)
            {
             result = result * numberA;
            }
            return result;
        }
    try
    {
        //Console.Clear();
        Console.WriteLine("Данная программа принимает два числа (А и B) и возводит число А в натуральную степень числа В.");
        Console.WriteLine("Введите число А и нажмите ENTER.");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B и нажмите ENTER.");
        int numberB = Convert.ToInt32(Console.ReadLine());
        

        int res = ExtentNumber(numberA, numberB);// вызов метода
        Console.WriteLine( $"Число {numberA} возведенное в натуральную степень {numberB} равна {res}.");
        Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
        Console.ReadKey();
    }
    catch 
    {        
        Console.WriteLine("Надо было вводить число.");
    }
        
