﻿//82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
System.Console.Write("Введите строку разделенной точкой:");
string s=Console.ReadLine();
int k1=0,k2=0,k3=0,i=0;

for (i=0;i<s.Length;i++)
    if (s[i]=='.') k1=i;
System.Console.WriteLine($"Количество символов до точки (первым способом) равна:{k1}");

i=0;
foreach(char c in s)
{
    i++;
    if (c=='.') k2=i-1;
}
System.Console.WriteLine($"Количество символов до точки (вторым способом) равна:{k2}");


k3=s.IndexOf('.');
System.Console.WriteLine($"Количество символов до точки (третьим способом) равна:{k3}");
//Вот честно! Может об этом методе вы расскажете на 9 уроке, но я его ещё не просмотрел и в интернете не искал. Но запомнил, что в 8 вы упомянули что есть много методов для строк. Я предположил, что возможно есть метод подсчета до определенного знака, увы такой я не нашел, ибо с английским у меня не очень. А вот поиск индекса символа в строке, посчитал тоже подходящим под условия задачи.