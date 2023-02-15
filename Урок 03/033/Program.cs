//33. Возведите число А в натуральную степень B используя цикл
System.Console.Write("Введите число A:");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите натуральную стемень B:");
int B=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ответ:"+NaturalDegree(A,B));

int NaturalDegree(int a,int b)
{
    int s=1;
    for (int i=1;i<=b;i++)
        {   
            s*=a;
        }
    return s;
}