// Написать программу замену элементов массива на противоположные 

void changeElement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}


void printElement(int [] array)
{
    for (int i = 0;  i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int [] numbers = new int [10];

Random rd = new Random();
for (int i = 0;  i < numbers.Length; i++)
{
    numbers[i] = rd.Next(-10, 11);
}

printElement(numbers);
Console.WriteLine();

changeElement(numbers);
printElement(numbers);

Console.WriteLine();
