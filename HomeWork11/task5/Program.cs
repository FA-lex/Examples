// Дано N целых чисел. Требуется выбрать из них максимальное число.

// Входные данные
// Вводится сначала число N - количество чисел в последовательности (1<=N<=100).
// Далее записана сама последовательность: N целых чисел, по модулю не превышающих 1000.

// Выходные данные
// Выведите искомое число.

int FindMaxNumber(int[] numbers)
{
    int maxNumber = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxNumber) maxNumber = numbers[i];
    }
    return maxNumber;
}


Console.Write("Input, how many sequence numbers: ");
int numberDigit = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[numberDigit];
Console.Write("Input, sequence numbers separated by a space: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int maximumNumber = FindMaxNumber(numbers);
Console.WriteLine(maximumNumber);
