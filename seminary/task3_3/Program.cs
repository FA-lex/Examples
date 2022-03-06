// Определить количество цифр в числе

Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("В числе, которое Вы ввели (" + num + ") ");
int i = 0;
while (num != 0)
{
    num = num / 10;
    i++; 
}
Console.WriteLine(i + " цифр.");
