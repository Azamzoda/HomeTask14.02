
void Swap(ref int x, ref int y)
{
    int c=x;
    x=y;
    y=c;
    Console.WriteLine($"x={x}");
    Console.WriteLine($"y={y}");
    
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
Swap(ref a, ref b);

