// Показать числа Фибоначчи

void numbersFibonachi(int N) //метод вывода чисел Фибоначи до N
{
    int n1 = 0;
    int n2 = 1;
    Console.Write($"{n1} ");
    while (n2 < N)
    {
        int n = n1 + n2;
        n1 = n2;
        Console.Write($"{n2} ");
        n2 = n;
        
    }
    Console.WriteLine();
}


// Запрашиваем N
Console.Write("До какого числа вывести числа Фибонначи? ");
int N = int.Parse(Console.ReadLine() ?? "");

// передаем N в функцию вывода
numbersFibonachi(N);
