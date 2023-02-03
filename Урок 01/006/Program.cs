//6. Написать программу вычисления значения функции y = sin(a)

int a;
double b;
System.Console.Write("Введите а:");;
a=Convert.ToInt32(Console.ReadLine());
b=Math.Sin(a);
System.Console.Write($"Синус({a}) равен:{b}");