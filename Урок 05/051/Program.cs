//51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

System.Console.Write("Введите колличество необходимых для ввода чисел:");
int N=Convert.ToInt32(Console.ReadLine());
int k=0;
Positive(N);

void Positive(int a)
{
    for(int i=0;i<a;i++)
    {
        System.Console.Write($"Введите {i+1} число:");
        int n=Convert.ToInt32(Console.ReadLine());
        if (n>0) k++;
    }
    System.Console.WriteLine($"Количество положительных чисел:{k}");
}

/*
//Пишем по старой версии как было в версии NET.5
namespace Binataliev_GeekBrains
{
    namespace Introduction
    {
        class Task051
        {
            static void Main()
            {
                System.Console.WriteLine("Введите число длинны массива, затем его значения:");
                int N=Convert.ToInt32(Console.ReadLine());
                int k=0;
                for(int i=0;i<N;i++)
                {
                    int n=Convert.ToInt32(Console.ReadLine());
                    if (n>0) k++;
                }
                System.Console.WriteLine($"Количество положительных чисел:{k}");
            }
        }
    }
}
*/