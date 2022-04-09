// Найти произведение двух матриц

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


int[,] ProductOfMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] productMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return productMatrix;
}


int[,] array = new int[3, 5];
int[,] array2 = new int[5, 1];
int[] rangeNumArray = { 0, 10 };
array = FillMassiv(array, rangeNumArray[0], rangeNumArray[1]);
array2 = FillMassiv(array2, rangeNumArray[0], rangeNumArray[1]);
PrintArray(array);
PrintArray(array2);


if (array.GetLength(1) == array2.GetLength(0)) // проверка на возможность перемножения матриц
{
    int[,] matrixMultiplication;
    matrixMultiplication = ProductOfMatrix(array, array2);
    PrintArray(matrixMultiplication);
}
else
{
    Console.WriteLine("Количество столбцов первой матрици должно быть равно количеству строк второй.");
}
