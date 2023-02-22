//66. Написать подпрограмму, которая в квадратной матрице чисел находит сумму элементов главной диагонали

int[,] a=Random2DArray(4,4,0,20);
Print_2D_Array(a);
System.Console.WriteLine(SumMainDiagonal(a));

int[,] Random2DArray(int N, int M, int min, int max)
{
    int[,] a=new int[N,M];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

void Print_2D_Array(int[,] a)
{
     for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],5}");
        System.Console.WriteLine();
    };
}

int SumMainDiagonal(int[,] a)
{
    int s=0;
    for(int i=0;i<a.GetLength(0);i++)
    {
        
        s=s+a[i,i];
        
    };
    return s;
};