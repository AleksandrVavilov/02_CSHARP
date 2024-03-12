// Напишите программу, которая выводит третью с конца цифру заданного числа или сообщает,
// что третьей цифры нет. 
// 456  =>  6 
// 7812  =>  8 
// 91  =>  Третьей цифры нет


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
 num *= -1;   
}
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(num > 999)
    {
    num /= 10;
    }
Console.WriteLine(num % 10);
}