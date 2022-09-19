//Написать метод, который будет выводить таблицу умножения с использованием 
//вложенного цикла for .


Console.Clear();
int x = 1;
int y = 30;
Console.SetCursorPosition(x,y);
for (int i=1; i<2; i++)
{   
    for (int j=1; j<=10; j++)
    {
        
        Console.WriteLine($"{i}*{j}={i*j}");
        y=1+j;
        Console.SetCursorPosition(x,y);

    }



    // Console.SetCursorPosition(40,10);


}


// int xc = 80;
// int yc = 30;
//Console.SetCursorPosition(xa,ya);
// Console.SetCursorPosition(xb,yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc,yc);
// Console.WriteLine("+");