// Задача:
// Определить три точки
// Выбрать две любые
// Найти середину
// Поставить точку
// Выбрать случайную вершину треугольника
// Соеденить её с полученной на 4-м шаге точкой
// Перейти к шагу 3
// Шаги 3-7 повторить 9,28,31 раз

Console.Clear();

int xa = 40;
int ya = 1;
int xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("0");
    count++;
}

//Для форматирования документа `Ctrl+Shift+I`