//34. Определить количество цифр в числе. Сделать подпрограмму.

System.Console.Write("Введите число для опредедления количества цифр:");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Cuonter_Digits(x)+" цифр в веденном числе");


int Cuonter_Digits(int n)
{
    if (n==0) return 1;
    int counter=0;//счетчик
    while(n!=0)
    {
        counter++;//counter=counter+1
        n/=10;//n=n/10
    }
    return counter;
}

