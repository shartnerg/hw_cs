﻿Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 1; i <= b; i++)
{
    result *= a;
}

Console.WriteLine($"{a}^{b} = {result}");