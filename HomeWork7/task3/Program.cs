// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента


int[] generationListUnicumTwoDigitNumbers()
{
    Random rnd = new Random();
    int[] list = new int[80];
    list[0] = rnd.Next(10, 100);
    
    int j;
    for (int i = 1; i < list.Length;)
    {
        int num = rnd.Next(10, 100);
        for (j = 0; j < i; j++)
        {
            if (num == list[j]) break;

        }
        if (j == i)
        {
            list[i] = num;
            i++;
        }
    }
    return list;
}


int[,,] FillMassiv3D(int[,,] array, int start, int end)
{
    int[] unicumTwoDigitNumbes = generationListUnicumTwoDigitNumbers();
    int usedNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = unicumTwoDigitNumbes[usedNumber];
                usedNumber++;
            }
        }
    }
    return array;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"({i}, {j}, {k}) = " + String.Format("{0,4}", array[i, j, k]));
                Console.WriteLine();
            }
        }
    }
}


int[,,] array = new int[4, 4, 5];
int[] rangeNumArray = { 10, 100 };
array = FillMassiv3D(array, rangeNumArray[0], rangeNumArray[1]);
PrintArray3D(array);

