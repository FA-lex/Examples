// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2,
// b1, k1, b2 и k2 заданы

void findPointCross(float k1, float b1, float k2, float b2) //функция поиска точки пересечения
{
    if (k1 == k2 && b1 ==b2) 
    {
        Console.WriteLine("Это одна и таже прямая.");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Точки пересечения не существует (прямые параллельны).");
    }
    else 
    {
        float x = (b2 - b1) / (k1 - k2);
        float y = k1 * x - b1;
        Console.WriteLine($"Координаты точки пересечения прямых: ({x}:{y})");
    }
    
}

// Запрашиваем параметры прямых
Console.WriteLine("Для прямых вида y = k1 * x + b1, y = k2 * x + b2 задайте параметры.");
Console.Write("Введите k1: ");
float k1 = float.Parse(Console.ReadLine() ??"");
Console.Write("Введите b1: ");
float b1 = float.Parse(Console.ReadLine() ??"");
Console.Write("Введите k2: ");
float k2 = float.Parse(Console.ReadLine() ??"");
Console.Write("Введите b2: ");
float b2 = float.Parse(Console.ReadLine() ??"");

//передаем параметры в фунцию поиска точки пересечения
findPointCross(k1, b1, k2, b2);
