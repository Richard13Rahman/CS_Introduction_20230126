//31. Вывести на экран кубы чисел от 1 до N.
System.Console.Write("Введите число N:");
CubeTable(Convert.ToInt32(Console.ReadLine()));
double CubeTable(int N)
{
    for (int i=1;i<=N;i++)
    {
        System.Console.WriteLine($"{i} {Math.Pow(i,3),10}");
    }
return N;
}
//По условию задачи нужно было вывести кубы, но мне больше нравится в виде таблице с числом из которого выведен куб.
