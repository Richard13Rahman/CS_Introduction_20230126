//72. Показать натуральные числа от M до N, N и M заданы
int N=25;
int M=5;
Loop(M,N);
void Loop(int M, int N)
{
    System.Console.Write($"{M,4}");
    if (M<N) Loop(M+1,N);
}

