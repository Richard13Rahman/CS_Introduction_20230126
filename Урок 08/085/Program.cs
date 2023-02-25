//85. Преобразовать во вводимой с клавиатуры строке строчные латинские буквы в прописные

string s=Console.ReadLine();
/*string s1="";
for(int i=0;i<s.Length;i++)
    if (s[i]>='a' && s[i]<='z')
        s1=s1+char.ToUpper(s[i]);
    else
        s1=s1+s[i];
System.Console.WriteLine(s1);*/

System.Text.StringBuilder sb=new System.Text.StringBuilder(s);//Более верный способ
for(int i=0;i<sb.Length;i++)
  if (sb[i]>='a' && sb[i]<='z')
    sb[i]=char.ToUpper(s[i]);
s=sb.ToString();
System.Console.WriteLine(s);   