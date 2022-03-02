// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзачное число: ");
int num = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Вторая цифра: " + num / 10 % 10);
