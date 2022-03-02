// Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзачное число: ");
int num = Convert.ToInt16(Console.ReadLine());

int endNum = num % 10;
int startNum = num / 100;
int res = startNum * 10 + endNum;

Console.WriteLine("Вторую цифру удалили: " + res);
