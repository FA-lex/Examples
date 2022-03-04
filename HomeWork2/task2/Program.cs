// Показать четные числа от 1 до N

Console.WriteLine("Чтобы показать четные числа от 1 до N введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 2;

while (count <= N)
{
    Console.Write(count + ", ");
    count += 2;
}
Console.WriteLine( );
