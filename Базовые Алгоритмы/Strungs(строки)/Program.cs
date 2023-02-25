//Строки

/*char c='A';//простой тип данных хранящая символы (одинарные кавычки)
string s="A";//тип данных строки (в двойных кавычках)
System.Console.WriteLine((int)c);//вывод кода символа
System.Console.WriteLine(c);//вывод символа*/

/*ConsoleKeyInfo keyInfo;
do
{
    keyInfo=Console.ReadKey();
    char c=keyInfo.Key  Char;
    System.Console.WriteLine();
    System.Console.WriteLine((int)c);
    if (c>='0' && c<='9') System.Console.WriteLine("Digit");
    if (c>='A' && c<='Z') System.Console.WriteLine("Big latin");
    if (char.IsDigit(c)) System.Console.WriteLine("Digit");
    System.Console.WriteLine(keyInfo.Key);
}
 while (keyInfo.Key!=ConsoleKey.Escape);*/

//замена символа
string s="Hello!";//Неизменяемые строки (immutable)
System.Console.WriteLine(s[2]);//Индексация символа. Выводт символ находившийся в заданом порядке строки. 
char[] chars=s.ToCharArray();
chars[0]='h';//Замена символа
s=new string(chars);
System.Console.WriteLine(s);

/*ввыод нескольких значений и перевод их из строки в числа
string s=Console.ReadLine();
string[] s1=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);//команда удаление пустых строк, то есть пробелов
int[] a=new int[s1.Length];
//for (int i=0;i<s1.Length;i++)
//    a[i]=Convert.ToInt32(s1[i]);
int[] b=Array.ConvertAll<string, int>(s1, Convert.ToInt32);
for (int i=0;i<s1.Length;i++)
{
    System.Console.Write(b[i]);
}*/

/*String VS StringBuilder
using System.Text;
System.Diagnostics.Stopwatch stopwatch=new System.Diagnostics.Stopwatch();
stopwatch.Start();
string s="";
int N=10000;
for(int i=0;i<N;i++)
    s=s+"ABCDEFGHIJKLMNOPQRSTVWXYZ";
stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
stopwatch.Reset();
stopwatch.Start();
StringBuilder sb=new StringBuilder();
for(int i=0;i<N;i++)
    sb.Append("ABCDEFGHIJKLMNOPQRSTVWXYZ");
stopwatch.Stop();
string s3=sb.ToString();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);*/

/*
Random r1=new Random(100);
Random r2=new Random(100);
r2=r1;
System.Console.WriteLine(r1==r2);//сравнение как объекты то есть под их адресу
string s1="hello!";
string s2="Hello!";
System.Console.WriteLine(s1.CompareTo(s2));//сравнение по содержимому
System.Console.WriteLine(s1.IndexOf('h'));
System.Console.WriteLine(s1.ToUpper());//Делает текст заглавными буквами
System.Console.WriteLine(s1+s2);

string[] s3=new string[3];
s3[0]="word";
s3[1]="word";
s3[2]="word";
string s4=String.Join(" ", s3);//статический метод
System.Console.WriteLine(s4);*/