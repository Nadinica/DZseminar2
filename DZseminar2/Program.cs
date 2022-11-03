// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int x = 456;
int a;
int b;
a = x / 10;
b = a % 10;

Console.Write("456 -> ");
Console.WriteLine(b);

NewMethod();

static void NewMethod()
{
    int x1 = 782;
    int a1;
    int b1;
    a1 = x1 / 10;
    b1 = a1 % 10;

    Console.Write("782 -> ");
    Console.WriteLine(b1);
}

NewMethod1();

static void NewMethod1()
{
    int x2 = 918;
    int a2;
    int b2;
    a2 = x2 / 10;
    b2 = a2 % 10;

    Console.Write("918 -> ");
    Console.WriteLine(b2);
}

