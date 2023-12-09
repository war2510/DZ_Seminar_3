// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
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


// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве. 
  int[] numbers = new int[10]; // Создаем массив на 10 элементов
         {
             int evenCount = 0; // Счетчик четных чисел

             // Заполняем массив случайными числами
             Random random = new Random();
             for (int i = 0; i < numbers.Length; i++)
             {
                 numbers[i] = random.Next(1, 101); // Генерируем случайное число от 1 до 100
             }

             // Подсчитываем количество четных чисел
             foreach (int num in numbers)
             {
                 if (num % 2 == 0)
                 {
                     evenCount++;
                 }
             }

             // Выводим результат
             Console.WriteLine($"В массиве {evenCount} чётных чисел.");
         }

//  Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.\
  {
    Console.Write("Введите размер массива: ");
      int num = Convert.ToInt32(Console.ReadLine());
      double[] array3 = new double[num];

array3[0] = new Random().NextDouble() * 100;
double min = array3[0];
double max = array3[0];

for (int i = 1; i < array3.Length; i++)
{
    array3[i] = new Random().NextDouble() * 100;
    if (array3[i] < min)
        min = array3[i];

    if (array3[i] > max)
        max = array3[i];
}

        Console.WriteLine($"Разница между максимальным и минимальным элементами: {max - min}");
         }

//  Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.        
        
         {
             Console.Write("Введите натуральное число: ");
             int number = int.Parse(Console.ReadLine());

             // Определяем количество цифр в числе
             int digitCount = (int)Math.Log10(number) + 1;

             // Создаем массив для хранения цифр
             int[] digits = new int[digitCount];

             // Заполняем массив цифрами числа
             for (int i = digitCount - 1; i >= 0; i--)
             {
                 digits[i] = number % 10;
                 number /= 10;
             }

             // Выводим массив цифр
             Console.WriteLine("Массив цифр числа:");
             foreach (int digit in digits)
             {
                 Console.Write(digit + " ");
             }
         }