// Найти сумму чисел от 1 до А
/*
int FindSum (int number)
{
    int sum = 0;

    for (int current = 1; current <= number; current++)
    {
        //sum = sum + current;
        sum += current;
    }

    return sum;
}

Console.Write ("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine ($"Сумма чисел от 1 до {a} будет {result}");
*/

// Задача 1. Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
/*
int Number (int n)
{
    int count = 1;
    if (n<0) n*=(-1);
    while (n>10)
    {
        n = n / 10;
        count++;
    }
    return count;
}

Console.Write ("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ($"В числе: {a} {Number(a)} цифр");
*/

// Задача 2. Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
/*
int FindSum (int number)
{
    int sum = 1;

    for (int current = 1; current <= number; current++)
    {
        //sum = sum * current;
        sum *= current;
    }

    return sum;
}

Console.Write ("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine ($"Произведение чисел от 1 до {a} будет {result}");
*/

// Задача 3. Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.


