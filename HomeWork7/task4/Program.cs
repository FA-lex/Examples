// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

void PrintArray(int[,] array)
{
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) continue;
            Console.Write(String.Format("{0,6}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArrayTriangle(int[,] array)
{
    int centerWidth = Console.WindowWidth / 2;
    string printString = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) continue;
            printString += String.Format("{0,6}", array[i, j]);
            
        }
        Console.SetCursorPosition((centerWidth - printString.Length / 2), Console.CursorTop + 1);
        Console.Write(printString);
        //Console.WriteLine();
        printString = string.Empty;
    }
    Console.WriteLine();
}

void PascalTriangle(int depth)
{
    int[,] pascalTriangle = new int[depth, depth];
    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || i == j) pascalTriangle[i, j] = 1;
            else pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
        }
    }
    PrintArray(pascalTriangle);
    PrintArrayTriangle(pascalTriangle);
}


int depthPascalTriangle = 15;
PascalTriangle(depthPascalTriangle);
