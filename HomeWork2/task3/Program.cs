// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


Console.Write("Введите номер дня недели: ");
int numDay = Convert.ToInt16(Console.ReadLine());

if(numDay == 1 || numDay == 2 || numDay == 3 || numDay == 4)
{
    Console.WriteLine("День рабочий.");
}
else if(numDay == 5)
{
    Console.WriteLine("Ну почти, Пятница-маленькая Суббота. Но все-же день рабочий.");
}
else if(numDay == 6)
{
    Console.WriteLine("Выходной, Суббота");
}
else if(numDay == 7)
{
    Console.WriteLine("Выходной, Воскресенье");
}
else
{
    Console.WriteLine("Такого номера дня недели нет.");
}
