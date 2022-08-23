// Example 1. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
/*
bool Katet (int a, int b, int c)
{
    bool result=false;
    if (a<b+c) if (b<a+c) if (c<a+b) result=true;
    return result;
}
Console.WriteLine ("Введите длину 3-х сторон треугольника");
Console.Write ("Введите длину первой стороны: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите длину второй стороны: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите длину третий стороны: ");
int z = Convert.ToInt32(Console.ReadLine());

if (FindNoName(a,b,c)) Console.WriteLine ("треугольник");
else Console.WriteLine ("Не треугольник");
*/

// Example 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
// c=b+a
/*
void NFibonacci (int a,  int b, int n)
{
    int c;
    Console.Write (a+" "+b+" ");
    for (int i=2; i<n; i++)
    {
        c = a+b;
        Console.Write (c+" ");
        a=b;
        b=c;
    }
}

Console.WriteLine ("Вывод N чисел фибоначчи");
Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NFibonacci (a,b,n);
*/

// Example 3. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void Convertik (int n)
{
    string s=string.Empty;
    while (n>0)
    {
        s=n%2+s;
        n/=2;
    }
    Console.WriteLine(s);
}

Console.Write ("Введите целое число в десятичной системе исчесления: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write ($"Число {num} в двоичной системе исчесления будет: ");
Convertik (num);


