Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();


if (username.ToLower() == "маша") // ToLower - переводит символы в строке в нижний регистр
{
    Console.WriteLine("Ура, это же Маша!");
}
else {
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
}