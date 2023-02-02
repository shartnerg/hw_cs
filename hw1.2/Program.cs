Console.Clear();

Console.WriteLine("Enter three numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
 max = num2;
}

if (num3 > max)
{
max = num3;
}

Console.WriteLine("The maximum number is: " + max);
Console.ReadLine();