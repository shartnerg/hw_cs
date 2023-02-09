Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), i = 1;
while (i <= n)
{    
    Console.Write($"{i * i * i} ");
    i++;
}
