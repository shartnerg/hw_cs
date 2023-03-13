Console.Clear();
Console.Write("Vvedite razmer massiva: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next();
Console.WriteLine($"Massiv: [{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
    if (array[i + 1] > array[i])
    {
        int a = array[i + 1];
        int b = array[i];
    }
    else
     if (array[i] > array[i + 1])
    {
       int a = array[i];
       int b = array[i + 1];
    }
Console.Write($"Min {a}");
Console.Write($"Min {b}");