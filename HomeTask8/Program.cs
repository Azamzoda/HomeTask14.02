
void Min(int a, int b, int c, int d)
{
    if(a<b && a<c && a<d)System.Console.WriteLine($"{a}");
     if(b<a && b<c && b<d)System.Console.WriteLine($"{b}");
      if(c<a && c<b && c<d)System.Console.WriteLine($"{c}");
     if(d<a && d<b && d<c)System.Console.WriteLine($"{d}");
}
int a=1, b=2, c=3, d=4;
Min(a,b,c,d);