// Алгоритм Эвклида
int a=75,b=15;
int a1=a,b1=b;
while(a!=b)
    if (a>b)
        a-=b;//a=a-b
    else
        b-=a;//b=b-a
System.Console.WriteLine("NOD="+a);//Наибольший общий делитель
System.Console.WriteLine("NOK="+(a1*b1)/a);//наименьшее общее кратное
