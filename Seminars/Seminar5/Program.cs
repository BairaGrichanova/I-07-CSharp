// Example 1. Сумма отрицательных и положительных чисел массива
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
void FindMinMaxSum(int[] array)
{
    int sumP = 0;
    int sumM = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>0) sumP += array[i];
            else sumM += array[i];
        }
    Console.WriteLine ($"Сумма отрицательных числе равна {sumM}, положительных {sumP}");
}

Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/

// Example 2. Положительные элементы меняем на отрицательные, отрицательные на положтельные
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
void Negative (int[] array)
{
        for (int i = 0; i < array.Length; i++) array[i] *= (-1);
}

Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Negative(myArray);
ShowArray(myArray);
*/

// Example 3. определяет, присутствует ли заданное число в массиве
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
bool FindNumber(int[] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==number) result = true;
        }
    return result;
}

Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число для поиска ");
int num = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
if (FindNumber(myArray,num)) Console.WriteLine ("Число есть");
else Console.WriteLine ("Числа нет");
*/

// Example 4. Массив 12 случайных чисел, кол-во элементов массива от 10 до 99 включительно

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
int FindDoubleNumber(int[] array)
{
    int k=0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>9 && array[i]<100) k++;
        }
    return k;
}

Console.Write ("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение диапазона ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Количество двухзначных чисел в массиве {FindDoubleNumber(myArray)}");
