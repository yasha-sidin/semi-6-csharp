// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Преобразуем десятичное число в двоичное
string GetBinariNum(int num)
{
    int tempNum = num;
    string result = "";

    while (tempNum > 0)
    {
        int remainder = tempNum % 2;
        result = Convert.ToString(remainder) + result;
        tempNum /= 2;
    }

    return result;
}

// -----------------------------------------------------------------------------------

Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} в двоичной системе = {GetBinariNum(number)}");