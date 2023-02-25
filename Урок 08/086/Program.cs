//86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

System.Console.Write("Введите строку(по русски):");
string s=Console.ReadLine();
char c='а';
int k=0,i=0;
for (i=0;i<s.Length;i++)
    if (s[i]==c) k++;
System.Console.WriteLine($"Количество символов {c} равна:{k}");
