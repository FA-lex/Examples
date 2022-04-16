// Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

string FirstsNumbersSequensFollowingEqualSumTwoPrevious(int firstElement, int secondElement, int howManyElemets)
{
    int nextNumberSequens = firstElement + secondElement;
    string str = string.Empty;
    if (howManyElemets == 3)
    {
        str += $"{firstElement}, {secondElement}, {nextNumberSequens}";
        return str;
    }
    str = $"{firstElement}, " + FirstsNumbersSequensFollowingEqualSumTwoPrevious(secondElement, nextNumberSequens, howManyElemets - 1);
    return str;
    
}

Console.WriteLine(FirstsNumbersSequensFollowingEqualSumTwoPrevious(5, 7, 9));