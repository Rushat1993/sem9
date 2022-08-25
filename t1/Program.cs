//№64
void PrintNumber(int n)
{
    if (n < 1)
    {return;}
    Console.Write(n + " ");
    PrintNumber(n-1); 
}

Console.Write("Введите значение N ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumber(n);
Console.WriteLine("");