﻿//Console.Clear(); //очищает консоль
//Console.SetCursorPosition(10, 4); //задает отступ от краев (верх -10 пикселей,  строка 4 )


int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 10;
while (count <10000)
{   int what = new Random().Next(0,3);//0,1,2
    if (what == 0)
    {
        x=(x + xa)/2;
        y=(y + ya)/2;

    }
    if (what == 1)
    {
        x=(x + xb)/2;
        y=(y + yb)/2;
        
    }
    if (what == 2)
    {
        x=(x + xc)/2;
        y=(y + yc)/2;
        
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("=");
    count++;



}

