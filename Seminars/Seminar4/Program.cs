// Найти сумму чисел от 1 до А

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

