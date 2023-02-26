/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу,  которая будет рассчитывать сумму вклада  в банк. 
Процентную ставку, сумму и срок на которой положили вклад, должен вводить пользователь с клавиатуры.
*/

Console.WriteLine("Введите сумму вклада, грн.:");
float money = float.Parse(Console.ReadLine());

Console.WriteLine("Введите срок вклада, лет:");
int term = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер процентной ставки, %:");
float yearRate = float.Parse(Console.ReadLine());

float deposit = (float)money * yearRate / 100 + money;

for (int i = 1; i < term; i++)
{
    deposit += (float)(deposit * yearRate / 100);

}

Console.WriteLine($"Общая сумма вклада составит {deposit} грн.");

Console.ReadKey();
