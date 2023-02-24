//73. Найти сумму элементов от M до N, N и M заданы
int N=10;
int M=5;
System.Console.WriteLine(Sum(M,N));


int Sum(int M, int N)
{
    int s=M;
    if (M==N) return s ;
    else
    {
        return s+Sum(M+1,N);
    }
}