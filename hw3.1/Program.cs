Console.Clear();

Console.Write("Vvedite 5znachnoe chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
while (Math.Abs(n) < 10000 || Math.Abs(n) >= 100000)
{
    Console.Write("Nuzhno vvesti 5znachnoe chislo!\nVvedite 5znachnoe chislo: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int m = n / 10000, i = n % 10000 / 1000, k = n % 100 / 10;
if (Math.Abs(m) + Math.Abs(i) == Math.Abs(n % 10) + Math.Abs(k))
    Console.WriteLine("eto palindrom");
else
    Console.WriteLine("eto NE palindrom");

