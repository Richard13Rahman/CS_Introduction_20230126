//43. Написать подпрограмму замены элементов целочисленного массива типа int на противоположные по значению. 
//Подпрограмма принимает на вход массив и в нем же и меняет значения.

int[] a=new int[10];
Random random=new Random();
for (int i=0;i<a.Length;i++)
{
    a[i]=random.Next(-9,10);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
Replacement(a);//подпрограмма замены
for (int i=0;i<a.Length;i++)
{
    System.Console.Write($"{a[i]} ");
}

int Replacement(int[] b)
{
    for (int i=0; i<a.Length;i++)
    {
        b[i]=b[i]*-1;
    }
    return b[a.Length-1];
}