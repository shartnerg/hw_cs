Console.Clear();

Console.Write("Введите координату X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
Console.WriteLine($"Результат: {l}");