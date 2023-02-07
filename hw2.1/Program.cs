Console.Clear();

Console.Write("Vvedite 3x znachnoe chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n<1000 & n>100 || n>-1000 & n<-100)
{
int n1 = (n / 10)%10;
Console.WriteLine(Math.Abs(n1));
}
else 
Console.WriteLine("Nuzhno vvseti 3x znachnoe chislo");