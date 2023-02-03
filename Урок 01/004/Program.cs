//4. По заданному с клавиатуры номеру дня недели вывести его название
int a;
System.Console.Write("Введите номер дня недели:");
a=Convert.ToInt32(Console.ReadLine());
if (a==1)
{
    System.Console.Write("Указан Понедельник");
}
if (a==2)
{
    System.Console.Write("Указан Втоник");
}
if (a==3)
{
    System.Console.Write("Указана Среда");
}
if (a==4)
{
    System.Console.Write("Указан Четверг");
}

if (a==5)
{
    System.Console.Write("Указан Пятница");
}
if (a==6)
{
    System.Console.Write("Указан Суббота");
}
if (a==7)
{
    System.Console.Write("Указан Воскресенье");
}
if (a>7)
{
    System.Console.Write("Вы указали неверный номер деня недели");
}
