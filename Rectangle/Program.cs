﻿/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой создайте две целочисленные переменные и задайте им некоторые значения. 
Применяя технику вложенных циклов, нарисуйте прямоугольник из звездочек. 
Используйте значения ранее созданных переменных для указания высоты и ширины прямоугольника
*/

int height = 13;
int width = 9;

for (int i = 0; i < height; i++)
{
	for (int j = 0; j < width; j++)
	{
		Console.Write('*');
	}
	Console.WriteLine('*');
}

Console.ReadKey();