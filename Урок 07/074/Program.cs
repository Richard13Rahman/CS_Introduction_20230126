//74. Найти сумму цифр числа
int N=3254;
System.Console.WriteLine(Sum_number(N,0,Cuonter_Digits(N),0));

double Sum_number(int N,int i,int x,int s)
{
    if (i<x)
    {
        s=s+N%10;
        return Sum_number(N/10,i+1,x,s);
    }
    else
        return s;
}

int Cuonter_Digits(int n)
{
    if (n==0) return 1;
    int counter=0;
    while(n!=0)
    {
        counter++;
        n/=10;
    }
    return counter;
}