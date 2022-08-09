Console.Write ("Введите целое число: ");
int num = Convert.ToInt32 (Console.ReadLine ());
int even = num%2;
if (even==0) Console.Write ("Вы ввели чётное число");
else         Console.Write ("Вы ввели нечётное число");