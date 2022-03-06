// Задать массив из 8-и элементов и вывести на экран

Console.WriteLine("введите восемь элементов через энтер");
int[] nums = new int[8];
for (int i = 0; i < 8; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nВведенный массив : ");

for (int i = 0; i < 8; i++)
{
    Console.Write(nums[i] + " ");
} 
Console.WriteLine(" ");
