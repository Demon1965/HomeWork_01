// See https://aka.ms/new-console-template for more information

Console.Write("Print first number:   ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Print second number:   ");
int number2=Convert.ToInt32(Console.ReadLine());
Console.Write("Print third number:   ");
int number3=Convert.ToInt32(Console.ReadLine());
int max=number1;
if(number1>=max) max=number1;
if(number2>max) max=number2;
if(number3>max) max=number3;
Console.Write($"Maximum {max}");