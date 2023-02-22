// Задача 38: 
//     Задайте массив ВЕЩЕСТВЕННЫХ чисел. 
//     Найдите разницу между максимальным и минимальным элементов массива.
//         [3 7 22 2 78] -> 76

double[] GetDoubleArray(int sise, int min, int max)
{
    double[] array = new double[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(min, max) + Math.Round(new Random().NextDouble(), 2);
    return array;
}

void PrintDoubleArray(double[] array)
{
    System.Console.WriteLine($"[{string.Join(";  ", array)}]");
}

void MaxMin(double[] array, out int min, out int max)
{
    min = 0; 
    max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min])
            min = i;
        else if (array[i] > array[max])
            max = i;
    }
}

double[] mas = GetDoubleArray(new Random().Next(5, 20), 0, 100500);
PrintDoubleArray(mas);
MaxMin(mas, out int min, out int max);
System.Console.WriteLine($"MIN идёт под № {min + 1} = {mas[min]}");
System.Console.WriteLine($"MAX идёт под № {max + 1} = {mas[max]}");
System.Console.WriteLine($"{mas[max]} - {mas[min]} = {mas[max] - mas[min]}"); 