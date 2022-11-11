// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void CreateArray(double[] arr) 
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(random.Next(-100, 101)) / 10; 
    }
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(",");
    }
    Console.WriteLine("]");
}

double MaxElement (double[] arr)
{
    double maxEl = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxEl)
        {
            maxEl = arr[i];
        }
    }
    return maxEl;
}

double MinElement (double[] arr)
{
    double minEl = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minEl)
        {
            minEl = arr[i];
        }
    }
    return minEl;
}

double DiffMaxMin (double[] arr, double maxEl, double minEl)
{
    double diff = Math.Round((maxEl - minEl) , 2);
    return diff;
}

double[] array = new double[10];
CreateArray(array);
PrintArray(array);
double maxElement = MaxElement(array);
double minElement = MinElement(array);
Console.WriteLine($"Разница между максимальным ({maxElement}) и минимальным ({minElement}) элементами массива: {DiffMaxMin(array, maxElement, minElement)}");