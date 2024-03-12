//  Напишите программу, которая принимает на вход координаты точки (X и Y), 
//  причём X ≠ 0 и Y ≠ 0 
//  и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X, не равную 0");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y, не равную 0");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("Неверный ввод");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Координатная четверть 1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Координатная четверть 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Координатная четверть 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Координатная четверть 4");
}
// АЛЬТЕРНАТИВА СО СТРОКОЙ
// Console.Write("ВведитекоординатыточкиXиYчерезпробел:"); 
// string[]coordinates=Console.ReadLine().Split(' '); 
// intx=Convert.ToInt32(coordinates[0]); 
// inty=Convert.ToInt32(coordinates[1]); 
// if(x>0&&y>0) Console.WriteLine("1"); 
// elseif(x<0&&y>0) 
// Console.WriteLine("2"); 
// elseif(x<0&&y<0) 
// Console.WriteLine("3"); 
// elseif(x>0&&y<0) 
// Console.WriteLine("4"); 
// else Console.WriteLine("Точканаходитсянаосикоординат"); }