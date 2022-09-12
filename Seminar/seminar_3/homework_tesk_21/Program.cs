// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
internal partial class Program
{
    private static void Main(string[] args)
    {                
        double DistanceTwoPoints(double X1, double Y1, double Z1, double X2, double Y2,  double Z2)
        {                    
            double Distance= Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
            return Distance;
        }               
        try
        {    
            Console.Clear();
            Console.WriteLine("Данная программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
            Console.WriteLine("Введите значение X1 и нажмите ENTER.");
            double X1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y1 и нажмите ENTER.");
            double Y1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Z1 и нажмите ENTER.");
            double Z1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X2 и нажмите ENTER.");
            double X2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y2 и нажмите ENTER.");
            double Y2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Z2 и нажмите ENTER.");
            double Z2=Convert.ToDouble(Console.ReadLine());          
            
            Console.WriteLine($"Длина отрезка между двумя задаными точками равна = { DistanceTwoPoints(X1,Y1,Z1,X2,Y2,Z2)}");
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
         }
        catch
        {
            Console.WriteLine("Надо было вводить вещественные значения.");
        }
    }
}