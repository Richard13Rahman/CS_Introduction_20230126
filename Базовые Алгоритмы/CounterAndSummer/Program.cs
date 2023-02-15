//Подсчитать количество цифр и сумму цифр
System.Console.Write("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
int conter=0;//счетчик
int sum=0;//суммутор

while(N!=0)
{
    //conter=conter+1; есть другой вариант
    conter++;
    int d=N%10;
    //sum=sum+d; есть другой вариант
    sum+=d;
    //N=N/10; есть другой вариант
    N/=10;
}
System.Console.Write($"Количество цифр в числе:{conter}; Сумма цифр в числе:{sum}:");