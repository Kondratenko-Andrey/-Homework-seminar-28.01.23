// Написать программу копирования массива

void FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-5, 10);
    }

}

void PrintArr(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

int[] CopyArr(int[] arr)
{
    int[] arr_copy = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        arr_copy[i] = arr[i];
    }

    return arr_copy;

}

int[] first_array = new int[10];

FillArr(first_array);

Console.WriteLine($"Нам дан массив № 1 из {first_array.Length} элементов:");

PrintArr(first_array);

int[] second_array = CopyArr(first_array);

Console.WriteLine("В результате копирования мы создали копию первого массива и получили массив № 2:");

PrintArr(second_array);