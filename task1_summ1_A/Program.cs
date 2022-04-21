using System;

Console.Clear();
Console.WriteLine("Input A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} -> {Summa(A)}");

int Summa(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}