// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
double firstNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double secondNum = Convert.ToDouble(Console.ReadLine());

if (secondNum * secondNum == firstNum)
{
    Console.WriteLine("Первое число является квадратом второго. ");
}
else if(firstNum * firstNum == secondNum)
{
    Console.WriteLine("Второе число является квадратом первого. ");
}
else {Console.WriteLine("Ни одно из чисел не является квадратом другого. ");}
