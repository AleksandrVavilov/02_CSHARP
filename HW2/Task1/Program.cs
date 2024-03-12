// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// a=50   => нет 
// a=7    => нет 
// a=322  => да


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int ost7 = num % 7;
int ost23 = num % 23;
if (ost7 == 0 && ost23 == 0)
{
    Console.WriteLine("ДА");
}
else
{
Console.WriteLine("НЕТ");
}