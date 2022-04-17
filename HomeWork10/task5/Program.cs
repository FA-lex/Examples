// Солдат хочет купить w бананов в магазине.
//  Ему надо заплатить k долларов за первый банан,
//   2k долларов — за второй и так далее (иными словами, за i-й банан надо заплатить i·k долларов).

// У него есть n долларов. Сколько долларов ему придется одолжить у однополчанина, чтобы купить w бананов?

int HowNeedBorrow(int k, int n, int w)
{
    int sum = 0;
    for (int i = 1; i<=w;i++)
    {
        sum += i*k;
    }
    if(sum>n) return sum-n;
    return 0;
}

Console.Write("ente, price banana : ");
int k = int.Parse(Console.ReadLine() ?? "0");

Console.Write("ente, how much cash does a soldier have : ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.Write("ente, how many bananas does a soldier want to buy : ");
int w = int.Parse(Console.ReadLine() ?? "0");

int howNeed = HowNeedBorrow(k, n, w);
Console.WriteLine($"The soldier will have to take {howNeed}");
