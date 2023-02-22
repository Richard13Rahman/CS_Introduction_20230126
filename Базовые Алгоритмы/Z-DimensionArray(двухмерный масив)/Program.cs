//Двухмернный массив

/*Простой вид
int[,] a=new int[4, 3]; {{1,2,3},
                        {1,2,3},
                        {1,2,3},
                        {1,2,3}
                        }; //Вот так вот будет выглядит
for(int i=0;i<a.GetLength(0);i++)//Длинну тут указывается не так как в одномерном массиве!
    for(int j=0;j<a.GetLength(1);j++)
        a[i,j]=i*10+j;
for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],20}");
        System.Console.WriteLine();
    };        
*/

//С помощью подпрограмм
int[,] a=Random2DArray(4,3,0,20);
Print_2D_Array(a);
int r,c;
if (Find_element_in_2d_array(a,10, out r,out c))
    System.Console.WriteLine($"row={r} column={c}");
else
    System.Console.WriteLine("Element not found");

int[,] Random2DArray(int N, int M, int min, int max)//рандомные числа двухмерного массива
{
    int[,] a=new int[N,M];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

void Print_2D_Array(int[,] a)
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

/*Вроде такой рандом работает! Стоит уточнить у преподавателя
void Random2DArray(int[,] a)
{
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(0,50);
}
*/

//Трехмерный массив
/*
int[,,] a=new int[4,3,3];
for(int k=0;k<a.GetLength(2);k++)
    for(int i=0;i<a.GetLength(0);i++)//Длинну тут указывается не так как в одномерном массиве!
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j,k]=k*100+i*10+j;

for(int k=0;k<a.GetLength(2);k++)
{
    System.Console.WriteLine($"{k+1} таблица");
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j,k],5}");
        System.Console.WriteLine();
    };
};
*/
