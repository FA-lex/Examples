// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;
while(i <= n)
{
    Console.Write(i * i * i + "; ");
    i++ ;
}

Console.WriteLine(" ");
