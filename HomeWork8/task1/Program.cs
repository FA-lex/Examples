/* Написать следующие функции работы с матрицами целых чисел:
1. Сумма элементов матрицы
2. Произведение элементов матрицы
3. Максимальный элемент матрицы
4. Минимальный элемент матрицы
5. Сумма элементов главной диагонали матрицы
6. Произведение элементов главной диагонали матрицы
7. Максимальный элемент, расположенный на главной диагонали матрицы
8. Минимальный элемент, расположенный на главной диагонали матрицы
9. Сумма элементов побочной диагонали матрицы
10. Произведение элементов побочной диагонали матрицы
11. Максимальный элемент, расположенный на побочной диагонали матрицы
12. Минимальный элемент, расположенный на побочной диагонали матрицы
13. Поиска минимального из максимальных элементов матрицы, то есть найти 
    максимальный элемент в каждой из строк матрицы и из них выбрать минимальный
14. Транспонирование для квадратной матрицы, то есть переворот матрицы относительно главной диагонали
    ( про это можно прочитать тут https://ru.wikipedia.org/wiki/%D0%A2%D1%80%D0%B0%D0%BD%D1%81%D0%BF%D0%BE%D0%BD%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%BD%D0%B0%D1%8F_%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86%D0%B0 )
15. Сумма двух матриц одинаковых размерностей.
16. Печать матрицы на экран
Все эти функции необходимо корректно вызвать внутри функции main и показать их корректную работу, 
то есть после ввода матрицы необходимо напечатать матрицу и ответы функций, после выполнения функций, 
печатающих матрицу на экран, необходимо печатать матрицу на экран.
*/


/// Функция заполнения матрицы 
int[,] FillMatrix(int[,] array, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(start, end);
    }
    return array;
}


// 16. Печать матрицы на экран

/// Функция вывода матрицы в консоль
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


// 1. Сумма элементов матрицы

/// Функция подсчета суммы элементов матрицы
int SumElementsMatrix(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
    return sum;
}


// 2. Произведение элементов матрицы

/// Функция подсчета произведения элементов матрицы
int ProductElementsMatrix(int[,] array)
{
    int product = 1;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            product *= array[i, j];
    return product;
}


// 3. Максимальный элемент матрицы

/// Функция поиска максимального числа в матрице
int FindMaximumElementMatrix(int[,] array)
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (max < array[i, j]) max = array[i, j];
    return max;
}


// 4. Минимальный элемент матрицы

/// Функция поиска минимального числа в матрице
int FindMinimumElementMatrix(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (min > array[i, j]) min = array[i, j];
    return min;
}


// 5. Сумма элементов главной диагонали матрицы

/// Функция подсчета суммы элементов главной диагонали матрицы
int SumElementsGeneralDiagonalMatrix(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        sum += array[i, i];
    return sum;
}


// 6. Произведение элементов главной диагонали матрицы

/// Функция подсчета произедения элементов главной диагонали матрицы
int ProductElementsGeneralDiagonalMatrix(int[,] array)
{
    int product = 1;
    for (int i = 0; i < array.GetLength(0); i++)
        product *= array[i, i];
    return product;
}


// 7. Максимальный элемент, расположенный на главной диагонали матрицы

/// Функция поиска максимального элемента на главной диагонали матрицы
int FindMaximumElementGeneralDiagonalMatrix(int[,] array)
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        if (max < array[i, i]) max = array[i, i];
    return max;
}


// 8. Минимальный элемент, расположенный на главной диагонали матрицы

/// Функция поиска минимального элемента на главной диагонали матрицы
int FindMinimumElementGeneralDiagonalMatrix(int[,] array)
{
    int min = array[0, 0];
    for (int i = 1; i < array.GetLength(0); i++)
        if (min > array[i, i]) min = array[i, i];
    return min;
}


// 9. Сумма элементов побочной диагонали матрицы

/// Функция подсчета суммы элементов побочной диагонали матрицы
int SumElementsSideDiagonalMatrix(int[,] array)
{
    int sum = 0;
    int j = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
        j--;
    }
    return sum;
}

// 10. Произведение элементов побочной диагонали матрицы

/// Функция подсчета произведения элементов побочной диагонали матрицы
int ProductElementsSideDiagonalMatrix(int[,] array)
{
    int product = 1;
    int j = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        product *= array[i, j];
        j--;
    }
    return product;
}

// 11. Максимальный элемент, расположенный на побочной диагонали матрицы

/// Функция поиска максимального элемента на главной диагонали матрицы
int FindMaximumElementSideDiagonalMatrix(int[,] array)
{
    int max = 0;
    int j = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (max < array[i, j]) max = array[i, j];
        j--;
    }
    return max;
}


// 12. Минимальный элемент, расположенный на побочной диагонали матрицы

/// Функция поиска минимального элемента на главной диагонали матрицы
int FindMinimumElementSideDiagonalMatrix(int[,] array)
{
    int j = array.GetLength(1) - 1;
    int min = array[0, j];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (min > array[i, j]) min = array[i, j];
        j--;
    }
    return min;
}


/// 13. Функция поиска минимального из максимальных элементов матрицы, то есть найти 
///     максимальный элемент в каждой из строк матрицы и из них выбрать минимальный
int FindMinimumFromMaximumElementMatrix(int[,] array)
{
    int max;
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        max = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
            if (max < array[i, j]) max = array[i, j];
        if (i == 0) min = max;
        if (max < min) min = max;
    }
    return min;
}


// 14. Транспонирование для квадратной матрицы, то есть переворот матрицы относительно главной диагонали

/// Функция транспортирования матрицы
int[,] TransporationMatrix(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) return array;
    int[,] newArray = new int[array.GetLength(0), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            newArray[j, i] = array[i, j];
    return newArray;
}


// 15. Сумма двух матриц одинаковых размерностей.

/// Функция суммирования двух матриц одинаковой размерности
int[,] SumTwoMatrix(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array1.GetLength(1); j++)
            newArray[i, j] = array1[i, j] + array2[i, j];
    return newArray;
}


int heigthMassiv = 3;
int widthMassiv = 3;

int[,] massiv1 = new int[heigthMassiv, widthMassiv];
int[,] massiv2 = new int[heigthMassiv, widthMassiv];

int startFillMatrix = 1;
int endFillMatrix = 11;

FillMatrix(massiv1, startFillMatrix, endFillMatrix);
FillMatrix(massiv2, startFillMatrix, endFillMatrix);

PrintMatrix(massiv1);
PrintMatrix(massiv2);

Console.WriteLine("Сумма элементов матрицы 1 равна: " + SumElementsMatrix(massiv1));
Console.WriteLine("Сумма элементов матрицы 2 равна: " + SumElementsMatrix(massiv2));

Console.WriteLine("Произведение элементов матрицы 1 равна: " + ProductElementsMatrix(massiv1));
Console.WriteLine("Произведение элементов матрицы 2 равна: " + ProductElementsMatrix(massiv2));

Console.WriteLine("Максимальный элемент матрицы 1 равен: " + FindMaximumElementMatrix(massiv1));
Console.WriteLine("Максимальный элемент матрицы 2 равен: " + FindMaximumElementMatrix(massiv2));

Console.WriteLine("Минимальный элемент матрицы 1 равен: " + FindMinimumElementMatrix(massiv1));
Console.WriteLine("Минимальный элемент матрицы 2 равен: " + FindMinimumElementMatrix(massiv2));

Console.WriteLine("Сумма элементов главной диагонали матрицы 1 равна: " + SumElementsGeneralDiagonalMatrix(massiv1));
Console.WriteLine("Сумма элементов главной диагонали матрицы 2 равна: " + SumElementsGeneralDiagonalMatrix(massiv2));

Console.WriteLine("Произведение элементов главной диагонали матрицы 1 равна: " + ProductElementsGeneralDiagonalMatrix(massiv1));
Console.WriteLine("Произведение элементов главной диагонали матрицы 2 равна: " + ProductElementsGeneralDiagonalMatrix(massiv2));

Console.WriteLine("Максимальный элемент главной диагонали матрицы 1 равен: " + FindMaximumElementGeneralDiagonalMatrix(massiv1));
Console.WriteLine("Максимальный элемент главной диагонали матрицы 2 равен: " + FindMaximumElementGeneralDiagonalMatrix(massiv2));

Console.WriteLine("Минимальный элемент главной диагонали матрицы 1 равен: " + FindMinimumElementGeneralDiagonalMatrix(massiv1));
Console.WriteLine("Минимальный элемент главной диагонали матрицы 2 равен: " + FindMinimumElementGeneralDiagonalMatrix(massiv2));

Console.WriteLine("Сумма элементов побочной диагонали матрицы 1 равна: " + SumElementsSideDiagonalMatrix(massiv1));
Console.WriteLine("Сумма элементов побочной диагонали матрицы 2 равна: " + SumElementsSideDiagonalMatrix(massiv2));

Console.WriteLine("Произведение элементов побочной диагонали матрицы 1 равна: " + ProductElementsSideDiagonalMatrix(massiv1));
Console.WriteLine("Произведение элементов побочной диагонали матрицы 2 равна: " + ProductElementsSideDiagonalMatrix(massiv2));

Console.WriteLine("Максимальный элемент побочной диагонали матрицы 1 равен: " + FindMaximumElementSideDiagonalMatrix(massiv1));
Console.WriteLine("Максимальный элемент побочной диагонали матрицы 2 равен: " + FindMaximumElementSideDiagonalMatrix(massiv2));

Console.WriteLine("Минимальный элемент побочной диагонали матрицы 1 равен: " + FindMinimumElementSideDiagonalMatrix(massiv1));
Console.WriteLine("Минимальный элемент побочной диагонали матрицы 2 равен: " + FindMinimumElementSideDiagonalMatrix(massiv2));

Console.WriteLine("Минимальный из максимальных элементов матрицы 1 равен: " + FindMinimumFromMaximumElementMatrix(massiv1));
Console.WriteLine("Минимальный из максимальных элементов матрицы 2 равен: " + FindMinimumFromMaximumElementMatrix(massiv2));

Console.WriteLine();
Console.WriteLine("Результат транспорирования матрицы 1: ");
PrintMatrix(TransporationMatrix(massiv1));
Console.WriteLine("Результат транспорирования матрицы 2: ");
PrintMatrix(TransporationMatrix(massiv2));

Console.WriteLine("Сумма двух матриц :");
PrintMatrix(SumTwoMatrix(massiv1, massiv2));
