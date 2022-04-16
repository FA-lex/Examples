// Написать программу возведения числа А в целую стень B


// функция возведения числа A в степень B
int ExponentiationNumber(int A, int B)
{
    if (B == 1) return A;
    return A * ExponentiationNumber(A, B-1);
}

int A = 2;
int B = 10;
Console.WriteLine(ExponentiationNumber(A, B));

