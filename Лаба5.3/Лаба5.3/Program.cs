using System;

class ArrayProcessing
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        // Заполнение массива с клавиатуры
        FillArray(array);

        // Вывод массива
        Console.WriteLine("Массив:");
        PrintArray(array);

        // Обработка данных массива
        Console.WriteLine($"Сумма всех элементов: {CalculateSum(array)}");
        Console.WriteLine($"Среднее значение: {CalculateAverage(array)}");
        Console.WriteLine($"Сумма отрицательных элементов: {CalculateNegativeSum(array)}");
        Console.WriteLine($"Сумма положительных элементов: {CalculatePositiveSum(array)}");
        Console.WriteLine($"Сумма элементов с нечетными номерами: {CalculateSumOddIndexes(array)}");
        Console.WriteLine($"Сумма элементов с четными номерами: {CalculateSumEvenIndexes(array)}");

        int maxIndex, minIndex;
        FindMaxMinIndexes(array, out maxIndex, out minIndex);
        Console.WriteLine($"Максимальный элемент: {array[maxIndex]} (индекс {maxIndex})");
        Console.WriteLine($"Минимальный элемент: {array[minIndex]} (индекс {minIndex})");

        Console.WriteLine($"Произведение элементов между максимальным и минимальным: {CalculateProductBetweenMaxMin(array, maxIndex, minIndex)}");
    }

    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (var element in array)
        {
            sum += element;
        }
        return sum;
    }

    static double CalculateAverage(int[] array)
    {
        return (double)CalculateSum(array) / array.Length;
    }

    static int CalculateNegativeSum(int[] array)
    {
        int sum = 0;
        foreach (var element in array)
        {
            if (element < 0)
                sum += element;
        }
        return sum;
    }

    static int CalculatePositiveSum(int[] array)
    {
        int sum = 0;
        foreach (var element in array)
        {
            if (element > 0)
                sum += element;
        }
        return sum;
    }

    static int CalculateSumOddIndexes(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }

    static int CalculateSumEvenIndexes(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }

    static void FindMaxMinIndexes(int[] array, out int maxIndex, out int minIndex)
    {
        maxIndex = minIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }

            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
    }

    static int CalculateProductBetweenMaxMin(int[] array, int maxIndex, int minIndex)
    {
        int start = Math.Min(maxIndex, minIndex) + 1;
        int end = Math.Max(maxIndex, minIndex);

        int product = 1;
        for (int i = start; i < end; i++)
        {
            product *= array[i];
        }
        return product;
    }
}
