﻿// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1

// идея решения: n / 10  а потом снова на 10 но через % и получем второе число

// Применяем функции (методы)

Console.WriteLine("Enter a 3-digit number:");
int nmbr = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int a)
{
int secondDigit = (a / 10) % 10;
return secondDigit;
}

int result = SecondDigit(nmbr);

if (99 < nmbr & nmbr < 1000)Console.WriteLine($"The 2nd digit of entered number is: {result}.");
else Console.WriteLine("The entered value is not valid.");





// Console.WriteLine("Enter a 3-digit number:");
// int nmbr = Convert.ToInt32(Console.ReadLine());

// if (99 < nmbr & nmbr < 1000)
// {
//     int digit2 = (nmbr / 10) % 10;
//     Console.WriteLine($"The 2nd digit of entered number is: {digit2} ");
// }

// else Console.WriteLine("The entered value is not valid.");