// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;
int result = 1;
while (i <= n)
{
    result *= i;
    i++;
}

Console.WriteLine("Произведение чисел от 1 до N равно: " + result);
