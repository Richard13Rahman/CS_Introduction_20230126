//
int a;
bool f;
do
{
    System.Console.Write("Введите число:");
    f=int.TryParse(Console.ReadLine(), out a);
}
while(f==false);
System.Console.WriteLine(a);


/*
try
{
    int a=Convert.ToInt32(Console.ReadLine());
}
catch
{
    System.Console.WriteLine("Error!");
}
*/
