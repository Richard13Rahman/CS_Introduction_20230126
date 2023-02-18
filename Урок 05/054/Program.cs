//54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.Write("Введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
Fibonacci_numbers(N);

void Fibonacci_numbers(int a)
{
    int[] f=new int[a];
    if (a>=1)//Если введеное число 1, то и массив состояит из одного элемента, второй элемент даёт ошибку
    {
        f[0]=0;
    }  
    if (a>=2)
    {
        f[1]=1;
    } 
    for(int i=2;i<a;i++)
    {
        f[i]=f[i-1]+f[i-2];
    }
    for(int i=0;i<a;i++)
    {
        System.Console.WriteLine($"{i+1,2} {f[i],10}");
    }
}
