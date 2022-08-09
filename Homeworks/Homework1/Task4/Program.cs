Console.Write ("Введите значение А: ");
int max = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите значение Б: ");
int b = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите значение В: ");
int c = Convert.ToInt32 (Console.ReadLine ());
if ( b > max ) max = b;
if ( c > max ) max = c;
Console.Write ("Самое большое число из 3-х введённых, это: "+max);