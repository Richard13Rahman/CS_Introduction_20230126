//Данно число. Проверить есть ли в этом числе цифра 0.ъ
System.Console.Write("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
bool flag=false;
while (N!=0)
{
    int d=N%10;
    if (d==0)
        flag=true;
    N/=10;
}

if (flag)
    System.Console.Write("В числе есть 0");
else
    System.Console.Write("В числе нет 0");

