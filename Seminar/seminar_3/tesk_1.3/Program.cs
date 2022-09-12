// Задача 21:
// Написать программу, которая принимает на вход коолдинаты двух точек и 
// находит расстояние между ними а 2 D пространстве.
// А(3,6); В(2,1) = 5.9
// А(7,-5); В(1,-1) = 7.21



// Метод возвращаемый расстояние между двемя точками
internal partial class Program
{
    private static void Main(string[] args)
    {
        
        
        double DistanceTwoPoints(double X1, double Y1, double X2, double Y2)
        {
          
            double resx= (X1-X2)*(X1-X2);
            double resy= (Y1-Y2)*(Y1-Y2);
            double Distance= Math.Sqrt(resx+resy);
            return Distance;
        }
               
        try
        {    
            Console.Clear();
            Console.WriteLine("Введите значение X1 и нажмите ENTER.");
            double X1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y1 и нажмите ENTER.");
            double Y1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X2 и нажмите ENTER.");
            double X2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y2 и нажмите ENTER.");
            double Y2=Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine($"Длина отрезка между двумя задаными точками равна = { DistanceTwoPoints(X1,Y1,X2,Y2)}");
            Console.WriteLine("Для выхода из программы нажмите ENTER.");
            Console.ReadLine();
         }
        catch
        {
            Console.WriteLine("Надо было вводить вещественные значения.");
        }
    }
}