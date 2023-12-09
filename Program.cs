//  Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    if (array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }
}
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("This text is red!");
Console.WriteLine($"Массив: [{string.Join(" ", array)}] => {count}");

