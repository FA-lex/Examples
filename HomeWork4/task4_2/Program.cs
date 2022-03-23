// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] fillMassiv(int[] array) //функция заполнения массива случайными числами
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 300);
    }
    return array;
}

void printArray(int[] array) // функция вывода массива в терминал
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int countSegmentNumInArray(int[] array, int start, int end) // функция подсчета количества чисел в заданном диапазоне
{
    int countSegmentNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > start && array[i] < end) countSegmentNum += 1;
    }
    return countSegmentNum;
}


// Задаем массив
int[] arr = new int[123]; //создаем
arr = fillMassiv(arr); //заполняем случайными числами

//выводим массив в терминал
printArray(arr);

//делаем подсчет количества элементов из отрезка [10,99] в массиве и выводим результат
int start = 10;
int end = 99;
Console.WriteLine();
Console.WriteLine("кол-во элементов из отрезка [10,99], содержащихся в массиве: " + countSegmentNumInArray(arr, start, end));
Console.WriteLine();
