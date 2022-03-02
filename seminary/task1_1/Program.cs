// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Для проверки является ли первое число квадратом второго");
Console.Write("введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine("Да, первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго.");
}
