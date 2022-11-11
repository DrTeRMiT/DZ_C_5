// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void CreateArray(int[] arr) 
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-100, 101); 
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

int SumOddIndex (int[] arr) 
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}


int[] array = new int[10];
CreateArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях: {SumOddIndex(array)}");