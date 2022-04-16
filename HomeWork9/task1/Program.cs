// Найти сумму цифр числа

int SumDigitsNumber(int number)
{
    if (number / 10 == 0) return number;
    return number % 10 + SumDigitsNumber(number / 10);
}

int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(SumDigitsNumber(number));