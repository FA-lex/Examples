// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (number / 10 != 0)
{
    sum += number % 10;
    number = number / 10;
}
sum += number;

Console.WriteLine("Сумма цифр в числе равна: " + sum);