// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void printArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
}

double findMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double findMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}


double[] array = new double[10];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.NextDouble() + rnd.Next(-100, 100);
}

printArray(array);
Console.WriteLine("\nРазница между max и min равна  " + (findMax(array) - findMin(array)));
