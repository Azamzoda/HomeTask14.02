void Max(int val1, int val2)
{
    if(val1>val2)System.Console.WriteLine($"{val1}");
     if(val2>val1)System.Console.WriteLine($"{val2}");
     
}
int val1=Convert.ToInt32(Console.ReadLine());
int val2=Convert.ToInt32(Console.ReadLine());
Max(val1,val2);