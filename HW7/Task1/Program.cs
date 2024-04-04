// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 5, 6, 7, 8"

void ShowNum(int m, int n)
{
    if (m == n)
    {
        Console.Write(n);
        return;
    }
    if (m < n)
    {
        Console.Write($"{m} ");
        ShowNum(m + 1, n);
        return;
    }
    else
    {
        Console.Write($"{m} ");
        ShowNum(m - 1, n);
        return;
    }

}

Console.WriteLine("Задайте первое натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNum(m, n);