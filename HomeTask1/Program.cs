

int Evenn (int n)
{
    int cnt=0;
    for(int i=n; i>0; i/=10)
    {
       if (i%2==0)cnt++;
    }
       return cnt;
}

int Oddd (int n)
{
    int cnt2=0;
    for(int i=n; i>0; i/=10)
    {
       if (i%2!=0)cnt2++;
    }
       return cnt2;
}

int Digit (int n)
{
    int cnt3=0;
    int z=0;
    for(int i=n; i>0; i/=10)
    {
       z=i%10;
       cnt3++;
    }
    return cnt3;
}

int Summ (int n)
{
    int sum=0;
    for(int i=n; i>0; i/=10)
    {
       sum=sum+i%10;
    }
    return sum;
}

int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Even: {Evenn(n)}");
Console.WriteLine($"Odd: {Oddd(n)}");
Console.WriteLine($"Diggit: {Digit(n)}");
Console.WriteLine($"Sum: {Summ(n)}");
