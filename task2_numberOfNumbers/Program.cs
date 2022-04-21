using System;

Console.Clear();
Console.WriteLine("Input A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} -> {numNum(Math.Abs(A))}");

int numNum(int number)
{
    int counter = 0;
    while ((number) > 0)
    {
        counter++;
        number /= 10;
    }
    return counter;
}