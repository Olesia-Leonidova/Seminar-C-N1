// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Enter a number to see a multiplication of numbers from 1 up to the user's number.");
int a = Convert.ToInt32(Console.ReadLine());


int Multiply(int num)
{
    int mult = 1; 
    for (int i = 1; i <= num; i++)
    {
       mult = mult * i; 
    }
    return mult;
}

if(a > 0)
{
int multiply = Multiply(a);
Console.WriteLine($"Multiply from 1 to {a} is {multiply}");
}
else Console.WriteLine("Not valid value.");