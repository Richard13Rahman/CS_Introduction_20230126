//62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
//Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.
System.Console.Write("Введите количество строк массива:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество стобцов массива:");
int n=Convert.ToInt32(Console.ReadLine());

int[,] a=Random_2D_array(m,n,0,20);
System.Console.WriteLine($"Двухмерный массив размером {m}х{n} имеет следующий вид:");
Print_2D_array(a);
System.Console.WriteLine("После изменения некоторых элементов двухмерный массив имеет вид:");
Print_2D_array_modified(a);
System.Console.WriteLine("Для проверки внесенного изменения:");
Print_2D_array(a);//Для проверки выхода изменненого массива в программе

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
    }
}

int[,] Print_2D_array_modified(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            if (a[i,j]%2==0)
            {
                a[i,j]=-a[i,j];
            }
            System.Console.Write($"{a[i,j],5}");
        }
        System.Console.WriteLine();
    }
    return a;
}
/* Что-то я запамятовал в чем разница! И при int и при void в программе происходит замена массива. Надо будет повторить материал и сделать конспект. А так же книжкой обзавестись. Вы были правы! Книга лучший инструмент для поиска подзабытого материала чем видеокурс.
void Print_2D_array_modified(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            if (a[i,j]%2==0)
            {
                a[i,j]=-a[i,j];
            }
            System.Console.Write($"{a[i,j],5}");
        }
        System.Console.WriteLine();
    }
}
*/