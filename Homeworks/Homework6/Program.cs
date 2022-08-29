// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3    :)
/*
int[] FillArray (int[] myArray)
{
    for (int i=0; i<myArray.Length; i++)
    {
        Console.Write ($"Введите {i+1}-е число: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}

int СountPositive (int[] myArray)
{
    int k=0;
    for (int i=0; i<myArray.Length; i++)
        if (myArray[i]>0) k++;
    return k;
}

Console.WriteLine ("Введите с клавиатуры M чисел.");
Console.Write ("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
array=FillArray(array);
Console.Write ($"Среди {m} введённых чисел, {СountPositive(array)} чисел больше 0");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection (double[] myArray)
{
    myArray[4]=(myArray[3]-myArray[2])/(myArray[0]-myArray[1]);
    myArray[5]=myArray[0]*myArray[4]+myArray[2];
}

double[] mas = new double[6];
Console.WriteLine ("1) y = k1 * x + b1        2) y = k2 * x + b2");
Console.Write ("Введите число k1: ");
mas[0] = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите число k2: ");
mas[1] = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите число b1: ");
mas[2] = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите число b2: ");
mas[3] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ($"1) y = {mas[0]} * x + {mas[2]}        2) y = {mas[1]} * x + {mas[3]}");
Intersection (mas);
Console.WriteLine ($"Эти 2 прямые пересекаются в точке ({mas[4]}; {mas[5]})");
