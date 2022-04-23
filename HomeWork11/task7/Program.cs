// Задана последовательность из N чисел и задано еще одно число,
// необходимо найти позицию этого числа в последовательности
// или выдать, что такого числа нет

// Входные данные
// на вход подается в первой строке число N - количество чисел в последовательности,
// в следующей строке написано N чисел - сама последовательность,
// а в последней строке входного файла написано число, которое нужно найти в последовательности

// Выходные данные
// в выходной поток необходимо выдать, номер этого числа в последовательности
// или -1 если заданного числа в последовательности нет.


int FindNumber(int[] numbers, int numberFind)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == numberFind) return i+1;
    }
    return -1;
}


Console.Write("Input, how many sequence numbers: ");
int numberDigit = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[numberDigit];
Console.Write("Input, sequence numbers separated by a space: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
Console.Write("Input, what number to find: ");
int numberFind = int.Parse(Console.ReadLine() ?? "0");
int NumberOfNumber = FindNumber(numbers, numberFind);
Console.WriteLine(NumberOfNumber);
