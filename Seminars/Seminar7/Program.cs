// first Task. Заполнить двумерный массив случайными целыми числами
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
*/

// Задать двумерный массив по формуле
//a[i,j]=i+j
/*
int[,] Create2DArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int k = 0; k < columns; k++)
            newArray[i, k] = i+k;
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

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(m, n);
Show2DArray(myArray);
*/

// Задать двумерный массив, найти элементы, у которых оба индекса чётные, и возвести эти элементы в квадрат

// Необходимо задать двумерный массив и найти сумму элементов на главной диагонали (индексы совпадают)