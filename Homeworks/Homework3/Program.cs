// Задача 1. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

void DiapCoordin (int x)
{
    if (x==1) Console.WriteLine ("x>0 и y>0");
    if (x==2) Console.WriteLine ("x<0 и y<0");
    if (x==3) Console.WriteLine ("x<0 и y>0");
    if (x==4) Console.WriteLine ("x>0 и y<0");
}

Console.WriteLine ("Введите четверть 1-4: ");
int qart = Convert.ToInt32 (Console.ReadLine());
DiapCoordin (qart);