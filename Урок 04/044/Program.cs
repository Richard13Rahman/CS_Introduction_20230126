//44. Определить, присутствует ли в заданном массиве, некоторое число (линейный поиск)
int[] a=new int[10];
Random random=new Random();
for (int i=0;i<a.Length;i++)
{
    a[i]=random.Next(-9,10);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();

//Линейный поиск
int find=5;
int j=0;
while (j<a.Length && a[j]!=find) j++;
if (j==a.Length)
    System.Console.WriteLine("NO");
else
    System.Console.WriteLine($"Элемент {find} находится в идексе {j}");