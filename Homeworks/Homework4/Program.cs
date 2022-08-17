// Task 25. Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

long Stepen (int n, int x)
{
    long s=1;
    for (int i=1; i<=x; i++) s = s*n;
    return s;
}

Console.WriteLine ("Программа возведения числа в степень.");
Console.Write ("Введите число (А): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите степень (В): ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Число {a} в степени {b} будет равно {Stepen (a,b)}");