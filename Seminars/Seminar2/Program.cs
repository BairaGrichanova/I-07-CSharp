// Задача 1. Напишите программу, которая выводит случайное 
//число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int des = number / 10;
    if (ed > des) return(ed);
    else return(des);
}

int rand = new Random().Next (10,100);

Console.WriteLine("Случайное двухзначное число: "+rand);
Console.WriteLine ("Наибольшая цифра в числе, это: "+FindBiggerDigit(rand));
*/


// Задача 2. Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.
/*
int CutTwoNumber (int number)
{
    int ed = number % 10;
    int sot = number / 100;
    int result = sot * 10 + ed;
    return(result);
}

int rand = new Random().Next (100,1000);

Console.WriteLine("Случайное трёхзначное число: "+rand);
Console.WriteLine ("Убираем вторую цифру в числе: "+CutTwoNumber(rand));
*/


// Задача 3. Напишите программу, которая будет принимать на вход 
//два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит 
//остаток от деления.
/*
void Example3 (int num1, int num2)
{
    int ost = num2 % num1;
    if (ost == 0) Console.WriteLine ($"{num2} кратно {num1}");
    else Console.WriteLine ($"{num2} не кратно {num1}. Остаток деления: {ost}");
}
Console.Write ("Введите первое число: ");
int n1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите второе число: ");
int n2 = Convert.ToInt32 (Console.ReadLine ());
Example3 (n1,n2);
*/

// Задача 4. Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.

bool Example4 (int number)
{
//    if (number%7==0 && number%23==0) return true;
//    else return false;
    return number%7==0 && number%23==0;
}

Console.Write ("Введите целое число: ");
int n = Convert.ToInt32 (Console.ReadLine ());
bool result = Example4(n);
Console.WriteLine(result);