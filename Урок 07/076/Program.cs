//76. Написать программу возведения числа А в целую степень B
System.Console.Write("Введите число:");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите целую степень числа:");
int B=Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Число {A} в степени {B} будет равно:{Power(A,B)}");

double Power(int a,int b)
{
    if (b==0) return 1;
    else
        if (b>0) 
            return Power(a,b-1)*a;
        else
            return Power(a,b+1)*1/a;
}