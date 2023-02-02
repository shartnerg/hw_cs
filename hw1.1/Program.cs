Console.Clear();

Console.Write("First number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n>m)
{
    Console.Write($"max: {n} ");
    Console.Write($"min: {m} ");
}
else if (n<m)
{
    Console.Write($"max: {m} ");
    Console.Write($"min: {n} ");
}
else if (n==m)
{
    Console.Write("numbers are equal");
}