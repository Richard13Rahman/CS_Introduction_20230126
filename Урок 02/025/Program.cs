//25. Задать номер четверти, показать диапазоны для возможных координат
System.Console.Write("Введите номер четверти:");
int quarter=Convert.ToInt32(Console.ReadLine());
if (quarter==1) System.Console.WriteLine("x>0 and y>0");
if (quarter==2) System.Console.WriteLine("x<0 and y>0");
if (quarter==3) System.Console.WriteLine("x<0 and y<0");
if (quarter==4) System.Console.WriteLine("x>0 and y<0");