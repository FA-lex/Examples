// Определить, присутствует ли в заданном массиве, некоторое число

bool nums(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] arr = new int[10];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 11);
}

printArray(arr);

if (nums(arr, 3))
{
    Console.WriteLine("Число 3 есть в этом масиве!");
}
else
{
    Console.WriteLine("Числа 3 нет в этом массиве!");
}

if (nums(arr, 5))
{
    Console.WriteLine("Число 5 есть в этом масиве!");
}
else
{
    Console.WriteLine("Числа 5 нет в этом массиве!");
}