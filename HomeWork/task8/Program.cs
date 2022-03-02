// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите число: ");
int num = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите на кратность какого числа будем проверять: ");
int malt = Convert.ToInt16(Console.ReadLine());

if(num % malt == 0)
{
    Console.WriteLine("Число " + num + " кратно " + malt);
}
else
{
    Console.WriteLine("Число " + num + " некратно " + malt + ", остаток = " + num % malt);
}
