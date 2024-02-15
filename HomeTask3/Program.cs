


int Min (int n)
{
    int min=99999;
    for (int i=n; i>0; i/=10)
    {
        if(i%10<min)min=i%10;
    }
    return min;
}
int Max (int n)
{
    int max=-999999;
    for (int i=n; i>0; i/=10)
    {
        if (i%10>max)max=i%10;
    }
    return max;
}

int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{Min(n)} + {Max(n)} = {Max(n) + Min(n)}");