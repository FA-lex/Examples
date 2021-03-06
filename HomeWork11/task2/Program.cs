// Дано N целых чисел. Требуется выбрать из них два таких числа, произведение которых максимально.

// Входные данные
// Вводится сначала число N - количество чисел в последовательности (2<=N<=100).
// Далее записана сама последовательность: N целых чисел, по модулю не превышающих 1000.

// Выходные данные
// Выведите два искомых числа в любом порядке.
// Если существует несколько различных пар чисел, дающих максимальное произведение, то выведите любую из них.

(int, int) FindTwoNumbersMaxProduct(int[] array)
{
    int maxProduct= array[0] * array[1];
    (int, int) maxProductTwoNumbers = (array[0], array[1]);
    for (int i = 0; i < array.Length; i++)
        for (int j = i + 1; j < array.Length; j++)
            if (array[i] * array[j] > maxProduct)
            {
                maxProduct =array[i] * array[j];
                maxProductTwoNumbers = (array[i], array[j]);
            }
    return maxProductTwoNumbers;
}

Console.Write("Input, how many sequence numbers: ");
int numberDigit = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[numberDigit];
Console.Write("Input, sequence numbers separated by a space: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
(int, int) twoNumbersMaxProdact = FindTwoNumbersMaxProduct(numbers);
Console.WriteLine(twoNumbersMaxProdact);

