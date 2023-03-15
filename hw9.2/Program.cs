int rec(int a, int b)
{
    if (b == a)
        return a;
    return rec(a, b - 1) + b;
}


Console.Clear();
Console.Write("Vvedite 1 chislo: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite 2 chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));