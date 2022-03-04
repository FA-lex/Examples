// task2_2: Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Для определения номера четверти плоскости, в которой находится точка введите координатаы Х и У ");
Console.WriteLine("X ≠ 0 и Y ≠ 0 ");
Console.Write("X: ");
int koordX = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int koordY = Convert.ToInt32(Console.ReadLine());

if (koordX > 0 && koordY > 0)
{
    Console.WriteLine("точка принадлежит 1-й координатой четверти");
}
else if (koordX < 0 && koordY > 0)
{
    Console.WriteLine("точка принадлежит 2-й координатой четверти");
}
else if (koordX < 0 && koordY < 0)
{
    Console.WriteLine("точка принадлежит 3-й координатой четверти");
}
else if(koordX > 0 && koordY < 0)
{
    Console.WriteLine("точка принадлежит 4-й координатой четверти");
}
