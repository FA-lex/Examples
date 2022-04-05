// В двумерном массиве показать позиции числа, заданного пользователем
// или указать, что такого элемента нет


// ф-я заполнения двумерного массива случайными числами от start до end
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

// ф-я вывода двумерного массива на печать в консоль
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

// ф-я поиска кол-ва вхождений в массив  искомого эл-та
int countFindNumberInArray(int[,] array, int findNum)
{
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findNum) n++;
        }
    }
    return n;
}

// функция поиска позиции числа, заданного пользователем, в массиве
int[,] FindNumber(int[,] array, int findNum)
{
    int[,] positions = new int[countFindNumberInArray(array, findNum), 2];
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findNum) 
            {
                positions[n, 0] = i;
                positions[n, 1] = j;
                n++;
            }
        }
    }
    return positions;
}


int[,] array = new int[6, 7];
int[] rangeNumArray = { 0, 10 };
array = FillArray(array, rangeNumArray[0], rangeNumArray[1]);
PrintArray(array);

int findNumber = 5;

int[,] positions = FindNumber(array, findNumber);
PrintArray(positions);


