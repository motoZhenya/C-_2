﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a%10;
if (a > 99)
{
    Console.Write("Третье число: ");
    Console.WriteLine(b);
}
if (a < 99)
{
        Console.WriteLine("Третьего числа нет ");
        
}