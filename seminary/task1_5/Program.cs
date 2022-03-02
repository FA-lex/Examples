// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt16(Console.ReadLine());

int result = number % 10;

Console.WriteLine("Последняя цифра: " + result);
