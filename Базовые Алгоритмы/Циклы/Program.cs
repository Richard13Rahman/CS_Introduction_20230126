/*Циклы до тех пор или ципл с пост условием
int x;
do
{
    System.Console.Write("Введите трехзначное число:");
    x=Convert.ToInt32(Console.ReadLine());
}
while (x<100 || x>999);
*/
/*
//Ввести n от 0 до 10 с проверкой ввода

//Цикл до тех пор (цикл с постусловием)
int n;//Область видимости переменных (то есть значение нужно писать за фигурные скобки)
do
{
    System.Console.Write("Введите число n:");
    n=Convert.ToInt32(Console.ReadLine());
}
while(n<0 || n>10);
*/
/*
//Цикл для
//вывестт на экран числа от 1 до 10
int i=1;
while (i<=19)
{
    System.Console.WriteLine(i);
    i++; //i=i=1
}
*/
/*
//Второй вариант используя for
for (int i=1;i<=10;i++)
{
    System.Console.WriteLine(i);
}
*/
/*
//Цикл посложнее
for (int i=1,k=100;i<=100 && k>=50;i++,k--)
{
    System.Console.WriteLine(i+""+k);
}
*/

//Специфичный цикл
string s="ABCDED";
foreach(char c in s)//работает с коллекциями (реализующими интерфейс IEnumerable) то есть с масивами, текстами, строками
{
    System.Console.WriteLine(c);
}