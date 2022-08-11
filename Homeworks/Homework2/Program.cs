// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void Task10 (int number)
{
    int result = number % 100 / 10;
    Console.WriteLine (result);
}

Console.Write ("Введите трёхзначное число: ");
int n = Convert.ToInt32 (Console.ReadLine ());

Task10 (n);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void Task13 (long number)
{
    if (number < 0) number = number * (-1);
    long result = 0;
    long razr = 100;
    if (number < 100) Console.WriteLine ($"Введённое число: {number}, третьей цифры в числе нет");
    else 
    {
        while (razr < number) 
        {
            if (number < razr*10) result = number % (razr/10) / (razr/100);
            razr = razr * 10;
        }
        Console.WriteLine ("Третья цифра в числе: "+result);
    }
}

Console.Write ("Введите целое число: ");
long n = Convert.ToInt64 (Console.ReadLine ());

Task13 (n);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Task15 (int numberDay)
{
    if (numberDay < 6) Console.WriteLine ("Пора на работу");
    else Console.WriteLine ("Выходной");
}

Console.Write ("Введите день недели (число от 1 до 7): ");
int n = Convert.ToInt32 (Console.ReadLine ());

Task15 (n);
*/