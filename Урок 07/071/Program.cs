//71. Показать натуральные числа от N до 1, N задано
int N=10;
Loop(1,N);
void Loop(int i, int N)
{
    System.Console.Write($"{N,4}");
    if (i<N) Loop(i,N-1);
}
