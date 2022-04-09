// Написать программу,
// которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).


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

void ChangeRowColumnMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
        PrintArray(matrix);
    }
    else Console.WriteLine("Матрица не квадратная, поменять строки со столдцами нельзя.");
}


int[,] array = new int[6, 5];
int[] rangeNumArray = { 0, 10 };
array = FillArray(array, rangeNumArray[0], rangeNumArray[1]);
PrintArray(array);

ChangeRowColumnMatrix(array);
