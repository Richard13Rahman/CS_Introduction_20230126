//48. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. Создайте массив, который является произведением пар чисел в одномерном массиве a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//а) вариант когда в массиве четное кол-во элементов
//б) вариант когда в массиве и четное и не четное кол-во элементов

// А) Вариант когда в массиве четное кол-во элементов
/*
System.Console.Write("Введите количество элементов в массиве:");
int N=Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
Random random=new Random();
for (int i=0;i<N;i++)
{
    a[i]=random.Next(1,11);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
int[] b=new int[N/2];
for (int i=0;i<N/2;i++)
{
    b[i]=a[i]*a[N-i-1];
    System.Console.Write($"{b[i]} ");
}
*/


// Б) Вариант когда в массиве и четное и не четное кол-во элементов
System.Console.Write("Введите количество элементов в массиве:");
int N=Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
Random random=new Random();
for (int i=0;i<N;i++)
{
    a[i]=random.Next(1,11);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
if (N%2==0) //решение с четным количеством элементов в массиве
{
    int[] b=new int[N/2];
    for (int i=0;i<N/2;i++)
    {
        b[i]=a[i]*a[N-i-1];
        System.Console.Write($"{b[i]} ");
    }
}
else //решение с нечетным количеством элементов в массиве
{
    int[] b=new int[N/2+1];
    for (int i=0;i<N/2;i++) 
    {
        b[i]=a[i]*a[N-i-1];
    } 
    b[N/2]=a[N/2];
    for (int i=0;i<N/2+1;i++)
    {
        System.Console.Write($"{b[i]} ");
    }
}
