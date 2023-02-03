//14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b
int a,b;
Console.Write("Введите число a:");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b:");
b=Convert.ToInt32(Console.ReadLine());
if (a%b==0)
{
    System.Console.WriteLine($"Чичсло a:{a} кратно числу b:{b}");
}
else
{
    System.Console.WriteLine($"Чичсло a:{a} некратно числу b:{b}. Их остаток равен:{a%b}");
}

