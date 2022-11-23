// See https://aka.ms/new-console-template for more information

int[] numbers = { 1, 3, 4, 5, 10, 7, 100, 12, 10, 20 };
int temporary = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (temporary <= numbers[i])
    {
        temporary = numbers[i];
    }
}
Console.WriteLine("Самое большое число в массиве: " + temporary);