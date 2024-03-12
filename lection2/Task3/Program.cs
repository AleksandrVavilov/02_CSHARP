
int[] arr = { -2, -5, 4, -7, 8, 5, 6, 2, 3, 10 };
int i = 0;
while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}
