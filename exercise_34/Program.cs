// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray()
{
    int[] Array = new int[new Random().Next(3,11)];
    
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(99,1000);
    }
    return Array;
}

int EvenCalculus(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i]%2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Amount of even numbers in array is: {count}");
    return count;
}

EvenCalculus(RandomArray());