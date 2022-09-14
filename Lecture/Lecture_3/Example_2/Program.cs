//Метод void, который ничего не принимает, но что-то возвращает.


void method2(string msg)
{
Console.WriteLine(msg);
}



void method22(string msg, int count)
{
    int i=0;
    while (i < count)
    {
        Console.Write($"{i}._ ");// интерполяция
        Console.WriteLine(msg);
        i++;// инкримент
    }

}



method2("Привет!");
Console.WriteLine();
method22("Привет!", 6);
Console.WriteLine();
method22(count:4, msg: "Привет Мир!");