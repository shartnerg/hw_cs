Console.Clear();

Console.Write("Write day number of the week(1-7): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 8 & n > 0)
{
    if (n > 5 & n < 8)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}
else Console.WriteLine("You need to write 1-7 number");