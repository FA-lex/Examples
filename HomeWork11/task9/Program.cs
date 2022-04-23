// На волшебном острове Геральдионе, на котором живёт Геральд, есть своя денежная система.
// В обращении находятся купюры нескольких номиналов.
// Но, к сожалению, их система несовершенна,
// и иногда Геральдионцы сталкиваются с ситуацией,
// что определённую сумму денег нельзя выдать без сдачи никаким набором купюр
// (естественно, можно использовать сколько угодно купюр каждого достоинства).
// Такая сумма называется неудачной.
// Геральд заинтересовался: а какова минимальная неудачная сумма?

// Входные данные
// В первой строке дано число n (1≤n≤1000) — количество номиналов купюр, которые имеют хождение на Геральдионе.
// Во второй строке через пробел перечислены n различных чисел a1, a2, ..., an (1 ≤ ai ≤ 106) — сами номиналы купюр.

// Выходные данные
// Выведите единственное число — минимальную неудачную сумму. Если же неудачных сумм не бывает, выведите  - 1.

int FindMinFailSum(int[] banknotes)
{
    int minFailSum = 1;
    for (int i = 0; i < banknotes.Length; i++)
    {
        if  (banknotes[i] == 1) minFailSum = -1;
    }
    return minFailSum;
}


Console.Write("Input, how many nominations banknotes: ");
int nomberNominationsBanknotes = int.Parse(Console.ReadLine() ?? "0");
int[] banknotes = new int[nomberNominationsBanknotes];
Console.Write("Input, nominations banknotes separated by a space: "); banknotes = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int minFailSum = FindMinFailSum(banknotes);
Console.WriteLine(minFailSum);
