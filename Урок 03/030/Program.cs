//30. Вывести на экран таблицу квадратов чисел от 1 до N.
/*Решение без подпрограммы
System.Console.Write("Введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=N;i++)
{
    System.Console.WriteLine($"{i} - {Math.Pow(i,2)}");
}
*/

//Я помню, что Writeline в циклы лучше не устанавливать, но... других вариантов сделать программу короче я не вижу. Да и к тому же всё прекрасно работает)
System.Console.Write("Введите число N:");
SquareTable(Convert.ToInt32(Console.ReadLine()));

double SquareTable(int N)
{
    for (int i=1;i<=N;i++)
    {
        System.Console.WriteLine($"{i} {Math.Pow(i,2),10}");
    }
return N;
}

