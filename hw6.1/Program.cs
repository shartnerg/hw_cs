Console.Clear();
Console.Write("Vvedite chisla cherez probel: ");
string numbersStr = Console.ReadLine();

string[] numbers = numbersStr.Split(' ');
int count = 0;

foreach (string numberStr in numbers)
{
    int number = int.Parse(numberStr);
    if (number > 0)
    {
        count++;
    }
}

Console.WriteLine($"Kolvo chisel bolshe 0: {count}");