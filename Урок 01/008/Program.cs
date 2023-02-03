//8. Вывести на экран числа от -N до N

int i,N;
System.Console.Write("введите число N:");
N=Convert.ToInt32(Console.ReadLine());
i=-N;
while (i<=N)
{
System.Console.Write($"{i} ");
i=i+1;
}
