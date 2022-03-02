// Найти максимальное из трех чисел

Console.WriteLine("Для проверки на максимальноечисло введите три числа через 'энтер'");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double num3 = Convert.ToDouble(Console.ReadLine());

double max = num1;
if(num2 > max)
{
    max = num2;
}

if(num3 > max)
{
    max = num3;
}

Console.WriteLine("максимальное число: " + max);
