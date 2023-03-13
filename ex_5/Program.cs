// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

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

int[] GetCopyIntArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < copyArray.Length; i++)
    {
        copyArray[i] = array[i];
    }

    return copyArray;
}

int[] firstArray = GetFillRandomIntArray(10, 0, 100);

int[] copyArray = GetCopyIntArray(firstArray);

PrintIntArray(firstArray);
copyArray[0] = 10000;
Console.WriteLine();
PrintIntArray(copyArray);
PrintIntArray(firstArray);