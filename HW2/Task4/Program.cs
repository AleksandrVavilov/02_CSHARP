// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.
// 568  => 5,6,8 
// 8    => 8 
// 9542 => 9,5,4,2


Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine("Ошибка! Задайте натуральное число!");
}
else
{
int a = 10;
while (a < n) //5834 да, 
{
    int count = n; //5834. 
    while (count >= a) //да,да
    {
    count /= 10; //583,58,5
    }
a *= 10; 
Console.Write(count % 10 + ", ");
}
Console.Write(n % 10);
}
