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

        