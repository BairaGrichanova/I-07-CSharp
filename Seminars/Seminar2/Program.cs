// Задача 1. Напишите программу, которая выводит случайное 
//число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int des = number / 10;
    if (ed > des) return(ed);
    else return(des);
}

int rand = new Random().Next (10,99);

Console.WriteLine(rand);
Console.WriteLine (FindBiggerDigit(rand));