/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет выводить  на экран числа от 1 до 5.
Написать три варианта реализации (while, do...while, for).
*/
int num = 1;
int num1 = 1;
int num2 = 1;

while (num <= 5)
{
    Console.Write(num);
    num++;
}

Console.WriteLine();

do
{
    Console.Write(num1);
    num1++;
} while (num1 <= 5);

Console.WriteLine();

for (int i = 0; i <= 4; i++)
{
    Console.Write(num2);
    num2++;
}

Console.ReadKey();