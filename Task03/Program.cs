﻿// программа которая задаёт массив из 8 элементов и выводит их на экран

int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 20);

    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }
}
int[] arr = CreateArray();
PrintArray(arr);