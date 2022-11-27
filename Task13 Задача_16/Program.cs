// 16. Напишите программу, которая принимает на 
// вход два числа и проверяет, является ли одно 
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Так решила задачу я:
Console.WriteLine("Enter two numbers to find out if one is a square of another.");
Console.WriteLine("Enter 1st number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number:");
int b = Convert.ToInt32(Console.ReadLine());

bool Square(int n1, int n2)
{
    return n1 == n2 *n2 || n2 == n1 * n1;
}
bool result = Square(a, b);
Console.WriteLine(result ? "Yes." : "No.");


//А так решили ребята на вэбинаре:
// Console.WriteLine("Введите первое число:");
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int num2= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(square(num1,num2) ? "Да" : "Нет");

// bool square (int firstNum, int secondNum)
// {
// return (firstNum == secondNum*secondNum) || (secondNum == firstNum*firstNum);
// }