//77. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1 
System.Console.Write("Введите количество первых чисел Фибоначи:");
int N=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<N;i++)
    System.Console.Write($"{Fib(i),4}");
int Fib(int N)
{
    if (N==0)
        return 0;
    else
        if (N==1)
            return 1;
        else    return Fib(N-1)+Fib(N-2);
}
