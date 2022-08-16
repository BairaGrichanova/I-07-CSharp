// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Task19(int number)
{
    bool rezult = false;

    int n1 = number % 10;
    int n2 = number / 10000;
    number = number % 10000 / 10;

    if (n1 == n2)
    {
        n1 = number % 10;
        n2 = number / 100;
        if (n1 == n2) rezult = true;
    }

    return rezult;
}

Console.Write("Введите целое пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (Task19(n)) Console.Write("Полиндром");
else Console.Write("Не полиндром");
*/

// Task 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance (int x1, int x2, int y1,int y2,int z1,int z2)
{
    double r = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return r;
}

Console.WriteLine ("Введите координаты двух точек в трёхмерном пространстве.");
Console.Write ("Введите координаты первой точки - X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты первой точки - Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты первой точки - Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты второй точки - X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты второй точки - Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты второй точки - Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Расстояние между двумя точками - "+Distance(x1,x2,y1,y2,z1,z2));
*/

// Task 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
long Kub (long x)
{
    return x*x*x;
}

Console.Write ("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=n; i++) Console.WriteLine (Kub(i));
*/