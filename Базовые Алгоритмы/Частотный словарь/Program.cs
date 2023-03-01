// Создать частотный словарь
//Посчитать сколько цифр в массиве

int[] Random_Int_Array(int N, int min, int max)
{
    int[] arr=new int[N];
    Random random=new Random();
    for (int i=0;i<arr.Length;i++)
        arr[i]=random.Next(min,max+1);
    return arr;    
}

void Print_array(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i],5}");
}

int[] a=Random_Int_Array(10,1,5);
Print_array(a);
System.Console.WriteLine();
Dictionary<int, int> dic=new Dictionary<int, int>();
//dic.Add(1,2);
//System.Console.WriteLine(dic[1]);
foreach(int el in a)
    if (dic.ContainsKey(el))
        dic[el]++;
    else
        dic.Add(el,1);
foreach(var el in dic)
    System.Console.WriteLine($"{el.Key}:{el.Value}");