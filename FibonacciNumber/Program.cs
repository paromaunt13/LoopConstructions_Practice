/*
Используя Visual Studio, создайте проект по шаблону Console Application.                                      
Напишите программу, которая выводит на экран столько элементов ряда Фибоначчи, сколько указал пользователь. 
Например, если на ввод поступило число 6, то вывод должен содержать шесть первых чисел ряда Фибоначчи: 1 2 3 5 8 13. 
(Числа Фибоначчи -  элементы числовой последовательности,  в которой первые два числа равны либо 1 и 1, либо 0 и 1,
а каждое последующее число равно сумме двух предыдущих чисел, например 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89).
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int c;

Console.WriteLine($"{number} первых чисел ряда Фибоначчи:");
for (int i = 0; i < number; i++)
{
    c = a;
    a = b;
    b += c;
    Console.Write($"{b} ");
}

Console.ReadKey();