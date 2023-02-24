//Рекурсия
//Вывести на экран числа от 1 до N без использования цикла. GOTO запрещён
/*
int N=10;
int i=0;
//System.Console.WriteLine(i++);//постинкримент
//System.Console.WriteLine(++i);//прединкримент
//System.Console.WriteLine(i);
while(i<N)
{
    //i++;//Оператор инкремент (создан для упрощение программы)
    System.Console.Write($"{++i,4}");
}
*/

/* Запрещеннный приём
//!!!!!!ЗАПРЕЩЕНО!!!!!!!
metka:
    System.Console.Write($"{++i,4} ");
if (i<N) goto metka;//оператор безусловного перехода (зацикливает программу между 22 и 20 строками в данном примере)
*/

/*//Рекурсия
Loop(1,20);
void Loop(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i<N) Loop(i+1,N);//рекурсия
}
*/

/*//Рекурсия факториала
System.Console.WriteLine(F(5));
int F(int N)
{
    if (N>0) return F(N-1)*N;
    else return 1;
}
*/

/*//Числа фибонначи
for(int i=0;i<10;i++)
    System.Console.WriteLine(Fib(i));
int Fib(int N)
{
    if (N==0) return 0;
        else
            if (N==1) return 1;
                else
                    return Fib(N-1)+Fib(N-2);
    
}
*/

/*//Сумма чисел через рекурсию
for(int i=-10;i!=0;i++)
    System.Console.WriteLine(Power(2,i));
double Power(int a,int b)
{
    if (b==0) return 1;
    else
        if (b>0) 
            return Power(a,b-1)*a;
        else
            return Power(a,b+1)*1/a;
}
*/
