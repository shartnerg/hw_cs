﻿int rec(int m, int n)
{
    if (m == 0)
        return n+1;
    else if (n == 0)
        return rec(m-1, 1);
    else
    return rec(m-1, rec(m,n-1));
}


Console.Clear();
Console.Write("Vvedite 1 chislo: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite 2 chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));