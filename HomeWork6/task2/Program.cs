// Задать двумерный массив следующим правилом: Aₘₙ = m+n


int[,] FillMassiv(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
            array[i, j] = i + j;
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

int m = 10, n = 10;
int[,] array = new int [m, n];
array = FillMassiv(array);
PrintArray(array);

