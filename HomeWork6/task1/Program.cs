// Показать двумерный массив размером m×n заполненный вещественными числами


double[,] FillArray(double[,] array, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.NextDouble() + rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = 5, n = 4;
double[,] array = new double[m, n];
int[] rangeNumArray = { 0, 10 };
array = FillArray(array, rangeNumArray[0], rangeNumArray[1]);
PrintArray(array);

