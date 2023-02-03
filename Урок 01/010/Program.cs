//10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int n,d;
System.Console.Write("Введите целое число:");
n=Convert.ToInt32(Console.ReadLine());
d=n%10;
System.Console.WriteLine($"Последняя цифра введеного числа равна:{d}");

