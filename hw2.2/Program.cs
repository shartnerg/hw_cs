Console.Clear();

Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n>1000 || n<-1000)
n=n/10;
if(n>100 || n<-100)
{
int n1 = n%10;
Console.WriteLine(Math.Abs(n1));
}
else 
Console.WriteLine("Tretey cifri net");