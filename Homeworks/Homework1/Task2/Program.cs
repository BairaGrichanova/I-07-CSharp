Console.Write ("Введите значение А: ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите значение Б: ");
int b = Convert.ToInt32 (Console.ReadLine ());

if ( a > b )  Console.Write ("Число "+a+" больше, чем число "+b);
if ( a < b )  Console.Write ("Число "+a+" меньше, чем число "+b);
if ( a == b ) Console.Write ("Число "+a+" равно числу "+b);