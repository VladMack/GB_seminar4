using System;

Console.Clear();
Console.WriteLine("Input A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} -> {factorial(A)}");

int factorial(int number)
{
    int f = 1;
    for (int i = 1; i <= number; i++)
    {
        f *= i;
    }
    return f;
}