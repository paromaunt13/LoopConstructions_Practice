/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, где пользователь вводит любое целое положительное число. 
А программа суммирует все числа от 1 до введенного пользователем числа.
*/

Console.WriteLine("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());

int sum = 0;
int num = 1;

while (num <= number)
{
    sum += num;
    num++;
}

Console.WriteLine($"Сумма всех чисел от 1 до {number} = {sum}");

Console.ReadKey();
