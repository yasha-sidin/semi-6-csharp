// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// Проверяем, существует ли треугольник с такими сторонами
void CheckTriangle(int first, int second, int third)
{
    if(first < second + third && second < first + third && third < second + first)
    {
        Console.WriteLine("Треуголник с такими сторонами существует");
    }
    else
    {
        Console.WriteLine("Треуголник с такими сторонами не существует");
    }
}

// -----------------------------------------------------------------------------------

Console.Write("Напишите длину первой стороны: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Напишите длину второй стороны: ");
int second = int.Parse(Console.ReadLine());

Console.Write("Напишите длину третьей стороны: ");
int third = int.Parse(Console.ReadLine());

CheckTriangle(first, second, third);

