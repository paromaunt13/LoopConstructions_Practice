/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу,  в которой запросите пользователя ввести два числа A и B (A<B), 
если (A>B выведите соответствующее предупреждение) 
и выведите суму всех чисел расположенных между данными числами на экран. 
Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.
*/

NumberInput:
    Console.WriteLine("Введите первое число: ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");
    int b = int.Parse(Console.ReadLine());

int sum = 0;

if (a > b)
{
    Console.WriteLine("Первое число должно быть меньше второго!");
    goto NumberInput;
}

for (int i = a; i <= b; i++)
{
    sum += a;
    a++;
    if (a % 2 != 0)
    {
        Console.WriteLine($"Нечетное число - {a}");
    }
}
Console.WriteLine($"Сумма чисел всех чисел - {sum}");

Console.ReadKey();


