// Скрудж МакДак держит свои самые сокровенные сбережения в сейфе,
//  защищенном кодовым замком. Каждый раз, когда он кладет туда новые честно заработанные драгоценности,
//   он вынужден открывать замок.


// Кодовый замок представляет собой n вращающихся дисков с написанными на них цифрами от 0 до 9.
//  Скрудж МакДак должен повернуть некоторые из дисков так,
//   чтобы последовательность цифр на дисках образовала секретную комбинацию.
//    За одно действие он может прокрутить один из дисков на одну цифру вперед или назад.
//     В частности, за одно действие можно перейти от цифры 0 к цифре 9 и наоборот.
//      Какое минимальное количество действий ему для этого потребуется?

int FindMinNumberAction(int disks, int[] startPosition, int[] openCombination)
{
    int minNumberAction = 0;
    for (int i = 0; i < startPosition.Length; i++)
    {
        int steps = 0;
        if (startPosition[i] > openCombination[i]) steps = startPosition[i] - openCombination[i];
        else steps = openCombination[i] - startPosition[i];
        if (steps > 5) steps = 10 - steps;
        minNumberAction += steps;
    }
    return minNumberAction;
}


Console.Write("enter, how many disk on the Safe: ");
int disks = int.Parse(Console.ReadLine() ?? "0");


Console.Write("ente, start position : ");
int[] startPosition = Console.ReadLine().Select(e => Convert.ToInt32(new string(e, 1))).ToArray();


Console.Write("enter, open combination : ");
int[] openCombination = Console.ReadLine().Select(e => Convert.ToInt32(new string(e, 1))).ToArray();

int minNumberAction = FindMinNumberAction(disks, startPosition, openCombination);

Console.WriteLine($"Minimum number of actions: {minNumberAction}");
