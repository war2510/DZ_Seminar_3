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
            double[] realNumbers = { 3.14, 2.71, 1.618, 0.577, 4.669, 1.732, 2.718, 3.142, 1.414, 2.236 };

            // Находим максимальный и минимальный элементы массива
            double maxElement = realNumbers[0];
            double minElement = realNumbers[0];

            foreach (double num in realNumbers)
            {
                if (num > maxElement)
                {
                    maxElement = num;
                }
                if (num < minElement)
                {
                    minElement = num;
                }
            }

            // Вычисляем разницу между максимальным и минимальным элементами
            double difference = maxElement - minElement;

            Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
        }