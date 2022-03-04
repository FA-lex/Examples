// task2_3: Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number %10 == number / 10000 && (number %100)/10 == (number / 1000)%10)
{
    Console.WriteLine("данное число является полиндромом");
}
else {Console.WriteLine("данное число не является полиндромом");}
