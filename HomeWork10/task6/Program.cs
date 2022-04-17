// Недавно Юра поступил в БГУКП (Берляндский Государственный Университет Крутых Программистов).
//  У Юры есть друг Леша, который поступил вместе с ним, и теперь они заселяются в общежитие.

// Юра и Леша хотят жить в одной комнате. Всего в общежитии есть n комнат.
//  В данный момент в комнате с номером i живут pi человек,
//  когда всего в этой комнате может жить qi человек (pi ≤ qi).
//   Посчитайте, сколько комнат общежития смогут вместить Юру и Лешу вместе?


int SuitNumberRooms(int[,] filledRoom)
{
    int suitNumbers = 0;
    for (int i = 0; i < filledRoom.GetLength(0); i++)
    {
        if (filledRoom[i, 1] - filledRoom[i, 0] >= 2) suitNumbers++;
    }
    return suitNumbers;
}

int[,] GetOccupancyRoom(int n)
{
    int[,] occupancyRoom = new int[n, 2];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter, occupancy room {i+1} : ");
        occupancyRoom[i, 0] = int.Parse(Console.ReadLine() ?? "0");
        Console.Write($"enter, capacity room {i+1} : ");
        occupancyRoom[i, 1] = int.Parse(Console.ReadLine()?? "0");

    }
    return occupancyRoom;
}

Console.Write("enter, how many rooms are there in the dorm: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] occupancyRoom = GetOccupancyRoom(n);

Console.WriteLine(SuitNumberRooms(occupancyRoom));

