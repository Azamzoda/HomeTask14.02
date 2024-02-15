 
void Increament(ref int[] arr, ref int b)
{
    for(int i=0; i<3; i++)
    {
        arr[i]=arr[i]+b;
        System.Console.WriteLine(arr[i]);
    }
} 
// int n=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine()); 
int[] arr=new int[3]{1,2,3};

 
Increament(ref arr, ref b );
