// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] RandomArray()
{
    double[] Array = new double[new Random().Next(3,11)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-100,100);
    Console.Write($"{Array[i]} ");
    }
    return Array;
}

void DiffMinMax(double[] Array)
{
    double maxValue = Array.Max();
    double minValue = Array.Min();
    double Diff = Math.Abs(maxValue - minValue);
    Console.WriteLine();
    Console.WriteLine(Diff);
}

DiffMinMax(RandomArray());