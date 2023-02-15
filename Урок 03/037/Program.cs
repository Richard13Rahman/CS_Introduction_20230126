//37. Компьютер придумывает число и определеяет заканчивается ли на четную цифру куб этого числа 
Random random=new Random();
for(int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (b%2==0)
        System.Console.WriteLine($"{a}, {b}");
}

/*
//объект для генерации случайного числа
Random random=new Random(10);
Random random1=new Random(10);
Random random2=new Random(120);
System.Console.WriteLine(random.Next(1,100));
System.Console.WriteLine(random1.Next(1,100));
System.Console.WriteLine(random2.Next(1,100));
генерация чисел зависит от введеного числа и по алгоритму выбирает ячисло. Оно будет повторятся, так как внешнее значения не поменялись
*/
