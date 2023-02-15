//36. Написать программу вычисления произведения чисел от 1 до N

System.Console.Write("Введите число N:");
System.Console.WriteLine("Произведение чисел равна:"+Multiplication(Convert.ToInt32(Console.ReadLine())));

int Multiplication(int n)
{
    int sum=1;
    for (int i=1;i<=n;i++)
        {   
            sum*=i;
        }
    return sum;
}
