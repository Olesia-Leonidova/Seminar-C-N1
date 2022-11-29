// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Применяем функции (методы)

Console.WriteLine("Enter a number to see it's 3rd digit:");
int a = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    while (num > 999)
          {
           num =  num / 10;
          }
           int digit3 = num % 10; 
           return digit3; 
}
 

if (a > 999) Console.WriteLine($"The 3rd digit is {ThirdDigit(a)}");
else Console.WriteLine("There is no 3rd digit");
