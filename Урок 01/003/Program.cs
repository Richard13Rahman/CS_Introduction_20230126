// С клавиатуры вводятся два числа a и b. Найти максимальное из них.

int a,b;
System.Console.Write("Введите а:");;
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");;
b=Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    System.Console.Write($"Максимальное число:{a}");
}
else
{
    System.Console.Write($"Максимальное число:{b}");
}