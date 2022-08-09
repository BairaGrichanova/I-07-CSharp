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

// Задача 2. 