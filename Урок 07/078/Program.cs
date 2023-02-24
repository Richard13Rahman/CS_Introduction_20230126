//78. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. 
//Использовать рекурсию.
System.Console.Write("Введите количество первых чисел Фибоначи:");
int N=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<N;i++)
    System.Console.Write($"{Fib(i),5}");

int Fib(int N)
{
    if (N==0)
        return 0;
    else
        if (N==1)
            return 1;
        else
            return Fib(N-1)+Fib(N-2);
}
