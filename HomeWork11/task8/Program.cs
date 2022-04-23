// Ване поручено важное задание — он должен пронумеровать книжки в библиотеке,
// поставив на каждую бирку книжку с её номером.
// Каждая из n книг должна получить номер от 1 до n,
// причем, разумеется, разные книги должны получить разные номера.

// Ваня хочет узнать, какое количество цифр ему придётся написать, подписывая все бирки.

// Входные данные
// В первой строке содержатся целое число n (1 ≤ n ≤ 109) — количество книг в библиотеке.

// Выходные данные
// Выведите количество цифр, нужных для того, чтобы пронумеровать все книги.


int CountNumberDigits(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        int j = i;
        while (j > 0)
        {
            count++;
            j = j / 10;
        }
    }
    return count;
}


Console.Write("Input, how many books in the library: ");
int amount = int.Parse(Console.ReadLine() ?? "0");

int countDigit = CountNumberDigits(amount);
Console.WriteLine(countDigit);
