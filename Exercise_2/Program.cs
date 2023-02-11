// Напишите программу, которая на вход принимает два числа и выдает число большее.

Console.Write("Print first number:   ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Print second number:   ");
int number2=Convert.ToInt32(Console.ReadLine());

if(number1>number2)
    {
        Console.Write($"Maximum {number1}");
    }
else
    {
        Console.Write($"Maximum {number2}");
    }
