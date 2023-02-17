// Посчитать среднюю температуру за неделю
/*
//Решениме задачи без массива
double t1,t2,t3,t4,t5,t6,t7;
t1=Convert.ToDouble(Console.ReadLine());
t2=Convert.ToDouble(Console.ReadLine());
t3=Convert.ToDouble(Console.ReadLine());
t4=Convert.ToDouble(Console.ReadLine());
t5=Convert.ToDouble(Console.ReadLine());
t6=Convert.ToDouble(Console.ReadLine());
t7=Convert.ToDouble(Console.ReadLine());
double sr=(t1+t2+t3+t4+t5+t6+t7)/7;
System.Console.WriteLine(sr);
*/

//Решение задачи используя массив
double[] temps=new double[7];
for (int i=0;i<temps.Length;i++)//temps.Length - это длинна массива (в данном случае 7)
{    
    System.Console.Write($"Введите температуру {i+1} дня:");
    temps[i]=Convert.ToDouble(Console.ReadLine());
}
double s=0;
for (int i=0;i<temps.Length;i++)
{    
    s=s+temps[i];
}
System.Console.Write(s/temps.Length);
