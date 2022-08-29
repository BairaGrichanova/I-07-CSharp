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

