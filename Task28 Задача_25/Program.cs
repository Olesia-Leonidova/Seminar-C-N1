// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Число А любое, хоть отрицательное

Console.WriteLine("Enter 2 integers. Where the 2nd number is an exponent of the 1st.");
Console.WriteLine("Enter number 1:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2:");
int b = Convert.ToInt32(Console.ReadLine());

double Exponentiation(int num1, int num2)
{
    int mult = 1;
    for (int i = 1; i <= num2; i++)
    {
        mult = mult * num1;
    }
return mult;
}

double result = Exponentiation(a, b);
// Console.WriteLine(result);

void Print(int n1, int n2)
{
   Console.Write(result);
}

Exponentiation(a, b);
Print(a, b);