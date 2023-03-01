//98. Показать треугольник Паскаля (Пирамида)
System.Console.Write("Задайте размер массива для треугольника Паскаля:");
int n=Convert.ToInt32(Console.ReadLine());
int[,] a=Triangle_Pascal(n);
Print_2D_array(a);


int[,] Triangle_Pascal(int n)
{
    int[,] a=new int[n,n*2];
    for (int i=0;i<n;i++)
    {
        if (i==0) a[i,n]=1;
        else
        {
            for (int j=0;j<n*2;j++)
            {
                if(j!=0 && j!=n*2-1)
                    a[i,j]=a[i-1,j-1]+a[i-1,j+1];
                else
                {
                    if (j==0) 
                        a[i,j]=a[i-1,j+1];
                    else
                        a[i,j]=a[i-1,j-1];
                }
            }
        }
    }
    return a;
}

void Print_2D_array(int[,] a)
{
    int y=(int)Math.Log10(a.Cast<int>().Max()) + 1;
    if (y==1)
    {
        for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
                if(a[i,j]==0) System.Console.Write($"{"",1}");
                else System.Console.Write($"{a[i,j],1}");
            System.Console.WriteLine();
        };
    }
    if (y==2)
    {
        for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
                if(a[i,j]==0) System.Console.Write($"{"",2}");
                else System.Console.Write($"{a[i,j],2}");
            System.Console.WriteLine();
        };
    }
    if (y==3)
    {
        for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
                if(a[i,j]==0) System.Console.Write($"{"",3}");
                else System.Console.Write($"{a[i,j],3}");
            System.Console.WriteLine();
        };
    }
    if (y==4)
    {
        for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
                if(a[i,j]==0) System.Console.Write($"{"",4}");
                else System.Console.Write($"{a[i,j],4}");
            System.Console.WriteLine();
        };
    }
    if (y==5)
    {
        for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
                if(a[i,j]==0) System.Console.Write($"{"",5}");
                else System.Console.Write($"{a[i,j],5}");
            System.Console.WriteLine();
        };
    }
}
