// task2_1: Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Введите число для проверки на кратность 7-и и 23-м: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number %23 == 0)
{
    Console.WriteLine("Число введено Вами (" + number + ") кратно 7 и 23");
}
else if(number % 7 == 0)
{
    Console.WriteLine("Число введено Вами (" + number + ") кратно только 7");
}
else if(number % 23 == 0)
{
    Console.WriteLine("Число введено Вами (" + number + ") кратно только 23");
}
else
{
    Console.WriteLine("Число введено Вами (" + number + ") некратно ни 7 ни 23");
}
