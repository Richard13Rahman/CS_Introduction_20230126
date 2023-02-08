//22. По двум заданным числам проверять является ли одно квадратом другого
System.Console.Write("Введите первое число:");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число:");
int y=Convert.ToInt32(Console.ReadLine());
if (y==x*x || x==y*y) System.Console.Write("Одно число является квадратом другому");
else
    System.Console.Write("Числа НЕ являются квадратами друг друга");
