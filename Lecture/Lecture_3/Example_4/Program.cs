// Ьетод который что-то приимает и что-то возвращает

string method4(int count, string msg)
{
    int i=0;
    string result = String.Empty;// задаем начельное значение - пустая строка

    while (i<count)
    {
        result = result+msg;
        i++;
    }
    return result;
}

string res = method4(4,"_Текст_");
Console.WriteLine(res);
