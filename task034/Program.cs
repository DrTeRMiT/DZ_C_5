// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void CreateArray(int[] arr) 
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000); 
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(",");
    }
    Console.WriteLine("]");
}

int EvenNumbers(int[] arr) 
{
    int count = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        {
            count++;
        }
    }

    return count;
}

int[] array = new int[10];
CreateArray(array);
PrintArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {EvenNumbers(array)}");