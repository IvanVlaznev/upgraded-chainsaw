// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = new int[8];

void FillArray(int[] array)
{
    int count = array.Length;
    Random rnd = new Random();
    int i = 0;
    while (i < count)
    {
        array[i] = rnd.Next(0, 100);
        i += 1;
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    int count = array.Length;
    while (i < count)
    {
        if (i == 0) Console.Write($"[");
        if (i == count - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
        i += 1;
    }
}
FillArray(arr);
PrintArray(arr);