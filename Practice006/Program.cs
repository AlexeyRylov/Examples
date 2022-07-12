/*
Напишите программу, которая выводит трехзначное целое число и удаляет вторую цифру этого числа
*/

int a = new Random().Next(100, 1000);

int digitFirst = a / 100;
int digitThird = a % 10;

Console.WriteLine("случайное число: " + a);
Console.WriteLine(digitFirst*10 + digitThird);