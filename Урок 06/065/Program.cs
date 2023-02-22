//65.  Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. 
//Если элемент отсутствует, подпрограмма возвращает false, а если найдет, то true.
System.Console.Write("Введите количество строк массива:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество стобцов массива:");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число которую нужно найти в двухмерном массиве:");
int x=Convert.ToInt32(Console.ReadLine());

int[,] a=Random_2D_array(m,n,0,20);
System.Console.WriteLine($"Двухмерный массив размером {m}х{n} имеет следующий вид:");
Print_2D_array(a);
int r,c;
if (Find_element_in_2d_array(a,x, out r,out c))
    System.Console.WriteLine($"Число {x} в массиве обнаружен: ряд={r+1} колонка={c+1}");//Добавил (+1) для удобства подчета пользователям. Дюди же считать с 1 а не с 0 :)
else
    System.Console.WriteLine("Число {x} в массиве не обнаружен");

int[,] Random_2D_array(int M, int N, int min, int max)
{
    int[,] a=new int[M,N];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

void Print_2D_array(int[,] a)
{
     for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],5}");
        System.Console.WriteLine();
    };
}

bool Find_element_in_2d_array(int[,] a,int find,out int row,out int column)
{
    row=-1;
    column=-1;
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            if (a[i,j]==find)
            {
                row=i;
                column=j;
                return true;
            }
    return false;
}