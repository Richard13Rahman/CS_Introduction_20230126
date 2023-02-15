// Дать число. Найти максимальную и минимальную цифру числа.
System.Console.Write("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
int min,max;
min=10;
max=-1;
while (N!=0)
{
    int digit=N%10;
    if (digit>max) max=digit;
    if (digit<min) min=digit;
    N/=10;//N=N/10
}
System.Console.Write($"Минимальное цифра числа:{min}, максимальное цифра числа:{max}");//Строка интерполяция