// Найти сумму чисел от 1 до А

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int i = 0;
while (i <= a)
{
    sum += i;
    i++;
}

Console.WriteLine("сумма чисел от 1 до " + a + " равна: " + sum);
