Console.Clear();
Console.WriteLine("Введи количество символов в массиве");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(String.Join(" ", generateArray(num, 0, 2)));

int[] generateArray(int numberOfSymbols, int minValue, int maxValue)
{
    int[] binArray = new int[numberOfSymbols];
    for (int i = 0; i < numberOfSymbols; i++)
    {
        binArray[i] = getRandomNumber(minValue, maxValue);
    }
    return binArray;
}

int getRandomNumber(int minValue, int maxValue)
{
    int randomNumber = new Random().Next(minValue, maxValue);
    return randomNumber;
}