// Показать числа от -N до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = - num;

while (count <= num)
{
    Console.Write(count + ", ");
    count++;
}
Console.WriteLine( );
