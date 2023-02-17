//Возможность обмена значений

int a=4;
int b=5;
int s,sb;
Calculator(a,b,out s,out sb);
System.Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b);
System.Console.WriteLine($"a={a} b={b}");
/*
//Cтандартный способ обмена
int t=a;
a=b;
b=t;
*/

/*
//Способ используя уравнения
a=a+b;
b=a-b;
a=a-b;
*/

/*
//Передача по значению (value)
void Swap(int x, int y)
{
    int t=x;
    x=y;
    y=t;
}
*/

//Передача по ссылке (references)
void Swap(ref int x, ref int y)
{
    int t=x;
    x=y;
    y=t;
}

void Calculator(int a,int b, out int sum, out int sub)
{
    sum=a+b;
    sub=a-b;
}