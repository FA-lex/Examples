//  Дана последовательность чисел. Найти в ней наименьшее число.

// Входные данные
// Сначала задано число N - количество чисел в последовательности, а затем N чисел (1 <  = N <  = 100).

// Выходные данные
// Выведите наименьшее число.

int FindMinNumber(int[] numbers)
{
    int minNumber = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < minNumber) minNumber = numbers[i];
    }
    return minNumber;
}


Console.Write("Input, how many sequence numbers: ");
int numberDigit = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[numberDigit];
Console.Write("Input, sequence numbers separated by a space: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int minimumNumber = FindMinNumber(numbers);
Console.WriteLine(minimumNumber);
