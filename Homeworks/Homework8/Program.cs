// ________________________________________
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// ________________________________________
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

int[,] SortingArraysRowsDown(int[,] array)
{
    int tmp,
        alength = array.GetLength(1),
        blength = array.GetLength(0),
        i, j, k;

    for (k = 0; k < blength; k++)
        for (i = 0; i < alength; i++)
        {
            for (j = i + 1; j < alength; j++)
            {
                if (array[k, i] < array[k, j])
                {
                    tmp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = tmp;
                }
            }
        }
    return array;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: 0");
int min = 0;
Console.WriteLine("Введите максимальное значение: 9");
int max = 9;
int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
myArray = SortingArraysRowsDown(myArray);
Show2DArray(myArray);
*/
// ________________________________________
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// ________________________________________
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

int NumberOfRowWithMinSum(int[,] array)
{
    int n, tmp = 0,                   // вспомогательные переменные   
        alength = array.GetLength(1), // количество элементов в строке (столбцов)
        blength = array.GetLength(0), // количество строк
        i, j;                         // счётчики
    int[] newArray = new int[blength];// суммы строк складываем в одномерный массив

    for (i = 0; i < blength; i++)
    {
        newArray[i] = 0;
        for (j = 0; j < alength; j++)
        {
            newArray[i] += array[i, j];
        }
    }

    n = newArray[0];
    Console.Write ("Строка[0]="+newArray[0]+" | ");
    for (i = 1; i < blength; i++)
    {
        Console.Write ("Строка["+i+"]="+newArray[i]+" | ");

        if (n > newArray[i])
        {
            n = newArray[i];
            tmp = i;
        }
    }
    Console.WriteLine();

    return tmp;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: 0");
int min = 0;
Console.WriteLine("Введите максимальное значение: 9");
int max = 9;
int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
Console.Write("Наименьшая сумма элементов в "+NumberOfRowWithMinSum(myArray)+" строке");
*/
// ________________________________________
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// ________________________________________
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

int[,] MultiplyMatrix(int[,] array1, int[,] array2, int n)
{
    int i, j;                         // счётчики
    for (i = 0; i < n; i++)
        for (j = 0; j < n; j++)
            array1[i, j] *= array2[i, j];
    return array1;
}

Console.Write("Введите размер матриц: ");
int m = Convert.ToInt32(Console.ReadLine());
//int n = m;
Console.WriteLine("Введите минимальное значение: 0");
int min = 0;
Console.WriteLine("Введите максимальное значение: 3");
int max = 3;
int[,] myArray1 = CreateRandom2DArray(m, m, min, max);
int[,] myArray2 = CreateRandom2DArray(m, m, min, max);
Console.WriteLine("Первая матрица:");
Show2DArray(myArray1);
Console.WriteLine("Вторая матрица:");
Show2DArray(myArray2);
Console.WriteLine("Произведение двух матриц:");
Show2DArray(MultiplyMatrix(myArray1,myArray2,m));
*/
// ________________________________________
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// ________________________________________
/*
int[,,] Fill3dArray(int[,,] array)
{
    int tmp = 10,
        i, j, k;
    for (i = 0; i < array.GetLength(0); i++)
        for (j = 0; j < array.GetLength(1); j++)
            for (k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = tmp;
                tmp++;
            }
    return array;
}

void Show3dArray(int[,,] array)
{
    int i, j, k;
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            for (k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте параметры 3-х-мерного массива.");
Console.WriteLine("Общее количество элементов в массиве не должно превышать 90.");
Console.WriteLine("Например: 3 х 3 х 10");
Console.Write("Введите количество таблиц в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк в таблице: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов таблице: ");
int o = Convert.ToInt32(Console.ReadLine());
int[,,] myArray = new int[m, n, o];
myArray = Fill3dArray(myArray);
Show3dArray(myArray);
*/
// ________________________________________
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// ________________________________________

void Show2DArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
            Console.Write(array[i, k] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

string[,] Fill2dArrayAsSnake(string[,] array, int n)
{
    int i,      // счётчик
        x1=0,   // координаты (первая строка)
        x2=n-1, // координаты (последняя строка)
        y1=0,   // координаты (первый столбец)
        y2=n-1, // координаты (последний столбец)
        tmp=1;  // счётчик-наполнитель
    
    while (tmp<=n*n)
    {
        for (i=y1; i<=y2; i++) 
        {
            array[x1,i]=Convert.ToString(tmp);
            if (tmp<10) array[x1,i] = "0" + array[x1,i];
            tmp++;
        }
        x1++;
        for (i=x1; i<=x2; i++)
        {
            array[i,y2]=Convert.ToString(tmp);
            if (tmp<10) array[i,y2] = "0" + array[i,y2];
            tmp++;
        }
        y2--;
        for (i=y2; i>=y1; i--)
        {
            array[x2,i]=Convert.ToString(tmp);
            if (tmp<10) array[x2,i] = "0" + array[x2,i];
            tmp++;
        }
        x2--;
        for (i=x2; i>=x1; i--)
        {
            array[i,y1]=Convert.ToString(tmp);
            if (tmp<10) array[x2,i] = "0" + array[x2,i];
            tmp++;
        }
        y1++;
    }
    Console.WriteLine();
    return array;
}

Console.Write("Задайте размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
string[,] myArray = new string[n, n];
myArray = Fill2dArrayAsSnake(myArray,n);
Show2DArray(myArray);