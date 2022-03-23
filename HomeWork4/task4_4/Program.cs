// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.


//функция заполнения массива случайными числами
int[] fillMassiv(int[] array) 
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}

// функция вывода массива в терминал
void printArray(int[] array) 
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// функция подсчета произведения пар чисел
int[] compositionTwoIndexInArray(int[] array) 
{
    int[] composTwoIndex = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i ++)
    {
        composTwoIndex[i] = array[i] * array[array.Length - 1 - i];
    }
    return composTwoIndex;
}


// Задаем массив
int[] arr = new int[11];
arr = fillMassiv(arr);

//выводим массив в терминал
printArray(arr);

//делаем подсчет произведения пар чисел и выводим результат

Console.WriteLine();
Console.Write("произведения пар чисел массива: ");
printArray(compositionTwoIndexInArray(arr));
Console.WriteLine();

