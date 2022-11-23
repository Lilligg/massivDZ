// See https://aka.ms/new-console-template for more information

int[] numbers = { 1, 6, 8, -7, 5, 21, 100, 1064, 1124, -348 };
int temp;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
Console.WriteLine("Максимальное число массива: " + numbers[numbers.Length - 1]);