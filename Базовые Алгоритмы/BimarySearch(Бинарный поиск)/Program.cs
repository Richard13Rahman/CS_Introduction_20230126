//Бинарный поиск

int f=20;
int[] a=RandomintArray(20,0,100);
PrintArray(a);
Array.Sort(a);//Сортировка массива
PrintArray(a);
System.Console.WriteLine(BinSearch(a,f));


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

int BinSearch(int[] arr,int find)
{
    int i;
    int left=0;
    int right=arr.Length-1;
    i=left+(right-left)/2;
    while(arr[i]!=find && left<right)
    {
        if (find>arr[i])
        {
            left=i+1;
        }
        else
        {
            right=i;
        }
        i=left+(right-left)/2;
    }
    if (arr[i]!=find) return -1;
    else return i;
}