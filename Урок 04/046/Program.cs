//46. Создать массив из 123 элементов. Заполнить случайными положительными числами от 0 до 1000. Найти количество элементов которые принадлежат отрезку [10,99]. 
int[] a=new int[123];
Random random=new Random();
for (int i=0;i<a.Length;i++)
{
    a[i]=random.Next(0,1000);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
int q=0;
for (int i=0;i<a.Length;i++)
    if (a[i]>9 && a[i]<100)
        q++;
System.Console.WriteLine($"Количество заданных элементов в массиве равно:{q}");