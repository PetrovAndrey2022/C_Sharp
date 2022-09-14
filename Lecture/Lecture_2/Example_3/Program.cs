// ЗАДАЧА
// Имеем одномерный массив из n элементов,
// требуется найти элемент массива, равный find.

int[] array = {1,2,3,4,6,88,7,8,9,0,23,54,77,88};

int n = array.Length; // нахождение длинны массива

int find = 88;
int index = 0;

    while (index <= n)
    {
        if (array[index] == find)
        {
            Console.WriteLine(index); 
            break;           // прекращает выполнение цикла и выходит из него
        }
        index++;
    }



//Console.WriteLine(n);