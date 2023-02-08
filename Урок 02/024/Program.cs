//24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X≠0 и Y≠0
System.Console.Write("Введите координату X:");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y:");
int y=Convert.ToInt32(Console.ReadLine());
if (x==0 || y==0) System.Console.Write("Введено значение координаты 0, определение четверти невозможно!");
if (x>0 && y>0) System.Console.Write("Точка координат находится в ПЕРВОЙ четверти");
if (x>0 && y<0) System.Console.Write("Точка координат находится в ЧЕТВЁРТОЙ четверти");
if (x<0 && y<0) System.Console.Write("Точка координат находится в ТРЕТЬЕЙ четверти");
if (x<0 && y>0) System.Console.Write("Точка координат находится в ВТОРОЙ четверти");