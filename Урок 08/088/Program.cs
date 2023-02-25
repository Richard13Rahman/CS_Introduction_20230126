//88. Заменить все вхождения подстроки w в строке st на строку v. 
//Вывести на экран первоначальную строку и конечную строку
string st="Доброе утро! утро, а потом снова утро? Ух ты! Ещё утро!";
string w="утро";
string v="ночь";
int i=0;
System.Console.WriteLine(st);
while (st.IndexOf(w)>0)
{
i=st.IndexOf(w);
st=st.Remove(st.IndexOf(w),w.Length);
st=st.Insert(i,v);
}
System.Console.WriteLine(st);
System.Console.WriteLine();

//Метод замены Replace прекрасно справляется! (Я его нашел в интернете, после того как уже сделала решение выше)
st="Доброе утро! утро, а потом снова утро? Ух ты! Ещё утро!";
System.Console.WriteLine(st);
st=st.Replace(w,v);
System.Console.WriteLine(st);