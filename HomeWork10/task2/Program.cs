// Вася живёт в круглом доме, подъезды которого последовательно пронумерованы целыми числами от 1 до n.
// Причём подъезды номер n и номер 1 являются соседними.

// Сегодня Васе стало скучно, и он решил погулять во дворе.
// Вася живёт в подъезде номер a, и он решил, что его прогулка будет заключаться в движении вокруг дома
// в порядке возрастания номеров подъездов на b подъездов
// (в таком порядке после подъезда номер n следует подъезд номер 1).
// Отрицательное значение b соответствует движению в порядке убывания номеров подъездов на |b| подъездов
// (в таком порядке после подъезда номер 1 следует подъезд номер n).
// Если же b = 0, то Вася предпочитает гулять рядом со своим подъездом.

// Помогите Васе определить номер подъезда, возле которого он окажется в конце своей прогулки.


int EntrenceAfterWalk(int entrences, int startEntrence, int walkEntrence)
{
    if (walkEntrence == 0) return startEntrence;
    int remainsGo = walkEntrence;
    int nowEntrence = startEntrence;
    while (remainsGo != 0)
        if (walkEntrence > 0)
        {
            nowEntrence++;
            remainsGo--;
        }
        else if (walkEntrence < 0)
        {
            nowEntrence--;
            remainsGo++;
        }
    if (nowEntrence % entrences == 0) return entrences;
    else if(walkEntrence>0) return nowEntrence % entrences;
    else return entrences + nowEntrence % entrences;
}


Console.Write("How many entreces to the house? ");
int entrencesToHouse = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Where does Vasya live? ");
int entrenceVasya = int.Parse(Console.ReadLine() ?? "0");
Console.Write("How long will Vasya walk? ");
int walkEntrence = Convert.ToInt32(Console.ReadLine());

int stopedVasya = EntrenceAfterWalk(entrencesToHouse, entrenceVasya, walkEntrence);
Console.WriteLine($"Vasya stop near the entrance {stopedVasya}");
