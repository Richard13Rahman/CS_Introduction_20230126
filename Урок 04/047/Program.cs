//47. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] a=new int[10];
Random random=new Random();
for (int i=0;i<a.Length;i++)
{
    a[i]=random.Next(-9,10);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
int s=0;
for (int i=1;i<a.Length;i+=2)
    s+=a[i];
System.Console.WriteLine(s);