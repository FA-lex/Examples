// Найти расстояние между точками в пространстве 2D/3D


// Определяемся с пространством
Console.WriteLine("Определите пространство 2D или 3D");
Console.WriteLine("Введите 1 или 2 соответственно: ");
bool definedSpace = false;
int space = 0;
while (definedSpace == false)
{
    space = Convert.ToInt16(Console.ReadLine());
    if (space == 1 || space == 2)
    {
        definedSpace = true;
    }
    else
    {
        Console.WriteLine("Введите 1 если пространство 2D или 2 если пространство 3D: ");
    }
}

// Запрос координат двух точек

double[] firstPoint = new double[3];
Console.WriteLine("Введите координату X первой точки: ");
firstPoint[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
firstPoint[1] = Convert.ToDouble(Console.ReadLine());
if (space == 2)
{
    Console.WriteLine("Введите координату Z первой точки: ");
    firstPoint[2] = Convert.ToDouble(Console.ReadLine());
}

double[] secondPoint = new double[3];
Console.WriteLine("Введите координату X второй точки: ");
secondPoint[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
secondPoint[1] = Convert.ToDouble(Console.ReadLine());
if (space == 2)
{
    Console.WriteLine("Введите координату Z второй точки: ");
    secondPoint[2] = Convert.ToDouble(Console.ReadLine());
}

// вычисление расстояния по проекциям и самого расстояния между точками
double squareLongProjectXY = firstPoint[0] * firstPoint[0] + firstPoint[1] * firstPoint[1];
double distans = 0;
if (space == 2)
{
    distans = Math.Sqrt(squareLongProjectXY + firstPoint[2] * firstPoint[2]);
}
else
{
    distans = Math.Sqrt(squareLongProjectXY);
}


Console.WriteLine("расстояние между точками равно: " + distans);
