//93: Задайте две матрицы. Напишите программу с подпрограммой MultiMatrix, которая будет находить произведение двух матриц. 

int[,] a=Random_2D_array(4,4,1,5);
System.Console.WriteLine("Первый массив");
Print_2D_array(a);
int[,] b=Random_2D_array(4,4,1,5);
System.Console.WriteLine("Второй массив");
Print_2D_array(b);
System.Console.WriteLine("Произведение двух массивов");
Multi_matrix(a,b);

int[,] Random_2D_array(int N, int M, int min, int max)
{
    int[,] a=new int[N,M];
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

void Multi_matrix(int[,] a,int[,] b)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j]*b[i,j],5}");
        System.Console.WriteLine();
    };
}

