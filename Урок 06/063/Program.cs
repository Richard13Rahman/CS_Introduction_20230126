//63. Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива
System.Console.Write("Введите количество строк массива:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество стобцов массива:");
int n=Convert.ToInt32(Console.ReadLine());

int[,] a=Identify_2D_array(m,n);
System.Console.WriteLine($"Двухмерный массив размером {m}х{n} имеет следующий вид:");
Print_2D_array(a);

int[,] Identify_2D_array(int M, int N)
{
    int[,] a=new int[M,N];
    
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=i+j;
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


