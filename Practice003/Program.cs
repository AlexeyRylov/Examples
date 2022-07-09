Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n==1)
{
  Console.Write("понедельник");
} else if (n==2) {
    Console.Write("вторник");
} else if (n==3) {
    Console.Write("среда");
} else if (n==4) {
    Console.Write("четверг");
} else if (n==5) {
    Console.Write("пятница");
} else if (n==6) {
    Console.Write("суббота");
} else if (n==7) {
    Console.Write("воскресенье");
} else {
    Console.Write("дня с таким номером не существует");
}


