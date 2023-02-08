//20. Дано число. Проверить кратно ли оно 7 и 23
int n;
Console.Write("Введите число:");
n=Convert.ToInt32(Console.ReadLine());
if (n%7==0 && n%23==0) System.Console.WriteLine("Введённое число кратно 7 и 23");
    else
        System.Console.WriteLine("Введённое число не кратно 7 и 23");