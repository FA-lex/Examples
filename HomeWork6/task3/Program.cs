// Показать двумерный массив размером m×n заполненный целыми числами


int[,] FillMassiv(int[,] array, int start, int end) 
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


int m = 6, n = 7;
int[,] array = new int [m, n];
int[] rangeNumArray = {0, 10};
array = FillMassiv(array, rangeNumArray[0], rangeNumArray[1]);
PrintArray(array);
