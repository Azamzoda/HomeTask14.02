
int Pow(int x, int y)
{
    int sum=1;
    for(int i=0; i<y; i++)
    {
        sum=sum*x;
    }
    return sum;
}
int x=Convert.ToInt32(Console.ReadLine());
int y=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{Pow(x,y)}");