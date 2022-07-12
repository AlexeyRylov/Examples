/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Func(a, b);
bool boolValue = IsSqr(a, b);
Console.WriteLine(boolValue);

void Func(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
    {
        Console.WriteLine("да");
    } else
    {
        Console.WriteLine("нет");
    }
}

bool IsSqr(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
    {
        return true;
    } else
    {
        return false;
    }
}