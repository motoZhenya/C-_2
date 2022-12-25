// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число номера дня недели ");
int day = int.Parse(Console.ReadLine()!);

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(day == a)
{
    Console.WriteLine ("понедельник");
    Console.WriteLine ("Будний день, уфъ");
}
if(day == b)
{
    Console.WriteLine ("вторник");
    Console.WriteLine ("Будний день, уфъ!");
}
if(day == c)
{
    Console.WriteLine ("среда");
    Console.WriteLine ("Будний день, уфъ");
}
if(day == d)
{
    Console.WriteLine ("четверг");
    Console.WriteLine ("Будний день, уфъ");
}
if(day == e)
{
    Console.WriteLine ("пятница");
    Console.WriteLine ("Будний день, еще чуть чуть");
}
if(day == f)
{
    Console.WriteLine ("суббота");
    Console.WriteLine ("Сегодня выходной!");
}
if(day == g)
{
    Console.WriteLine ("воскресение");
    Console.WriteLine ("Сегодня выходной!");
}