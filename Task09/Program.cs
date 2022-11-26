// Программа выводит случайное число из отрезка (10, 99) и показывает наибольшую цифру числа
// 56 -- 6, 82--8, 17 -- 7.

int number = new Random().Next(10, 100);
Console.WriteLine($"random number from the segment 10-99 --> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit) Console.WriteLine($"The greater digit of the number is  {firstDigit}");
else Console.WriteLine($"The greater digit of the number is  {secondDigit}");