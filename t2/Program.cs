int SummaNumber(int m, int n, int count, int sum)
{
    sum = sum + count;
    count++;
    if (count <= n)
    { return SummaNumber(m, n, count, sum); }
    else
    { return sum; }
}

Console.Write("Введите значения m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значения n ");
int n = Convert.ToInt32(Console.ReadLine());
int count = m;
int sum = SummaNumber(m, n, count, 0);
Console.WriteLine("Сумма  = " + sum);