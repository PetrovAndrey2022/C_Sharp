// Задача 18:
// Напишите программу, которая по заданому номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (X и Y).




internal class Program
{
    private static void Main(string[] args)
    {


        void fourth(int number)
        {
            if (number == 1)
            {
                Console.WriteLine("В первой четверти X может принимать значения от +0 до  +2.147.483.647.");
                Console.WriteLine("В первой четверти Y может принимать значения от +0 до  +2.147.483.647.");
            }
            if (number == 2)
            {
                Console.WriteLine("В первой четверти X может принимать значения от +0 до +2.147.483.647.");
                Console.WriteLine("В первой четверти Y может принимать значения от -1 до -2.147.483.648.");
            }
            if (number == 3)
            {
                Console.WriteLine("В первой четверти X может принимать значения от -1 до -2.147.483.648.");
                Console.WriteLine("В первой четверти Y может принимать значения от -1 до -2.147.483.648.");
            }
            if (number == 4)
            {
                Console.WriteLine("В первой четверти X может принимать значения от +0 до +2.147.483.647.");
                Console.WriteLine("В первой четверти Y может принимать значения от -1 до -2.147.483.648.");
            }
            if (number < 1 || number >4) 
            {
                Console.WriteLine("Всего может быть 4 координатные четверти от 1 до 4.");
            }
        }
        
        try
        {
            Console.Clear();
            Console.WriteLine("Введите номер координатной четверти.");
            int number = Convert.ToInt32(Console.ReadLine());
            fourth(number);

        }
        catch
        {
            Console.WriteLine("Надо было вводить целое число.");
        }
        Console.WriteLine("Для выхода из программы нажмите ENTER.");
        Console.ReadLine();



    }
}