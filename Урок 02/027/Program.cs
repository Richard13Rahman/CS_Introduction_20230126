//27.Найти расстояние между точками в пространстве 2D
System.Console.Write("Введите координату X первой точки:");
int x1=Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите координату Y первой точки:");
int y1=Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите координату X второй точки:");
int x2=Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите координату Y второй точки:");
int y2=Math.Abs(Convert.ToInt32(Console.ReadLine()));
double a,b,c;
a=x1+x2;
b=y1+y2;
c=Math.Pow(a,2)+Math.Pow(b,2);
System.Console.Write($"Растояние между точками равна:{Math.Sqrt(c)}");