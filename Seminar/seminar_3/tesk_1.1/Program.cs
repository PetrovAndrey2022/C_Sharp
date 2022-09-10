/* 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой 
находится эта точка. */


int CheckChetvert(int x, int y)
            {    
            int res;
            if (x>0 && y>0) res=1;
            else if (x>0 && y<0) res=4;
            else if (x<0 && y<0) res=3;
            else if (x<0 && y>0) res=2;
            else res = 0;
            return res;
            }
        
        try 
            {
            Console.Write ("Введите координату х ");
            int x = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("Введите координату y ");
            int y = Convert.ToInt32 (Console.ReadLine());
            int rez = CheckChetvert(x,y);
            if (rez!=0)  Console.WriteLine($"Точка находится в четверти №  {rez}");
            else Console.WriteLine("Точка находится лежит на какой-то оси");
            }
        catch
            {
                Console.WriteLine("Надо было вводить именно целые числа");
            }
