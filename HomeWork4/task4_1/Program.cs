// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел


int[] fillMassiv(int[] array) //функция заполнения массива случайными положительными трёхзначными числами
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void printArray(int[] array) // функция вывода массива в терминал
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int countOddNumInArray(int[] array) // функция подсчета количества нечетных чисел
{
    int countOddNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1) countOddNum += 1;
    }
    return countOddNum;
}

int countEvenNumInArray(int[] array) // функция подсчета количества четных чисел
{
    int countEvenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countEvenNum += 1;
    }
    return countEvenNum;
}

// Задаем массив
int[] arr = new int[10]; //создаем
arr = fillMassiv(arr); //заполняем случайными числами

int[] arr2 = new int[15];
arr2 = fillMassiv(arr2);

int[] arr3 = new int[5];
arr3 = fillMassiv(arr3);

//выводим массив в терминал

printArray(arr);
printArray(arr2);
printArray(arr3);

//делаем подсчет количества четных\нечетных элементов и выводим результат

Console.WriteLine();
Console.WriteLine("кол-во нечетных элементов первого массива: " + countOddNumInArray(arr));
Console.WriteLine("кол-во четных элементов первого массива: " + countEvenNumInArray(arr));
Console.WriteLine();
Console.WriteLine("кол-во нечетных элементов второго массива: " + countOddNumInArray(arr2));
Console.WriteLine("кол-во четных элементов второго массива: " + countEvenNumInArray(arr2));
Console.WriteLine();
Console.WriteLine("кол-во нечетных элементов третьего массива: " + countOddNumInArray(arr3));
Console.WriteLine("кол-во четных элементов третьего массива: " + countEvenNumInArray(arr3));
Console.WriteLine();
