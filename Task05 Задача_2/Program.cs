//Задача 2: Написать программу, принимающую 2 числа на вход, определяет max 
//Например, a=5, b=7 -> max=7; a=-2, b=-10_>max=-2

//Проверить дополнительно на равенство, если числа равны.

Console.WriteLine("Enter two numbers to find out a higher and a lower number");
Console.WriteLine("Enter 1st number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number:");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"Max = {a}. Min = {b}");
}

else if (a < b)
{
Console.WriteLine($"Max = {b}. Min = {a}");
}

else
{
    Console.WriteLine($"Max = {a}.");
}