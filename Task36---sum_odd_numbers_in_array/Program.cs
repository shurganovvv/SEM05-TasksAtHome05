﻿// Задача 36: Задайте одномерный 
//     массив, заполненный случайными числами. 
//     Найдите сумму элементов, 
//         стоящих на нечётных позициях.
//             [3, 7, 23, 12] -> 19
//             [-4, -6, 89, 6] -> 0

int[] GetArray(int sise, int min, int max)
{
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}


int[] mas = GetArray(new Random().Next(3, 11), -99, 99);
PrintArray(mas);
System.Console.WriteLine(SumOddIndex(mas));