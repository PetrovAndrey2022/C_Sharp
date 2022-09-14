//Написать метод с использованеим цикла for который принимает на вход текст и какое кол-во раз надо его склеить


string method4 (string text, int count)
{
 
    string result = String.Empty; // задаем пустую строку
    for(int i=0; i<count; i++)
    {
        result = result+text;        
    }
    return result;
}

string res = method4(count:4, text:"Это новый текст ");
Console.WriteLine(res);