Console.Write("Vvedite k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedite b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedite k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedite b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("Tochka peresecheniya: ({0}, {1})", x, y);