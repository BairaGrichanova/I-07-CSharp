
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
    Console.WriteLine();
}

int[,] ChangeRowsColumns(int[,] array)
{
    int temp = 0;
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
    }
    return array;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
myArray = ChangeRowsColumns(myArray);
Show2DArray(myArray);
*/

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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
    Console.WriteLine();
}

int[,] DeleteRowsColumns(int[,] array)
{
    int min = array[0, 0],
        t1 = 0, // i
        t2 = 0, // j
        a = 0,  // i
        b = 0;  // j
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                t1 = i;
                t2 = j;
            }
        }

    Console.WriteLine("Массив["+t1 + "," + t2 + "]=" + min);
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        if (i == t1) a = 1;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (j >= t2) b = 1;
            newArray[i, j] = array[i + a, j + b];
            b = 0;
        }
    }
    return newArray;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
myArray = DeleteRowsColumns(myArray);
Show2DArray(myArray);