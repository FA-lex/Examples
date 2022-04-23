// Задана последовательность из N чисел, необходимо посчитать сумму элементов этой последовательности

// Входные данные
// В первой строке входного потока задано число N,
// не превышающее 1000, - количество элементов этой последовательности,
// во второй строке заданы N чисел, не превышающих 10000

// Выходные данные
// На выход необходимо вывести одно число - сумму элементов последовательности.


int SumNumbers(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++) sum += numbers[i];
    return sum;
}


Console.Write("Input, how many sequence numbers: ");
int numberDigit = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[numberDigit];
Console.Write("Input, sequence numbers separated by a space: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int sumNumbers = SumNumbers(numbers);
Console.WriteLine(sumNumbers);
