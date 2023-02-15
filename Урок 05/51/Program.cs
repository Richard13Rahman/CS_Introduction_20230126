//51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
//Пишем по старой версии как было в версии NET.5

namespace Binataliev_GeekBrains
{
    namespace Introduction
    {
        class Task051
        {
            static void Main()
            {
                int N=Convert.ToInt32(Console.ReadLine());
                int k=0;
                for(int i=0;i<N;i++)
                {
                    int n=Convert.ToInt32(Console.ReadLine());
                    if (n>0) k++;
                }
                System.Console.WriteLine(k);
                Binataliev_GeekBrains.Introduction.Task051.Main();
            }
        }
    }
}
