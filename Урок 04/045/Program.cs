//45. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] a=new int[6];
Random random=new Random();
for (int i=0;i<a.Length;i++)
{
    a[i]=random.Next(100,1000);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
int en=0;
int on=0;
for (int i=0;i<a.Length;i++)
{
    if(a[i]%2==0)
        en++;
    else
        on++;
}
System.Console.WriteLine($"Количество четных элементов массива:{en}");
System.Console.WriteLine($"Количество нечетных элементов массива:{on}");
