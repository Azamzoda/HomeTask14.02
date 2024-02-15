
int Jam (int a, int b)
{
    return a+b;
}
int Tarh (int a, int b)
{
    return a-b;
}
int Zarb (int a, int b)
{
    return a*b;
}
int Taqsim (int a, int b)
{
    return a/b;
}

int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Add: {Jam(a,b)}");
Console.WriteLine($"Subtract: {Tarh(a,b)}");
Console.WriteLine($"Multiply: {Zarb(a,b)}");
Console.WriteLine($"Devision: {Taqsim(a,b)}");