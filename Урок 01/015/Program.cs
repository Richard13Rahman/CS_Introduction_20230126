//15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
int n,d2;
Console.Write("Введите целое число:");
n=Convert.ToInt32(Console.ReadLine());
d2=n/100%10;
if (n>99)
{
    System.Console.WriteLine($"Третья цифра введеного числа равно:{d2}");
}
else
{
    System.Console.WriteLine("NO");
}

