// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);

    }
    return array;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double Dif(double[] arrr) 
{
    double min = 0;
    double max = arrr[0];
    double dif = 0;
    for (int i = 0; i < arrr.Length; i++)
    {
        if (min > arrr[i])
        {
            min = arrr[i];
        }

        if (max < arrr[i])
        {
            max = arrr[i];
        }
    }
    dif = max - min;
    return dif;
    
}

double[] arr = CreateArrayRndInt(4 , -30, 40);
PrintArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива --> {Dif(arr)}");