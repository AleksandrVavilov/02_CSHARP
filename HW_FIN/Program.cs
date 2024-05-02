
static string[] CreateArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int Length = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[Length];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите строку массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
static string[] CreateAndFillFinArray(string[] array)
{
    int k = 0;
    string[] FinArr = new string[k];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            k++;
            Array.Resize(ref FinArr, k);
            FinArr[k-1] = array[i];
        }
    }
    return FinArr;
}
static void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"'{array[i]}', ");
        }
        else
        {
            Console.Write($"'{array[i]}'");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
string[] arr = CreateArray();
string[] FinArr = CreateAndFillFinArray(arr);
Console.WriteLine("Начальный массив: ");
PrintArray(arr);
Console.WriteLine("Массив из строк начального массива длиной <=3: ");
PrintArray(FinArr);

