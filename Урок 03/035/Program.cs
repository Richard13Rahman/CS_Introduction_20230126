//35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

System.Console.Write("Введите число:");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigits(x));

int SumDigits(int a)
{
    int sum=0;
    while (a%10!=0)
    {
        sum+=a%10;
        a/=10;
    }
    return sum;
}


