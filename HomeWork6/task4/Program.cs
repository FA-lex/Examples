// В двумерном массиве n×k заменить четные элементы на противоположные

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

void ChangeEvenElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 ==0) array[i, j] *= -1;
        }
    }
}

int n = 6, k = 7;
int[,] array = new int [n, k];
int[] rangeNumArray = {0, 10};
array = FillArray(array, rangeNumArray[0], rangeNumArray[1]);
PrintArray(array);
ChangeEvenElements(array);
PrintArray(array);
