//5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a,b,c,max;
System.Console.Write("Введите а:");;
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");;
b=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите c:");;
c=Convert.ToInt32(Console.ReadLine());
max=a;
if (max<b)
{
    max=b;
}
if (max<c)
{
    max=c;
}
System.Console.Write($"Максимальное число:{max}");