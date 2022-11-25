//Проверяет, является ли первое число кваждратом второго
//a=25, b=5 - да
//a=2, b=10 - нет
//a=9, b=-3 - да
//a=-3, b=9 - нет


Console.Clear();
Console.WriteLine("Insert two integers to check out if the 1st one is the square of the 2nd one!");
Console.WriteLine("Integer 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Integer 2:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("The answer is: ");
    Console.Write($"YES, {number1} is a square of number {number2}");
}

else
{
    Console.WriteLine("The answer is: ");
    Console.Write($"NO, {number1} is not a square of {number2}");
}