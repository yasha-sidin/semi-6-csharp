// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Вывод чисел фибоначчи
void GetFibonacci(int ElementsFibCount)
{
    double[] arrayFib = new double[ElementsFibCount];
    arrayFib[0] = 0;
    arrayFib[1] = 1;
    for(int i = 2; i < arrayFib.Length; i++)
    {
        arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
    }
    for(int j = 0; j < arrayFib.Length; j++)
    {
        Console.WriteLine($"N({j + 1}) = {arrayFib[j]}");
    }
}

// -----------------------------------------------------------------------------------

GetFibonacci(100);