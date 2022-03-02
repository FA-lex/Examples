// Выяснить является ли число чётным

Console.Write("Введите число, а я скажу четное оно или нет:");
double num = Convert.ToDouble(Console.ReadLine());

if(num%2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
