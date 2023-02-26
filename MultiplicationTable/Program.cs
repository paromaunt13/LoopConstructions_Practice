/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет выводить на экран таблицу умножения на 3.
*/

int a = 1;
int b = 3;
while (a <= 10)
{
    Console.WriteLine($"{a} * {b} = {a * b}");
    a++;
}

Console.ReadKey(); 
