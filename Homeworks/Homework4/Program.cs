// Task 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
/*
long Stepen (int n, int x)
{
    long s=1;
    for (int i=1; i<=x; i++) s *= n;
    return s;
}

Console.WriteLine ("Программа возведения числа в степень.");
Console.Write ("Введите число (А): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите степень (В): ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Число {a} в степени {b} будет равно {Stepen (a,b)}");
*/

// Task 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumber (int n)
{
    int sum = 0;

    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

Console.WriteLine ("Программа подсчёта суммы цифр в числе.");
Console.Write ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Сумма цифр в числе {number} будет равна {SumNumber (number)}");
*/

// Task 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Свой вариан метода CreateArray, произвольный размер массива

int[] CreateArray (int size)
{
    int[] newArray = new int[size];

    for (int i=0; i<size; i++) 
    {
        Console.Write ($"ARRAY[{i}]=");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray (int[] array)
{
Console.Write ("Наш массив: ");
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + " ");
    
Console.WriteLine();
}

Console.Write ("Введите количество элементов в массиве ARRAY[]: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray (a);

ShowArray(myArray);