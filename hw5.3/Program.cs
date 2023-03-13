Console.Clear();
Console.Write("Vvedite razmer massiva: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next();
Console.WriteLine($"Massiv: [{string.Join(", ", array)}]");
int max=array[0];
for (int i = 1; i < array.Length; i++)
if(array[i]>max)
max=array[i];


Console.WriteLine($"max: "(max));
