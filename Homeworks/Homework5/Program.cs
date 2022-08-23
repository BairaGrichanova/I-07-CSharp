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


