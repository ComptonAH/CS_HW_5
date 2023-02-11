// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] RandomArray()
{
    int[] Array = new int[new Random().Next(3,11)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-100,100);
    }
    return Array;
}

void OddSum(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + Array[i];
        }
    }
    Console.WriteLine(sum);
}

OddSum(RandomArray());