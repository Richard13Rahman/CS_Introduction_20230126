//67. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
System.Console.Write("Введите количество строк массива:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество стобцов массива:");
int n=Convert.ToInt32(Console.ReadLine());

int[,] a=Random_2D_array(m,n,0,20);
System.Console.WriteLine($"Двухмерный массив размером {m}х{n} имеет следующий вид:");
Print_2D_array(a);
double[] b=new double[n];
Arithmetic_mean(b);
System.Console.WriteLine("Среднее арифметическое каждого из тобцов указано ниже под стобцом массива выше:");
Print__array(b);

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
            System.Console.Write($"{a[i,j],7}");
        System.Console.WriteLine();
    };
}

double[] Arithmetic_mean(double[] b)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            b[j]=b[j]+a[i,j];
    }
    for(int j=0;j<a.GetLength(1);j++)
            b[j]=b[j]/a.GetLength(0);
    return b;
}

void Print__array(double[] b)
{
     for(int i=0;i<b.GetLength(0);i++)
    {
        System.Console.Write($"{b[i],7:F1}");   
    };
    System.Console.WriteLine();
}
