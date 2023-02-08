//26. Программа проверяет пятизначное число на палиндромом. Например: 12321
/* Первый вариант решения даной задачки
System.Console.Write("Для определения палидрома введите пятизначное число:");
int number=Convert.ToInt32(Console.ReadLine());
int b1,b2,b3,b4,b5,number2;
b1=number/10000;
b2=number/1000%10;
b3=number/100%10;
b4=number/10%10;
b5=number%10;
number2=b5*10000+b4*1000+b3*100+b2*10+b1;
if (number==number2) System.Console.WriteLine($"Число:{number} - полиндром!");
else
    System.Console.WriteLine($"Число:{number} - НЕ полиндром!");
*/

//Второй вариант. Мне он больше нравится)
System.Console.Write("Для определения палидрома введите пятизначное число:");
int number=Convert.ToInt32(Console.ReadLine());
if (number/10000==number%10 && number/1000%10==number/10%10) System.Console.WriteLine($"Число:{number} - полиндром!");
else
    System.Console.WriteLine($"Число:{number} - НЕ полиндром!");