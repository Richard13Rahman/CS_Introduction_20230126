/*
//Задача на определение месяца года.
System.Console.Write("Введите число месяца года:");
int month=Convert.ToInt32(Console.ReadLine());
// Как вводили раньше
if (month==1) System.Console.WriteLine("Зима");
if (month==2) System.Console.WriteLine("Зима");
if (month==12) System.Console.WriteLine("Зима");
// Используя 'или' как ||
if (month==3 || month==4 || month==5) System.Console.WriteLine("Весна");
if (month==6 || month==7 || month==8) System.Console.WriteLine("Лето");
if (month==9 || month==10 || month==11) System.Console.WriteLine("Осень");
*/

//Задача на возвраст человека, подходит ли он для работы (от 25 до 45 лет).
/*
System.Console.Write("Введите возвраст человека:");
int age=Convert.ToInt32(Console.ReadLine()); 
//Програмирование лесенкой (Версия рабочая, но не подходит для больших программ).
if (age>=25)
    if (age<=45)
        System.Console.WriteLine("Подходит");
    else 
        System.Console.WriteLine("Не подходит");
else 
    System.Console.WriteLine("Не подходит");
*/

//Используем 'и' как &&
System.Console.Write("Введите возвраст человека:");
int age=Convert.ToInt32(Console.ReadLine());
if (age>=25 && age<=45)//Ленивый 'и' Использования двух символов '&&' означает что при первом ложном условии он не будет роверять второе. 
//Если использовать один символ '&' то код проверит оба условия
    System.Console.WriteLine("Подходит");
else 
    System.Console.WriteLine("Не подходит");
