// Вводится последовательность чисел. Посчитать в ней количество чётных чисел, стоящих на чётных местах.

// Входные данные
// Вводится сначала число N, а затем N чисел - члены последовательности.

int FindEvenNumbersEvenPlace(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
        if (array[i] % 2 == 0) count++;
    return count;
}

Console.Write("Input, how many sequence numbers: ");
int numberDigit = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[numberDigit];
Console.Write("Input, sequence numbers separated by a space: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int evenNumbersEvenPlace = FindEvenNumbersEvenPlace(numbers);
Console.WriteLine(evenNumbersEvenPlace);