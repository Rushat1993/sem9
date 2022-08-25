int FumcAkkNumber(int m, int n)
{
    if (m == 0)
    { return n + 1; }
    else if (n == 0)
    { return FumcAkkNumber(m - 1, 1); }
    else
    { return FumcAkkNumber(m - 1, FumcAkkNumber(m, n - 1)); }
}

Console.Write("Введите значения m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значения n ");
int n = Convert.ToInt32(Console.ReadLine());
int FA = FumcAkkNumber(m, n);
Console.WriteLine("Функция Аккермана A(m,n) = " + FA);