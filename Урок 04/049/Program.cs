//49. В указанном массиве целых чисел найдите разницу между максимальным и минимальным элементом
int[] a=new int[10];
Random random=new Random();
for (int i=0;i<a.Length;i++)
{
    a[i]=random.Next(0,10);
}
for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

int max=a[0];
for (int i=1;i<a.Length;i++)
    if (max<a[i])
        max=a[i];

int min=a[0];
for (int i=1;i<a.Length;i++)
    if (min>a[i])
        min=a[i];
System.Console.WriteLine(max-min);