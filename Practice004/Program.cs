Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

int i = -num;
while (i <= num)
{
    Console.Write(i + " ");
    i++;
}