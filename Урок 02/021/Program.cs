//21. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
System.Console.Write("Введите номер дня недели:");
int day=Convert.ToInt32(Console.ReadLine());
if (day==6 || day==7) System.Console.Write("Введённый номер является выходным");
else
    if (day>=1 && day<=5) System.Console.Write("Введённый номер не является выходным");
        else
            System.Console.Write("Вы указали неверный номер денm недели");
