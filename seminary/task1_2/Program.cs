// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Для проверки большего и меньшего числа");
Console.Write("введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine("Большее из этих чисел: " + number1 + ". Меньшее из этих чисел " + number2);
}
else
{
    Console.WriteLine("Большее из этих чисел: " + number2 + ". Меньшее из этих чисел " + number1);
}