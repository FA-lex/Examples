// Написать программу вычисления функции Аккермана

int FunctionAccerman(int m, int n)
{
    if (m < 0 || n < 0) return -1;
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunctionAccerman(m - 1, 1);
    if (n > 0 && m > 0) return FunctionAccerman(m - 1, FunctionAccerman(m, n - 1));
    return FunctionAccerman(m, n);
}

int[,] FillMassivAccerman(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
        for (int n = 0; n < array.GetLength(1); n++)
            array[m, n] = FunctionAccerman(m, n);

    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(String.Format("{0,4}", array[i, j]));
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] arrayAccerman = new int[4, 4];
FillMassivAccerman(arrayAccerman);
PrintMatrix(arrayAccerman);

