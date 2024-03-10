// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N.
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4 
// 2 => -2, -1, 0, 1, 2
Console.WriteLine("Введите целое натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
if (n>0)
{
    while (count <= n)
{
    Console.Write(count + " ");
    count = count + 1;
}
}
else
{
    Console.WriteLine("Некорректный ввод, читай внимательнее");
}