﻿Console.WriteLine("Введите координату точки X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}