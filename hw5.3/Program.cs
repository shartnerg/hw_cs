Console.Clear();
Console.Write("Vvedite razmer massiva: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next();
Console.WriteLine($"Massiv: [{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
    if (array[i+1]>array[i])
    {
    int max=array[i+1];
    int min=array[i];
    }
    else
     if (array[i]>array[i+1])
    {
    int max=array[i];
    int min=array[i+1];
    }
Console.Write($"Min, Max: [{string.Join(", ", min, max)}]");


/*
double r = 0;

for (int i = 1; i < array.Length; i = i++)
{
    if(array[i+1]>array[i])
    
}
Console.WriteLine($"Summa {count}");
