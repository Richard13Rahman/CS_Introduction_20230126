//61. Показать двумерный массив размером m×n заполненный вещественными случайными числами
System.Console.Write("Введите количество строк массива:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество стобцов массива:");
int n=Convert.ToInt32(Console.ReadLine());

double[,] a=Random2DArray(m,n);
System.Console.WriteLine($"Двухмерный массив размером {m}х{n} имеет следующий вид:");
Print_2D_Array(a);

double[,] Random2DArray(int M, int N)
{
    double[,] a=new double[M,N];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.NextDouble()*20;//Добавил (*20), а то генератор выдает числа от 0,0 до 1,0. Так хоть по привлекательнее выглядит
    return a;
}

void Print_2D_Array(double[,] a)
{
     for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],8:F2}");
        System.Console.WriteLine();
    };
}

