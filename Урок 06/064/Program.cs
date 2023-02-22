//64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.
System.Console.Write("Введите количество строк массива:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество стобцов массива:");
int n=Convert.ToInt32(Console.ReadLine());

int[,] a=Random_2D_array(m,n,0,20);
System.Console.WriteLine($"Двухмерный массив размером {m}х{n} имеет следующий вид:");
Print_2D_array(a);
Replacement_2D_array(a);
System.Console.WriteLine("Данный массив после замены элементов будет иметь ввид:");
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
            System.Console.Write($"{a[i,j],6}");
        System.Console.WriteLine();
    };
}

int[,] Replacement_2D_array(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        if (i%2==0)
        {
            for(int j=0;j<a.GetLength(1);j++)
            {
                if (j%2==0)
                {
                    a[i,j]*=a[i,j];
                }
            }
        }
    }
    return a;
}
