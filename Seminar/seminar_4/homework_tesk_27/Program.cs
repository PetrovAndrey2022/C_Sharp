/* Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


string sum(string number)
{
    int i=0;
    int length = number.Length; // отределяем длинну числа
    int result = 0;
    while (i<length)
    {
        int count =Convert.ToInt32(number[i]);
        result = result+count;
        i++;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число и нажмите ENTER.");
string number = Convert.ToString(Console.ReadLine());
int res = sum(number);
Console.WriteLine(res);






 