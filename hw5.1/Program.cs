Console.Clear();
Console.Write("Vvedite razmer massiva: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000); // [100; 999]
Console.WriteLine($"Massiv: [{string.Join(", ", array)}]");
int count = 0;
foreach(int element in array)
{
    if(element%10==0 ||element%10==2|| element%10==4|| element%10==6|| element%10==8)
        count=count+1;
}
Console.WriteLine($"Summa {count}");
