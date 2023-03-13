Console.Clear();
Console.Write("Vvedite razmer massiva: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101);
Console.WriteLine($"Massiv: [{string.Join(", ", array)}]");
int count = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    count = count + array[i];
}
Console.WriteLine($"Summa {count}");
