/*
 Используя Visual Studio, создайте проект по шаблону Console Application.                                
Напишите программу, которая будет складывать, вычитать, умножать или делить два числа. 
Числа и знак операции вводятся пользователем. После выполнения вычисления программа не должна завершаться, 
а должна запрашивать новые данные для вычислений. 
Завершение программы должно выполняться при вводе символа '0' в качестве знака операции. 
Если пользователь вводит неверный знак (не '0', '+', '-', '*', '/'), 
то программа должна сообщать ему об ошибке и снова запрашивать знак операции. 
Также сообщать пользователю о невозможности деления на ноль, если он ввел 0 в качестве делителя.  
*/
numberInput:
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

signInput:
Console.WriteLine("Введите знак операции (+, -, * или /):");
char sign = char.Parse(Console.ReadLine());

int addition = a + b;
int subtract = a - b;
int multiply = a * b;
float division = (float)a / b;

switch (sign)
{
        case '0':
            Environment.Exit(0);
            break;
        case '+':
            Console.WriteLine($"Результат сложения {a} и {b} равен {addition}");
            break;
        case '-':
            Console.WriteLine($"Результат вычитания {a} и {b} равен {subtract}");
            break;
        case '*':
            Console.WriteLine($"Результат умножения {a} и {b} равен {multiply}");
            break;
        case '/':
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                break;
            }
            Console.WriteLine($"Результат деления {a} и {b} равен {division}");
            break;            
        default:
            Console.WriteLine("Введён недопустимый символ!");
            goto signInput;
}
goto numberInput;



