//12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int n,d0,d1,max;
System.Console.Write("Введите число от 10 до 99:");
n=Convert.ToInt32(Console.ReadLine());
d0=n%10;
d1=n/10;
max=d0;
if (max<d1)
{
    max=d1;
}
System.Console.WriteLine($"Наибольшая цифра числа {n} равна:{max}");