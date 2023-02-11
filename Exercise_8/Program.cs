// See https://aka.ms/new-console-template for more information

Console.Write("Print number:   ");
int N=Convert.ToInt32(Console.ReadLine());
int temp=2;
while(temp<=N)
{
    Console.Write($"{temp} ");
    temp=temp+2;
}
