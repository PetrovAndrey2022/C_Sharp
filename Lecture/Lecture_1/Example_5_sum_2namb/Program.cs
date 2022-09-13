//генератор случайных чисет, даст значение от 1 до 10-1
int numberA = new Random().Next(1,10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
Console.Write(" result (numberA + numberB)= ");
int result = numberA + numberB;
Console.WriteLine(result);

