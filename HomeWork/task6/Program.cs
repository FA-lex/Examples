// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int num = new Random().Next(10, 100);
Console.WriteLine("Выпавшее число от 10 до 99: " + num);

if(num / 10 > num % 10)
{
    Console.WriteLine("первая цифра больше.");
}
else if(num % 10 > num / 10)
{
    Console.WriteLine("вторая цифра больше.");
}
else
{
    Console.WriteLine("цифры одинаковые.");
}