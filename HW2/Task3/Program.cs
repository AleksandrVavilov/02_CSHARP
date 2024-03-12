// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// 40  => 4 
// 96  => 9 
// 72  => 7


Console.WriteLine("Введите число от 10 до 99: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 10 || n > 99)
{
    Console.WriteLine("Ошибка ввода!");
}
else
{
int firstDigit = n / 10;
int secondDigit = n % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else  
{
Console.WriteLine(secondDigit);
}
}