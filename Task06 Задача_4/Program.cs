//Задача 4
//Принимает на вход 3 числа, найти максимум.

Console.WriteLine("Enter 3 integers to see the maximal.");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
{
max = b;
}

if(max < c)
{
max = c;
}
Console.WriteLine($"Max is {max}");