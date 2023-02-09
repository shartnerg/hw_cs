Console.Clear();

Console.Write("Vvedite 5znachnoe chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n >= 100000)
{
    Console.Write("Nuzhno vvesti 5znachnoe polozhitelnoe chislo!\nVvedite 5znachnoe polozhitelnoe chislo: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int m = n / 10000, i = n % 10000 / 1000, k = n % 100 / 10;
if (m + i == n % 10 + k)
    Console.WriteLine("eto palindrom");
else
    Console.WriteLine("eto NE palindrom");

