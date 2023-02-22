//Сортровкb

int[] a=RandomintArray(6,0,100);
int[] b=new int[a.Length];
Array.Copy(a,b,a.Length);
PrintArray(a);
PrintArray(b);
//Array.Sort(a);//Сортировка массива
int k1=BubbleSort(a);//Пузырьковая сортировка
int k2=SelectSort(b);//Сортировка выбором
PrintArray(a);
PrintArray(b);
System.Console.WriteLine($"Колличество перетсановок в пузырьковой сортировке:{k1}");
System.Console.WriteLine($"Колличество перетсановок в сортировочном выборе:{k2}");

int[] RandomintArray(int N, int min, int max)
{
    int[] a=new int[N];
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
    System.Console.WriteLine();    
}

int BubbleSort(int[] a)//Пузырьковая сортировка(принцип сравнения двух чисел и их перестановки если следующее число меньше предыдущего)
{
    int k=0;
    for(int j=0;j<a.Length;j++)
    {
        for(int i=0;i<a.Length-1;i++)
        {
            if (a[i]>a[i+1])
            {
                int t=a[i];
                a[i]=a[i+1];
                a[i+1]=t;
            }
            k++;
        }
    }
    return k;
}

int SelectSort(int[] a)//Сортировка выбором(принцим сравнения всех чисел с первым числом, постеменно передвигаясь слева)
{
    int k=0;
    for(int j=0;j<a.Length;j++)
    {
        int iM=j;
        for(int i=j+1;i<a.Length;i++)
        {
            if (a[i]<a[iM])
                iM=i;
            k++;
        }
        int t=a[j];
        a[j]=a[iM];
        a[iM]=t;
    }
    return k;
}