﻿// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер координатной четверти плоскости, в которой находится эта точка.(ДЗ)

int x = 6;
int y = 8;

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Некорректные координаты!");
}
