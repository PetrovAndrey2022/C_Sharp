 /* Напишите программу, которая выводит случайное 
 число из отрезка [10, 99] и показывает наибольшую цифру числа. */

/* Console.Write ("Введите целое число ");
            try
                {
                int x=Convert.ToInt32 (Console.ReadLine());
 
                Console.WriteLine(x*10);

                }
            catch 
            {
                
                Console.WriteLine("надо было вводить именно целое число");
            }
 */
void CompareDigits ()
{
int x = new Random().Next(10,100);
int x1=x/10;
int x2= x%10;
Console.WriteLine($"Сгенерировано случайное число {x} ");
if (x1>x2) Console.WriteLine(" первая цифра больше");
else if (x2>x1) Console.WriteLine("вторая цифра больше");
else Console.WriteLine ("Это палиндром");
}
CompareDigits;