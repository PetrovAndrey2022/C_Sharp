// Дан текст. В тексте нужно все пробелы заменить черточками.

// метод принимающий на вход строку и возвращает ее с изменениями.




internal partial class Program
{
    private static void Main(string[] args)
    {
        
        //  Исходный текст
        string text = "Я думал очень много"
                     + "А может быть и нет";
            
        string Replace(string text, char oldValue, char newValue) 
        {
            string result = String.Empty; // заводим пустую строку и иниализируем ее
            int length = text.Length;// определяем длинну текста
                for (int i=0;  i<length; i++)
                {
                    if (text[i]==oldValue) // если текущий символ совпадает с тем, на который надо изменить, меняем местами
                        result = result+$"{newValue}";
                    else
                        result = result+$"{text[i]}";// если не совпадеет то ложим старый элемент

                }
                return result;
        }

        Console.Clear();
        string NewText = Replace(text, " ", "9");
        Console.WriteLine(NewText);


            
            
     }
}