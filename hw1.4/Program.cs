Console.Clear();

Console.WriteLine("Enter a number N:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("The even numbers from 1 to N:");
for (int i = 2; i <= n; i += 2)
{
Console.WriteLine(i);
}