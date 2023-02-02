// C Клавиатуры вводится два числа. Найти и вывести на экран их сумму

//string s;
int a,b,sum;
System.Console.Write("Введите а:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
//1. Конкатенация (склевание) строк
System.Console.WriteLine(a+"+"+b+"="+Convert.ToString(sum));
//2. Форматированный вывод
System.Console.WriteLine("{0:F2}+{1:E5}={2:G4}",a,b,sum);
//3. Интерполяция строк
System.Console.WriteLine($"{a}+{b}={sum}");
