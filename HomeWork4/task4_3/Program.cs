// Найти сумму чисел одномерного массива стоящих на нечетной позиции


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

// функция подсчета суммы чисел стоящих на нечетной позиции в массиве
int sumNumOddIndexInArray(int[] array) 
{
    int sumNum = 0;
    for (int i = 0; i < array.Length; i +=2)
    {
        sumNum += array[i];
    }
    return sumNum;
}


// Задаем массив
int[] arr = new int[10];
arr = fillMassiv(arr);

//выводим массив в терминал
printArray(arr);

//делаем подсчет суммы элементов массива, стоящих на нечетной позиции и выводим результат

Console.WriteLine();
Console.WriteLine("сумма элементов массива, стоящих на нечетной позиции: " + sumNumOddIndexInArray(arr));
Console.WriteLine();

