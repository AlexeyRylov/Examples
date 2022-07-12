/*
Напишите программу, которая выводит слуайное число из отрезка [10, 100] и показывает наибольшую цифру числа
*/

int num = new Random().Next(10, 100);
Console.WriteLine("Random number: " + num);

int firstDigit = num / 10;
int secondDigit = num % 10;

Console.WriteLine("Result " + getMax(firstDigit, secondDigit));

int getMax(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}