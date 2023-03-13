// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Переворачиваем массив
int[] ReverseArrayInt(int[] array)
{
    int fix = 0;
    int length = array.Length - 1;
    for(int i = 0; i < array.Length / 2; i++)
    {
        fix = array[i];
        array[i] = array[length];
        array[length] = fix;
        length--;
    }

    return array;
}

// -----------------------------------------------------------------------------------

// Создаем и заполняем массив числами
int[] GetFillRandomIntArray(int arraySize, int startRange, int endRange)
{
    int[] array = new int[arraySize];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startRange, endRange + 1);
    }
    return array;
}

// -----------------------------------------------------------------------------------

// Напечатать массив
void PrintIntArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}]");
            break;
        }
        Console.Write($"{array[i]}, ");
    }
}

// -----------------------------------------------------------------------------------

// Находим сумму нечетных позиций в массиве
int GetSumOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }

    return sum;
}

// -----------------------------------------------------------------------------------

int[] arrayInt = GetFillRandomIntArray(14, 0, 100);
PrintIntArray(arrayInt);

ReverseArrayInt(arrayInt);
PrintIntArray(arrayInt);

// Можно решить добавлением дополнительного массива
