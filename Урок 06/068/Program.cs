//68. Написать программу, которая обменивает элементы первой строки и последней строки
System.Console.Write("Введите количество строк массива:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество стобцов массива:");
int n=Convert.ToInt32(Console.ReadLine());

int[,] a=Random_2D_array(m,n,0,20);
System.Console.WriteLine($"Двухмерный массив размером {m}х{n} имеет следующий вид:");
Print_2D_array(a);
Replacing_strings(a);
System.Console.WriteLine("Двухмерный массив после замены первой и последней строки:");
Print_2D_array(a);


int[,] Random_2D_array(int M, int N, int min, int max)
{
    int[,] a=new int[M,N];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

void Print_2D_array(int[,] a)
{
     for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],5}");
        System.Console.WriteLine();
    };
}

int[,] Replacing_strings(int[,] a)
{
        for(int j=0;j<a.GetLength(1);j++)
        {
            int i=0;
            int t=0;
            t=a[i,j];
            a[i,j]=a[a.GetLength(0)-1,j];
            a[a.GetLength(0)-1,j]=t;
        }    
    return a;
}
