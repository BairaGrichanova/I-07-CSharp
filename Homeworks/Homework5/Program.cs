//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray (int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];

    for (int i=0; i<size; i++) newArray[i] = new Random().Next(minVal,maxVal + 1);
    return newArray;
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + " ");
    
Console.WriteLine();
}
int FindEvenNumber(int[] array)
{
    int k=0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2==0) k++;
        }
    return k;
}

Console.WriteLine ("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона (от 100) ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона (до 999) ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Количество чётных чисел в массиве {FindEvenNumber(myArray)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray (int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];

    for (int i=0; i<size; i++) newArray[i] = new Random().Next(minVal,maxVal + 1);
    return newArray;
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + " ");
    
Console.WriteLine();
}
int SumEvenNumber(int[] array)
{
    int k=0;
    for (int i = 1; i < array.Length; i+=2)
        {
            k+=array[i];
        }
    return k;
}

Console.WriteLine ("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Сумма чисел на нечётных позициях: {SumEvenNumber(myArray)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] CreateRandomArray (int size, int minVal, int maxVal)
{
    double[] newArray = new double[size];

    for (int i=0; i<size; i++) newArray[i] = new Random().Next(minVal,maxVal + 1);
    return newArray;
}
void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + " ");
    
Console.WriteLine();
}
double FindMinNumber(double[] array)
{
    double k=array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i]<k) k=array[i];
        }
    return k;
}
double FindMaxNumber(double[] array)
{
    double k=array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i]>k) k=array[i];
        }
    return k;
}

Console.WriteLine ("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Разница между максимальным ({FindMaxNumber(myArray)}) и минимальным ({FindMinNumber(myArray)}) значениями: {FindMaxNumber(myArray)-FindMinNumber(myArray)}");
