//56. Написать программу копирования массива

System.Console.Write("Введите длину массива:");
int N=Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
int[] b=new int[N];
RandomArray(ref a);
PrintArray(a);
CopyArray(ref a,ref b);
PrintArray(b);


void RandomArray(ref int[] x)
{
    Random random=new Random();
    for (int i=0;i<x.Length;i++)
        {
            x[i]=random.Next(1,10); 
        }
}
void PrintArray(int[] y)
{
    for(int j=0;j<y.Length;j++)
    {
        System.Console.Write($"{y[j]} ");
    }
    System.Console.WriteLine();
}
void CopyArray(ref int[] n,ref int[] m)
{
    for (int i=0;i<n.Length;i++)
        {
            m[i]=n[i]; 
        }
}
