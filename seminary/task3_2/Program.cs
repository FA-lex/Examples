// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число для возведения в степень: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите в какую степень возвдить: ");
int b = int.Parse(Console.ReadLine());

int c = 1;
int count =1;
while (count <= b)
{
    c = c * a;
    count++;
}

Console.WriteLine(a + " в степени " + b + " равно " + c);
