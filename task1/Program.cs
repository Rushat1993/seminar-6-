

Console.Write("Введите числа через пробел ");

int[] array = Console.ReadLine(). Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
        count++;
    }
}
Console.WriteLine("В массиве " + '[' + string.Join(", ", arr) + ']' + " количество положительных чисел = " + count);