Console.Write("Введите первое число: ");
String S1 = Console.ReadLine();
Console.Write("Введите второе число: ");
String S2 = Console.ReadLine();
int num1 = int.Parse(S1);
int num2 = int.Parse(S2);

if (num2 * num2 == num1)
{
    Console.Write("Первое число является квадратом второго");
}
else
{
    Console.Write("Первое число не является квадратом второго");
}
