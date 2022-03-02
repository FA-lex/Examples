// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите чисо: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    int thirdDigit = 0;
    while(num / 100 != 0)
    {
        thirdDigit = num % 10;
        num = num / 10;
    }
    Console.WriteLine("Третья цифра: " + thirdDigit);
}
