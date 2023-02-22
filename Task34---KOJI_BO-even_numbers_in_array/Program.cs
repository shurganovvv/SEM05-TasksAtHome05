// Задача 34: Задайте 
//     массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая 
//     покажет количество чётных чисел в массиве.
//         [345, 897, 568, 234] -> 2

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

int EvenNubber(int[] array)
{
    int nubbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            nubbers++;
    }
    return nubbers;
}


int[] mas = GetArray(7, 100, 999);
PrintArray(mas);
System.Console.WriteLine(EvenNubber(mas));