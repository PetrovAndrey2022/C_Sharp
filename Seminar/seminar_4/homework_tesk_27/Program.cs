/* Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
internal class Program
{
    private static void Main(string[] args)
    {
        
        try
        {        
            int sum(string? number)
             {           
                int length = number.Length; // отределяем длинну числа
                int result = 0;
                for (int i = 0; i < length; i++)
                {
                    int res = int.Parse($"{number[i]}");            
                    result = result+res;
                }
                return result;        
             }        
            
            Console.Clear();
            Console.WriteLine("Данная программа принимает на вход число и выдаёт сумму цифр в этом числе.");
            Console.WriteLine("Введите число и нажмите ENTER.");
            string[] numbers = new string[0];
            string? number = Console.ReadLine();
            int sumNumber = sum(number);
            Console.WriteLine($"Сумма цифр в числе -  {number} равна {sumNumber} .");
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }
        catch
        {
             Console.WriteLine("Надо было вводить число.");
        }
        
    }
}





