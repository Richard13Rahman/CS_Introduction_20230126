//84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
//Вычислить сумму цифр введенного числа
System.Console.Write($"Введите символы:");
string s=Console.ReadLine();
int n, sum=0;
if (int.TryParse(s, out n))//нашел в интернете
    System.Console.WriteLine($"Введенные символы являются записью целго числа и их сумма равна:{Sum(n)}");
else 
    System.Console.WriteLine("Введенные символы не являются записью целго числа");

/* Способ решения задачи без TryParse
int k=0;
for(int i=0;i<s.Length;i++)
{
    if (s[i]>='0' && s[i]<='9') k++;
}
n=Convert.ToInt32(s);
if (k==s.Length) System.Console.WriteLine($"Введенные символы являются записью целго числа и их сумма равна:{Sum(n)}");
else System.Console.WriteLine("Введенные символы не являются записью целго числа");
*/


int Sum(int n)
{
    while (n!=0)
    {
        sum=sum+n%10;
        n/=10;
    }
    return sum;
}
