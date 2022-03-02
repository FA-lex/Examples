// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Последняя цифра: " + num%10);
