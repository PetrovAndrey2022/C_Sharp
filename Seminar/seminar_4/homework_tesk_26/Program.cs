// Задача 26 HARD - необязательная: 
// Напишите программу, которая принимает на вход число (целое или вещественное) и выдаёт количество цифр в числе.
// 456 -> 3
// 0.78 -> 2
// 89.126 -> 5
internal class Program
{
    private static void Main(string[] args)
    {
               double sum(string? number)
                {           
                    int length = number.Length; // отределяем длинну числа
                    int result = 0;  
                    int i=0;          
                    while(i < length)
                    {
                        if (($"{number[i]}")=="0")  i++;   
                        if (($"{number[i]}")==".")  i++; 
                        if (($"{number[i]}")!=".")  result = result+1;               
                        i++;                                             
                    }
                    return result;             
                }   
        try
        {     
                // Console.Clear();
                Console.WriteLine("Данная программа принимает на вход число (целое или вещественное) и выдаёт количество цифр в числе.");
                Console.WriteLine("Введите число и нажмите ENTER.");
                string[] numbers = new string[0];
                string? number = Console.ReadLine();
                double sumNumber = sum(number);
                Console.WriteLine($"Количество цифр в числе -  {number} равна {sumNumber} .");
                Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
                Console.ReadKey();
        }
        catch
        {
             Console.WriteLine("Надо было вводить число.");
        }
        
    }
}
