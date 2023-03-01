//98. Показать треугольник Паскаля
//Сделать вывод в виде равнобедренного треугольника

System.Console.Write("Задайте размер массива для треугольника Паскаля:");
int n=Convert.ToInt32(Console.ReadLine());
int[,] a=Triangle_Pascal(n);
Print_2D_array(a);


int[,] Triangle_Pascal(int n)
{
    int[,] a=new int[n,n];
    for (int i=0;i<n;i++)
    {
        if (i==0) a[i,i]=1;
        else
        {
            for (int j=0;j<n;j++)
            {
                if (j==0) a[i,j]=a[i-1,j];
                else
                {
                    a[i,j]=a[i-1,j-1]+a[i-1,j];
                }
            }
        }
    }
    return a;
}

void Print_2D_array(int[,] a)
{
     for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            if(a[i,j]!=0)//Тут я спрятал нули, а то с ними не красиво)
                System.Console.Write($"{a[i,j],5}");
        System.Console.WriteLine();
    };
}


