// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] FillArray(int[,] array, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(start, end);
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(String.Format("{0,4}", array[i, j]));
        Console.WriteLine();
    }
    Console.WriteLine();
}


// функция замены элементов, у которых оба индекса чётные на их квадраты
void ChangeElementsEvenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
        }
    }
}

int n = 6, k = 7;
int[,] array = new int[n, k];
int[] rangeNumArray = { 0, 10 };
array = FillArray(array, rangeNumArray[0], rangeNumArray[1]);
PrintArray(array);

ChangeElementsEvenIndex(array);
PrintArray(array);
