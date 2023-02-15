//32. Найти сумму чисел от 1 до А
System.Console.Write("Введите число A:");
System.Console.WriteLine("Сумма чисел равна:"+Amount(Convert.ToInt32(Console.ReadLine())));

int Amount(int A)
{
    int sum=0;
    for (int i=1;i<=A;i++)
        {   
            sum+=i;
        }
    return sum;
}