/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
Console.Write("Введите число : ");
int a = int.Parse(Console.ReadLine());
Func(a);

void Func(int number)
{
    if ((number % 7 == 0) && (number % 23 == 0))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}


/*
if ((a % 7 == 0) && (a % 23 == 0)) //&& - если первое условие не выполнено, то второе и не проводится
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/
