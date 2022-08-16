// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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