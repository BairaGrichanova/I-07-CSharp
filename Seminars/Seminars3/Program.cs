// Задача 1. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void DiapCoordin (int x)
{
    if (x==1) Console.WriteLine ("x>0 и y>0");
    if (x==2) Console.WriteLine ("x<0 и y<0");
    if (x==3) Console.WriteLine ("x<0 и y>0");
    if (x==4) Console.WriteLine ("x>0 и y<0");
}

Console.WriteLine ("Введите четверть 1-4: ");
int qart = Convert.ToInt32 (Console.ReadLine());
if (qart>0 && qart<5) DiapCoordin (qart); else Console.WriteLine ("ошибка");
*/
// Задача 3. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
/*
double LengthT (int x1, int y1, int x2, int y2)
{

    double rezult = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    return rezult;

}

Console.WriteLine ("Введите координаты двух точек");
Console.WriteLine ("Введите x1: ");
int x11 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите y1: ");
int y11 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите x2: ");
int x22 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите y2: ");
int y22 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine (LengthT(x11,y11,x22,y22));
Convert.ToDouble;
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) 
// и выдаёт на консоль квадраты чисел от 1 до N.

void kvadrat (int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine ($"{i} в квадрате будет равно {i*i}");
    }
}

Console.WriteLine ("Введите число N: ");
int num = Convert.ToInt32 (Console.ReadLine());
kvadrat (num);




