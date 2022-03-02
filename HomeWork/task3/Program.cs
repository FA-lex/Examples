// Выяснить является ли число чётным

Console.WriteLine("Введите число для проверки на четность: ");
int num = Convert.ToInt16(Console.ReadLine());

if(num%2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}