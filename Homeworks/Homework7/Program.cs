// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CreateRandomDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    int r=0;
    for (int i = 0; i < rows; i++)
        for (int k = 0; k < columns; k++)
        {
            r = new Random().Next(minValue,maxValue);
            newArray[i, k] = r * (new Random().NextDouble());
        }
    return newArray;
}
void ShowDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
            Console.Write(Math.Round (array[i, k],1) + " ");
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandomDoubleArray(m, n, min, max);
ShowDoubleArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int k = 0; k < columns; k++)
            newArray[i, k] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
            Console.Write(array[i, k] + " ");
        Console.WriteLine();
    }
}
void SearchByCoordinates (int[,] array, int i, int k)
{
    if (i<array.GetLength(0) && k<array.GetLength(1))
        Console.Write("На указанной позиции располагается число: "+array[i, k]);
    else
        Console.Write("Такой позиции в нашей матрице не имеется");
}

int m = 10,
    n = 10,
    min = -10,
    max = 10;
int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);

Console.Write("Введите № строки для поиска элемента: ");
int f1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца для поиска элемента: ");
int f2 = Convert.ToInt32(Console.ReadLine());

SearchByCoordinates(myArray,f1,f2);
*/
