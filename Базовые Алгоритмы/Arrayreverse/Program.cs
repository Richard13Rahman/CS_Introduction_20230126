//Инверсия массива
// 32719
// 91723

int[] a={3, 2, 7, 1, 9};

int t;
for(int i=0;i<a.Length/2;i++)
{
t=a[i];
a[i]=a[a.Length-i-1];
a[a.Length-i-1]=t;
}

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");