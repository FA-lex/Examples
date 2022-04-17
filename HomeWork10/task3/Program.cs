// «Раз дракон. Два дракон. Три дракон», — считала принцесса. У нее была бессонница,
//  а считать барашков ей надоело еще в девять лет.

// Впрочем, считать драконов просто так тоже было скучно, поэтому она развлекалась как могла.
//  Этой ночью она представляла, что все посчитанные драконы явились сюда, чтобы ее украсть,
//   а она отбивается от них, как может. Каждого k-ого дракона она била сковородкой по морде.
//    Каждому l-ому — прищемляла хвост балконной дверью. Каждому m-ому — наступала на лапу острым каблучком.
//     Наконец, каждому n-ому она грозила позвать мамочку, и он в ужасе ретировался.

// Скольким воображаемым драконам успела нанести моральный или физический ущерб принцесса,
//  если всего она насчитала d драконов?

int NumberAffectDragons(int k, int l, int m, int n, int dragons)
{
    int affectDragons = 0;
    for (int i = 0; i < dragons; i++)
    {
        if (i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0)
            affectDragons++;
    }
    return affectDragons;
}

Console.Write("enter k: ");
int k = int.Parse(Console.ReadLine() ?? "0");

Console.Write("enter l: ");
int l = int.Parse(Console.ReadLine() ?? "0");

Console.Write("enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.Write("enter how many dragons: ");
int dragons = int.Parse(Console.ReadLine() ?? "0");

int numberAffectDragons = NumberAffectDragons(k, l, m, n, dragons);
Console.WriteLine(numberAffectDragons);
